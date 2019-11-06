namespace Doan1
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameCusBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Cus:";
            // 
            // lblNameCusBill
            // 
            this.lblNameCusBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameCusBill.Location = new System.Drawing.Point(101, 9);
            this.lblNameCusBill.Name = "lblNameCusBill";
            this.lblNameCusBill.Size = new System.Drawing.Size(240, 23);
            this.lblNameCusBill.TabIndex = 1;
            this.lblNameCusBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(12, 51);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBill.Size = new System.Drawing.Size(329, 110);
            this.txtBill.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total:";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBill.Location = new System.Drawing.Point(101, 174);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(240, 23);
            this.lblTotalBill.TabIndex = 1;
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExportFile
            // 
            this.btnExportFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExportFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFile.Location = new System.Drawing.Point(266, 209);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(75, 40);
            this.btnExportFile.TabIndex = 4;
            this.btnExportFile.Text = "Export File";
            this.btnExportFile.UseVisualStyleBackColor = false;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblTotalBill);
            this.Controls.Add(this.lblNameCusBill);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportFile;
        public System.Windows.Forms.Label lblNameCusBill;
        public System.Windows.Forms.Label lblTotalBill;
        public System.Windows.Forms.TextBox txtBill;
    }
}