using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Form1()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_Invoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "doc files (*.doc)|*.docx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInvoiceFile.Text = openFileDialog.FileName;
            }

        }

        private void btn_Passenger_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "xls files (*.xls)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPassengerFile.Text = openFileDialog.FileName;
            }
        }

        private void btnGetPdf_Click(object sender, EventArgs e)
        {            
            GenerateInvoice(DocType.Pdf);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(2000);
        }

        private void btnGetWord_Click(object sender, EventArgs e)
        {
            GenerateInvoice(DocType.Word);
        }

        private void btnGetBoth_Click(object sender, EventArgs e)
        {
            GenerateInvoice(DocType.Both);
        }
        private void ShowProgress()
        {
            lblMessage.Text = $"Invoice document modified.";
            lblMessage.ForeColor = Color.DarkOliveGreen;
        }
        private void GenerateInvoice(DocType docType) 
        {
            ShowProgress();
            var dt = ExcelHelper.GetExcelData(txtPassengerFile.Text);
            Dictionary<string, string> txtToReplaceData;
            foreach (DataRow item in dt.Rows)
            {
                txtToReplaceData = new Dictionary<string, string>();
                txtToReplaceData.Add("@@NAME@@", item[0].ToString());
                Common.ReplaceTextInWord(txtInvoiceFile.Text, txtToReplaceData);
            }
            switch (docType) 
            {
                case DocType.Word:
                    break;
                case DocType.Pdf:
                    break;
                case DocType.Both:
                    break;
            }
        }
    }


}
