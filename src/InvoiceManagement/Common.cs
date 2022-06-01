using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace InvoiceManagement
{
    public enum DocType
    {
        Word = 1,
        Pdf = 2,
        Both = 3
    }
    public class Common
    {
        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        public static void ReplaceTextInWord(string docPath, Dictionary<string, string> strToReplace)
        {
            //Creates new Word document instance for Word processing
            using (WordDocument document = new WordDocument())
            {
                string newFileName = Path.GetDirectoryName(docPath) + "\\" + (GetTimestamp(DateTime.Now) + ".docx");
                //Opens the input Word document
                Stream docStream = File.OpenRead(docPath);
                document.Open(docStream, FormatType.Docx);
                docStream.Dispose();
                //Finds all the occurrence of a misspelt word and replaces with desired word in the Word document.
                foreach (var item in strToReplace)
                {
                    document.Replace(item.Key, item.Value, true, true);
                }
                //Saves the resultant file in the given path
                docStream = File.Create(newFileName);
                document.Save(docStream, FormatType.Docx);
                docStream.Dispose();
                RemoveSyncFusionText(newFileName);
            }
        }

        public static void RemoveSyncFusionText(string fileName)
        {

            using (WordprocessingDocument doc = WordprocessingDocument.Open(fileName, true))
            {
                var body = doc.MainDocumentPart.Document.Body;
                string txtToReplace = "Created with a trial version of Syncfusion Essential DocIO.";

                foreach (var headerPart in doc.MainDocumentPart.HeaderParts)
                {
                    //Gets the text in headers
                    foreach (var currentText in headerPart.RootElement.Descendants<DocumentFormat.OpenXml.Wordprocessing.Text>())
                    {
                        currentText.Text = currentText.Text.Replace(txtToReplace, "");
                    }
                }

                foreach (var text in body.Descendants<Text>())
                {
                    if (text.Text.Contains(txtToReplace))
                    {
                        text.Text = text.Text.Replace(txtToReplace, "");
                    }
                }
            }

        }
    }
}
