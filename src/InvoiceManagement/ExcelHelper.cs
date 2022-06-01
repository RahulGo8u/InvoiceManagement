using System.Data.OleDb;
using System.IO;

namespace InvoiceManagement
{
    public static class ExcelHelper
    {

        public static System.Data.DataTable GetExcelData(string filePath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (OleDbConnection conn = new OleDbConnection(GetExcelConStr(filePath)))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", conn);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;
        }
        private static string GetExcelConStr(string filePath)
        {
            string fileEtn = Path.GetExtension(filePath);
            if (fileEtn.Equals(".xls"))
            {
                return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={filePath};Extended Properties='Excel 8.0;HDR=Yes;'";
            }
            else if (fileEtn.Equals(".xlsx"))
            {
                return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties = 'Excel 12.0 Xml;HDR=YES;'";
            }
            return "";
        }
    }
}
