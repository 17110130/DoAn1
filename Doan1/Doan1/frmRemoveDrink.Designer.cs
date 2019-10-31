namespace Doan1
{
    partial class frmRemoveDrink
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
            this.txtIDRemove = new System.Windows.Forms.TextBox();
            this.btnRemoveDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drinks ID to delete:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // txtIDRemove
            // 
            this.txtIDRemove.Location = new System.Drawing.Point(72, 43);
            this.txtIDRemove.Name = "txtIDRemove";
            this.txtIDRemove.Size = new System.Drawing.Size(226, 20);
            this.txtIDRemove.TabIndex = 2;
            this.txtIDRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemoveDrink
            // 
            this.btnRemoveDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveDrink.Location = new System.Drawing.Point(190, 122);
            this.btnRemoveDrink.Name = "btnRemoveDrink";
            this.btnRemoveDrink.Size = new System.Drawing.Size(108, 54);
            this.btnRemoveDrink.TabIndex = 3;
            this.btnRemoveDrink.Text = "Remove Drink";
            this.btnRemoveDrink.UseVisualStyleBackColor = true;
            this.btnRemoveDrink.Click += new System.EventHandler(this.btnRemoveDrink_Click);
            // 
            // frmRemoveDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 188);
            this.Controls.Add(this.btnRemoveDrink);
            this.Controls.Add(this.txtIDRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRemoveDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Drinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDRemove;
        private System.Windows.Forms.Button btnRemoveDrink;
    }
}