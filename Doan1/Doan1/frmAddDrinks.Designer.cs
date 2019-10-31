namespace Doan1
{
    partial class frmAddDrinks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtPromotionAdd = new System.Windows.Forms.TextBox();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.btnAddDrinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Promotion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price:";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(90, 37);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(266, 20);
            this.txtIDAdd.TabIndex = 2;
            this.txtIDAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(90, 73);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(266, 20);
            this.txtNameAdd.TabIndex = 2;
            this.txtNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPromotionAdd
            // 
            this.txtPromotionAdd.Location = new System.Drawing.Point(90, 109);
            this.txtPromotionAdd.Name = "txtPromotionAdd";
            this.txtPromotionAdd.Size = new System.Drawing.Size(266, 20);
            this.txtPromotionAdd.TabIndex = 2;
            this.txtPromotionAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(90, 145);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(266, 20);
            this.txtPriceAdd.TabIndex = 2;
            this.txtPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddDrinks
            // 
            this.btnAddDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDrinks.Location = new System.Drawing.Point(248, 177);
            this.btnAddDrinks.Name = "btnAddDrinks";
            this.btnAddDrinks.Size = new System.Drawing.Size(108, 54);
            this.btnAddDrinks.TabIndex = 3;
            this.btnAddDrinks.Text = "Add Drink";
            this.btnAddDrinks.UseVisualStyleBackColor = true;
            this.btnAddDrinks.Click += new System.EventHandler(this.btnAddDrinks_Click);
            // 
            // frmAddDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.btnAddDrinks);
            this.Controls.Add(this.txtPriceAdd);
            this.Controls.Add(this.txtPromotionAdd);
            this.Controls.Add(this.txtNameAdd);
            this.Controls.Add(this.txtIDAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddDrinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.TextBox txtPromotionAdd;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.Button btnAddDrinks;
    }
}