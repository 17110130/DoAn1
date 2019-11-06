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
            this.pnOrder = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblPriceOrder = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtNameCusOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountOrder = new System.Windows.Forms.TextBox();
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.drinkManagentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAfterDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBeforeDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnOrder.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.promotionsUC1.BackColor = System.Drawing.Color.SandyBrown;
            this.promotionsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionsUC1.Location = new System.Drawing.Point(0, 0);
            this.promotionsUC1.Name = "promotionsUC1";
            this.promotionsUC1.Size = new System.Drawing.Size(353, 261);
            this.promotionsUC1.TabIndex = 2;
            // 
            // moneyUC1
            // 
            this.moneyUC1.BackColor = System.Drawing.Color.SandyBrown;
            this.moneyUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyUC1.Location = new System.Drawing.Point(0, 0);
            this.moneyUC1.Name = "moneyUC1";
            this.moneyUC1.Size = new System.Drawing.Size(353, 261);
            this.moneyUC1.TabIndex = 1;
            // 
            // menuUC1
            // 
            this.menuUC1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuUC1.Location = new System.Drawing.Point(0, 0);
            this.menuUC1.Name = "menuUC1";
            this.menuUC1.Size = new System.Drawing.Size(353, 261);
            this.menuUC1.TabIndex = 0;
            // 
            // pnOrder
            // 
            this.pnOrder.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnOrder.Controls.Add(this.btnClose);
            this.pnOrder.Controls.Add(this.btnPrint);
            this.pnOrder.Controls.Add(this.lblTotalOrder);
            this.pnOrder.Controls.Add(this.lblPriceOrder);
            this.pnOrder.Controls.Add(this.label5);
            this.pnOrder.Controls.Add(this.label4);
            this.pnOrder.Controls.Add(this.btnAddOrder);
            this.pnOrder.Controls.Add(this.txtNameCusOrder);
            this.pnOrder.Controls.Add(this.label3);
            this.pnOrder.Controls.Add(this.label2);
            this.pnOrder.Controls.Add(this.txtAmountOrder);
            this.pnOrder.Controls.Add(this.txtIDOrder);
            this.pnOrder.Controls.Add(this.label1);
            this.pnOrder.Location = new System.Drawing.Point(13, 94);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(199, 256);
            this.pnOrder.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(161, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(27, 18);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(63, 212);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(125, 36);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalOrder.Location = new System.Drawing.Point(64, 185);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(124, 20);
            this.lblTotalOrder.TabIndex = 16;
            this.lblTotalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceOrder
            // 
            this.lblPriceOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriceOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPriceOrder.Location = new System.Drawing.Point(64, 126);
            this.lblPriceOrder.Name = "lblPriceOrder";
            this.lblPriceOrder.Size = new System.Drawing.Size(124, 20);
            this.lblPriceOrder.TabIndex = 13;
            this.lblPriceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(113, 155);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtNameCusOrder
            // 
            this.txtNameCusOrder.Location = new System.Drawing.Point(64, 27);
            this.txtNameCusOrder.Name = "txtNameCusOrder";
            this.txtNameCusOrder.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNameCusOrder.Size = new System.Drawing.Size(124, 20);
            this.txtNameCusOrder.TabIndex = 8;
            this.txtNameCusOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name Cus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount:";
            // 
            // txtAmountOrder
            // 
            this.txtAmountOrder.Location = new System.Drawing.Point(64, 93);
            this.txtAmountOrder.Name = "txtAmountOrder";
            this.txtAmountOrder.Size = new System.Drawing.Size(124, 20);
            this.txtAmountOrder.TabIndex = 12;
            this.txtAmountOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountOrder.TextChanged += new System.EventHandler(this.txtAmountOrder_TextChanged);
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Location = new System.Drawing.Point(64, 60);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(124, 20);
            this.txtIDOrder.TabIndex = 10;
            this.txtIDOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIDOrder.TextChanged += new System.EventHandler(this.txtIDOrder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkManagentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // drinkManagentToolStripMenuItem
            // 
            this.drinkManagentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDrinkToolStripMenuItem,
            this.removeDrinksToolStripMenuItem,
            this.addAfterDrinksToolStripMenuItem,
            this.addBeforeDrinksToolStripMenuItem});
            this.drinkManagentToolStripMenuItem.Name = "drinkManagentToolStripMenuItem";
            this.drinkManagentToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.drinkManagentToolStripMenuItem.Text = "Drink Management";
            // 
            // addDrinkToolStripMenuItem
            // 
            this.addDrinkToolStripMenuItem.Name = "addDrinkToolStripMenuItem";
            this.addDrinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDrinkToolStripMenuItem.Text = "Add Drinks";
            this.addDrinkToolStripMenuItem.Click += new System.EventHandler(this.addDrinkToolStripMenuItem_Click);
            // 
            // removeDrinksToolStripMenuItem
            // 
            this.removeDrinksToolStripMenuItem.Name = "removeDrinksToolStripMenuItem";
            this.removeDrinksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeDrinksToolStripMenuItem.Text = "Remove Drinks";
            this.removeDrinksToolStripMenuItem.Click += new System.EventHandler(this.removeDrinksToolStripMenuItem_Click);
            // 
            // addAfterDrinksToolStripMenuItem
            // 
            this.addAfterDrinksToolStripMenuItem.Name = "addAfterDrinksToolStripMenuItem";
            this.addAfterDrinksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAfterDrinksToolStripMenuItem.Text = "AddAfter Drinks";
            this.addAfterDrinksToolStripMenuItem.Click += new System.EventHandler(this.addAfterDrinksToolStripMenuItem_Click);
            // 
            // addBeforeDrinksToolStripMenuItem
            // 
            this.addBeforeDrinksToolStripMenuItem.Name = "addBeforeDrinksToolStripMenuItem";
            this.addBeforeDrinksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBeforeDrinksToolStripMenuItem.Text = "AddBefore Drinks";
            this.addBeforeDrinksToolStripMenuItem.Click += new System.EventHandler(this.addBeforeDrinksToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pnOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPromotions);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.panel1.ResumeLayout(false);
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel pnOrder;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblPriceOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtNameCusOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAmountOrder;
        private System.Windows.Forms.TextBox txtIDOrder;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drinkManagentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAfterDrinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBeforeDrinksToolStripMenuItem;
    }
}