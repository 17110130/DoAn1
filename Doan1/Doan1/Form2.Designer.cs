namespace Doan1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnPromotions = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gioiThieuUC1 = new Doan1.UserControls.GioiThieuUC();
            this.promotionsUC1 = new Doan1.PromotionsUC();
            this.moneyUC1 = new Doan1.MoneyUC();
            this.menuUC1 = new Doan1.MenuUC();
            this.orderUC1 = new Doan1.UserControls.OrderUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(463, 45);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 28);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(340, 43);
            this.btnMoney.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(108, 28);
            this.btnMoney.TabIndex = 3;
            this.btnMoney.Text = "Money";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnPromotions
            // 
            this.btnPromotions.Location = new System.Drawing.Point(219, 43);
            this.btnPromotions.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromotions.Name = "btnPromotions";
            this.btnPromotions.Size = new System.Drawing.Size(108, 29);
            this.btnPromotions.TabIndex = 4;
            this.btnPromotions.Text = "Promotions";
            this.btnPromotions.UseVisualStyleBackColor = true;
            this.btnPromotions.Click += new System.EventHandler(this.btnPromotions_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(66, 45);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(108, 29);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gioiThieuUC1);
            this.panel1.Controls.Add(this.promotionsUC1);
            this.panel1.Controls.Add(this.moneyUC1);
            this.panel1.Controls.Add(this.menuUC1);
            this.panel1.Location = new System.Drawing.Point(219, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 261);
            this.panel1.TabIndex = 6;
            // 
            // gioiThieuUC1
            // 
            this.gioiThieuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioiThieuUC1.Location = new System.Drawing.Point(0, 0);
            this.gioiThieuUC1.Name = "gioiThieuUC1";
            this.gioiThieuUC1.Size = new System.Drawing.Size(353, 261);
            this.gioiThieuUC1.TabIndex = 3;
            // 
            // promotionsUC1
            // 
            this.promotionsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionsUC1.Location = new System.Drawing.Point(0, 0);
            this.promotionsUC1.Name = "promotionsUC1";
            this.promotionsUC1.Size = new System.Drawing.Size(353, 261);
            this.promotionsUC1.TabIndex = 2;
            // 
            // moneyUC1
            // 
            this.moneyUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyUC1.Location = new System.Drawing.Point(0, 0);
            this.moneyUC1.Name = "moneyUC1";
            this.moneyUC1.Size = new System.Drawing.Size(353, 261);
            this.moneyUC1.TabIndex = 1;
            // 
            // menuUC1
            // 
            this.menuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUC1.Location = new System.Drawing.Point(0, 0);
            this.menuUC1.Name = "menuUC1";
            this.menuUC1.Size = new System.Drawing.Size(353, 261);
            this.menuUC1.TabIndex = 0;
            // 
            // orderUC1
            // 
            this.orderUC1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.orderUC1.Location = new System.Drawing.Point(12, 93);
            this.orderUC1.Name = "orderUC1";
            this.orderUC1.Size = new System.Drawing.Size(203, 260);
            this.orderUC1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.orderUC1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPromotions);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnPromotions;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private PromotionsUC promotionsUC1;
        private MoneyUC moneyUC1;
        private MenuUC menuUC1;
        private UserControls.GioiThieuUC gioiThieuUC1;
        private UserControls.OrderUC orderUC1;
    }
}