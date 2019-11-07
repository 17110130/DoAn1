namespace Doan1
{
    partial class MenuUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbMenu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMenu
            // 
            this.txbMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.txbMenu.Location = new System.Drawing.Point(0, 27);
            this.txbMenu.Multiline = true;
            this.txbMenu.Name = "txbMenu";
            this.txbMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMenu.Size = new System.Drawing.Size(353, 201);
            this.txbMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // btnExportMenu
            // 
            this.btnExportMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportMenu.Location = new System.Drawing.Point(246, 234);
            this.btnExportMenu.Name = "btnExportMenu";
            this.btnExportMenu.Size = new System.Drawing.Size(75, 23);
            this.btnExportMenu.TabIndex = 2;
            this.btnExportMenu.Text = "Export File";
            this.btnExportMenu.UseVisualStyleBackColor = false;
            this.btnExportMenu.Click += new System.EventHandler(this.btnExportMenu_Click);
            // 
            // MenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnExportMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMenu);
            this.Name = "MenuUC";
            this.Size = new System.Drawing.Size(353, 261);
            this.Load += new System.EventHandler(this.MenuUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbMenu;
        public System.Windows.Forms.Button btnExportMenu;
    }
}
