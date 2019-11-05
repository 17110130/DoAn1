namespace Doan1
{
    partial class frmAddAfter
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
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.txtPromotionAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDAfter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAfter.Location = new System.Drawing.Point(248, 259);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(108, 54);
            this.btnAddAfter.TabIndex = 13;
            this.btnAddAfter.Text = "Add After";
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(89, 153);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(266, 20);
            this.txtPriceAdd.TabIndex = 9;
            this.txtPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPromotionAdd
            // 
            this.txtPromotionAdd.Location = new System.Drawing.Point(89, 117);
            this.txtPromotionAdd.Name = "txtPromotionAdd";
            this.txtPromotionAdd.Size = new System.Drawing.Size(266, 20);
            this.txtPromotionAdd.TabIndex = 10;
            this.txtPromotionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(89, 81);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(266, 20);
            this.txtNameAdd.TabIndex = 11;
            this.txtNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(89, 45);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(266, 20);
            this.txtIDAdd.TabIndex = 12;
            this.txtIDAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Promotion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drink Information:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "After Drink:";
            // 
            // txtIDAfter
            // 
            this.txtIDAfter.Location = new System.Drawing.Point(89, 221);
            this.txtIDAfter.Name = "txtIDAfter";
            this.txtIDAfter.Size = new System.Drawing.Size(266, 20);
            this.txtIDAfter.TabIndex = 12;
            this.txtIDAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "After ID:";
            // 
            // frmAddAfter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddAfter);
            this.Controls.Add(this.txtPriceAdd);
            this.Controls.Add(this.txtPromotionAdd);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.txtIDAfter);
            this.Controls.Add(this.txtIDAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddAfter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add After Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAfter;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.TextBox txtPromotionAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDAfter;
        private System.Windows.Forms.Label label7;
    }
}