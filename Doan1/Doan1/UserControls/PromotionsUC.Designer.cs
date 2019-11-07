namespace Doan1
{
    partial class PromotionsUC
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
            this.txbPromotions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportPromotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbPromotions
            // 
            this.txbPromotions.BackColor = System.Drawing.Color.SandyBrown;
            this.txbPromotions.Location = new System.Drawing.Point(0, 27);
            this.txbPromotions.Multiline = true;
            this.txbPromotions.Name = "txbPromotions";
            this.txbPromotions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPromotions.Size = new System.Drawing.Size(353, 203);
            this.txbPromotions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            // 
            // btnExportPromotion
            // 
            this.btnExportPromotion.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportPromotion.Location = new System.Drawing.Point(259, 235);
            this.btnExportPromotion.Name = "btnExportPromotion";
            this.btnExportPromotion.Size = new System.Drawing.Size(75, 23);
            this.btnExportPromotion.TabIndex = 2;
            this.btnExportPromotion.Text = "Export File";
            this.btnExportPromotion.UseVisualStyleBackColor = false;
            this.btnExportPromotion.Click += new System.EventHandler(this.btnExportPromotion_Click);
            // 
            // PromotionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnExportPromotion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPromotions);
            this.Name = "PromotionsUC";
            this.Size = new System.Drawing.Size(353, 261);
            this.Load += new System.EventHandler(this.PromotionsUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbPromotions;
        private System.Windows.Forms.Button btnExportPromotion;
    }
}
