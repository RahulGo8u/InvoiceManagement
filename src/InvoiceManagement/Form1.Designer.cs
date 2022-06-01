namespace InvoiceManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtInvoiceFile = new System.Windows.Forms.TextBox();
            this.btn_InvoiceFile = new System.Windows.Forms.Button();
            this.btnGetPdf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassengerFile = new System.Windows.Forms.TextBox();
            this.btn_Passenger_File = new System.Windows.Forms.Button();
            this.btnGetWord = new System.Windows.Forms.Button();
            this.btnGetBoth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Template";
            // 
            // txtInvoiceFile
            // 
            this.txtInvoiceFile.Location = new System.Drawing.Point(187, 83);
            this.txtInvoiceFile.Name = "txtInvoiceFile";
            this.txtInvoiceFile.Size = new System.Drawing.Size(312, 23);
            this.txtInvoiceFile.TabIndex = 2;
            // 
            // btn_InvoiceFile
            // 
            this.btn_InvoiceFile.Location = new System.Drawing.Point(514, 83);
            this.btn_InvoiceFile.Name = "btn_InvoiceFile";
            this.btn_InvoiceFile.Size = new System.Drawing.Size(65, 23);
            this.btn_InvoiceFile.TabIndex = 4;
            this.btn_InvoiceFile.Text = "Browse";
            this.btn_InvoiceFile.UseVisualStyleBackColor = true;
            this.btn_InvoiceFile.Click += new System.EventHandler(this.btn_Invoice_Click);
            // 
            // btnGetPdf
            // 
            this.btnGetPdf.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetPdf.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGetPdf.Location = new System.Drawing.Point(187, 189);
            this.btnGetPdf.Name = "btnGetPdf";
            this.btnGetPdf.Size = new System.Drawing.Size(87, 36);
            this.btnGetPdf.TabIndex = 6;
            this.btnGetPdf.Text = "Get Pdf";
            this.btnGetPdf.UseVisualStyleBackColor = false;
            this.btnGetPdf.Click += new System.EventHandler(this.btnGetPdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(281, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Copyright: Rahul Anand";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(306, 267);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "This software automates invoice generation for passenger data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passenger Dataset";
            // 
            // txtPassengerFile
            // 
            this.txtPassengerFile.Location = new System.Drawing.Point(187, 137);
            this.txtPassengerFile.Name = "txtPassengerFile";
            this.txtPassengerFile.Size = new System.Drawing.Size(312, 23);
            this.txtPassengerFile.TabIndex = 3;
            // 
            // btn_Passenger_File
            // 
            this.btn_Passenger_File.Location = new System.Drawing.Point(514, 136);
            this.btn_Passenger_File.Name = "btn_Passenger_File";
            this.btn_Passenger_File.Size = new System.Drawing.Size(65, 23);
            this.btn_Passenger_File.TabIndex = 5;
            this.btn_Passenger_File.Text = "Browse";
            this.btn_Passenger_File.UseVisualStyleBackColor = true;
            this.btn_Passenger_File.Click += new System.EventHandler(this.btn_Passenger_File_Click);
            // 
            // btnGetWord
            // 
            this.btnGetWord.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetWord.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGetWord.Location = new System.Drawing.Point(297, 189);
            this.btnGetWord.Name = "btnGetWord";
            this.btnGetWord.Size = new System.Drawing.Size(87, 36);
            this.btnGetWord.TabIndex = 10;
            this.btnGetWord.Text = "Get Word";
            this.btnGetWord.UseVisualStyleBackColor = false;
            this.btnGetWord.Click += new System.EventHandler(this.btnGetWord_Click);
            // 
            // btnGetBoth
            // 
            this.btnGetBoth.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetBoth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetBoth.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGetBoth.Location = new System.Drawing.Point(412, 189);
            this.btnGetBoth.Name = "btnGetBoth";
            this.btnGetBoth.Size = new System.Drawing.Size(87, 36);
            this.btnGetBoth.TabIndex = 11;
            this.btnGetBoth.Text = "Get Both";
            this.btnGetBoth.UseVisualStyleBackColor = false;
            this.btnGetBoth.Click += new System.EventHandler(this.btnGetBoth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(683, 369);
            this.Controls.Add(this.btnGetBoth);
            this.Controls.Add(this.btnGetWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetPdf);
            this.Controls.Add(this.btn_Passenger_File);
            this.Controls.Add(this.btn_InvoiceFile);
            this.Controls.Add(this.txtPassengerFile);
            this.Controls.Add(this.txtInvoiceFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Invoice Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtInvoiceFile;
        private System.Windows.Forms.Button btn_InvoiceFile;
        private System.Windows.Forms.Button btnGetPdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassengerFile;
        private System.Windows.Forms.Button btn_Passenger_File;
        private System.Windows.Forms.Button btnGetWord;
        private System.Windows.Forms.Button btnGetBoth;
    }
}
