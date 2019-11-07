using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Doan1
{
    public partial class Form2 : Form
    {
        HoaDon hoadon;

        public Form2()
        {
            InitializeComponent();
            createDatabase();
            gioiThieuUC1.BringToFront();
            pnOrder.Hide();
            
        }

        public static LinkedListHD<DoUong> menu = new LinkedListHD<DoUong>();
        LinkedListHD<HoaDon> dsHoaDon = new LinkedListHD<HoaDon>();
        frmHoaDon frmHoaDon = null;
        frmAddDrinks frmAddDrinks = null;
        frmRemoveDrink frmRemoveDrinks = null;
        frmAddAfter frmAddAfter = null;
        frmAddBefore frmAddBefore = null;

        double Total = 0;
        int IDHoaDon = 1;

        public void createDatabase()
        {          
            string dsnuoc = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\dsnuoc.txt";
            string giatien = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\gia.txt";
            string khuyenmai = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\dskhuyenmai.txt";

            string[] arrnuoc;
            string[] arrgia;
            string[] arrkhuyenmai;

            if (System.IO.File.Exists(dsnuoc))
            {
                string n1, n2,t2,k2;
                arrnuoc = System.IO.File.ReadAllLines(dsnuoc);
                arrgia = System.IO.File.ReadAllLines(giatien);
                arrkhuyenmai = System.IO.File.ReadAllLines(khuyenmai);
                
                for (int i = 0; i < arrnuoc.Length; i++)
                {
                    DoUong douong = new DoUong();
                    string s = arrnuoc[i];
                    string x = arrgia[i];
                    string k = arrkhuyenmai[i];

                    n1 = s.Substring(0, 3).Trim();                  
                    n2 = s.Substring(3).Trim();

                    t2 = x.Substring(3).Trim();

                    k2 = k.Substring(3).Trim();

                    douong.ID = int.Parse(n1);
                    douong.Name = n2;
                    douong.Promotion = int.Parse(k2);
                    douong.Price = double.Parse(t2);
         
                    menu.Add(douong);
                    
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuUC1.txbMenu.Text = "";
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    menuUC1.txbMenu.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Name + "\r\n";
                }
                else
                {
                    menuUC1.txbMenu.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Name + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
            menuUC1.BringToFront();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            moneyUC1.txbMoney.Text = "";
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    moneyUC1.txbMoney.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Price + "\r\n";
                }
                else
                {
                    moneyUC1.txbMoney.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Price + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
            moneyUC1.BringToFront();
        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
            promotionsUC1.txbPromotions.Text = "";
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    promotionsUC1.txbPromotions.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Promotion + "\r\n";
                }
                else
                {
                    promotionsUC1.txbPromotions.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Promotion + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
            promotionsUC1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnOrder.Show();
        }
      
        private void btnAddOrder_Click(object sender, EventArgs e)
        {        
            Validation validation = new Validation();

            string content = "";
            content += validation.Check_Empty("Name Cus", txtNameCusOrder);
            content += validation.Check_Empty("ID", txtIDOrder);
            content += validation.Check_Empty("Amount", txtAmountOrder);

            if ( content != "" )
            {
                MessageBox.Show(content, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int test = 0;
                LinkedListHD<DoUong>.Node NodeDoUong = menu.pHead;

                while (NodeDoUong != null)
                {
                    if (NodeDoUong.data.ID.ToString() == txtIDOrder.Text)
                        test = 1;
                    NodeDoUong = NodeDoUong.pNext;
                }

                if ( test == 0 )
                {
                    MessageBox.Show("ID đồ uống không tồn tại trong menu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Total += double.Parse(lblPriceOrder.Text);
                if (Total <= 0)
                {
                    lblTotalOrder.Text = "";
                }
                else
                {
                    lblTotalOrder.Text = Total + "";
                }

                LinkedListHD<DoUong>.Node Node = menu.pHead;

                while (Node != null)
                {
                    if (Node.data.ID.ToString() == txtIDOrder.Text)
                    {
                       
                        DoUong douong = Node.data;
                        LinkedListHD<HoaDon>.Node NodeHoaDon = dsHoaDon.pHead;
                        while ( NodeHoaDon != null )
                        {
                            if (NodeHoaDon.data.douong.ID.ToString() == txtIDOrder.Text )
                            {
                                NodeHoaDon.data.Count += int.Parse(txtAmountOrder.Text);
                                hoadon.Total += double.Parse(lblPriceOrder.Text);
                                txtAmountOrder.Text = "1";
                                if (NodeHoaDon.data.Count <= 0 )
                                {
                                    dsHoaDon.Remove(NodeHoaDon);
                                }
                                return;
                            }
                            NodeHoaDon = NodeHoaDon.pNext;
                        }
                        hoadon = new HoaDon();
                        hoadon.IdHD = IDHoaDon;
                        hoadon.CustomerName = txtNameCusOrder.Text;
                        hoadon.Total += double.Parse(lblPriceOrder.Text);
                        hoadon.douong = douong;
                        hoadon.Count = int.Parse(txtAmountOrder.Text);
                        dsHoaDon.Add(hoadon);
                    }
                    Node = Node.pNext;
                }              
            }
            txtAmountOrder.Text = "1";
        }

        private void txtIDOrder_TextChanged(object sender, EventArgs e)
        {
            if (txtIDOrder.Text != "")
            {
                txtAmountOrder.Text = "1";      
                LinkedListHD<DoUong>.Node node = menu.pHead;
                while (node != null)
                {
                    if (node.data.ID.ToString() == txtIDOrder.Text)
                    {
                        lblPriceOrder.Text = int.Parse(txtAmountOrder.Text) * node.data.Price + "";
                        return;
                    }
                    node = node.pNext;
                }
            }
        }

        public string Get_Price(string id)
        {
            LinkedListHD<DoUong>.Node NodeDoUong = menu.pHead;
            while (NodeDoUong != null)
            {
                if (NodeDoUong.data.ID.ToString() == id )
                {
                    return NodeDoUong.data.Price + "";
                }
                NodeDoUong = NodeDoUong.pNext;
            }
            return "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnOrder.Hide();
        }

        private void txtAmountOrder_TextChanged(object sender, EventArgs e)
        {
            int num = 1;
            if ( txtAmountOrder.Text == "0" )
            {
                txtAmountOrder.Text = "1";
            }
            else
            {
              
                bool convert = int.TryParse(txtAmountOrder.Text, out num);
                if ( convert == true )
                {
                    LinkedListHD<HoaDon>.Node NodeHoaDon = dsHoaDon.pHead;
                    if ( NodeHoaDon == null )
                    {
                        if ( num < 0 )
                        {
                            MessageBox.Show("Hóa đơn trống không thể trả lại đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                            return;
                        }
                    }

                    while (NodeHoaDon != null)
                    {
                        if (NodeHoaDon.data.douong.ID.ToString() == txtIDOrder.Text)
                        {
                            // Đồ uống đã có trong hóa đơn ===> order thêm
                            if (num > 0)
                            {
                                if ( NodeHoaDon.data.Count + num > 5 && NodeHoaDon.data.douong.Promotion != 0)
                                {
                                    if ( NodeHoaDon.data.douong.Promotion == 1 )
                                    {
                                        lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) * 0.8 + "";
                                        return;
                                    }
                                    else
                                    {
                                        lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) * 0.7 + "";
                                        return;
                                    }                     
                                }
                                else
                                {
                                    lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                                    return;
                                }                              
                            }
                            else
                            {
                               if ( Math.Abs(num) >= NodeHoaDon.data.Count)
                                {
                                    lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                                    MessageBox.Show("Bạn muốn trả lại đồ uống này","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    return;
                                }
                               else
                                {
                                    lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) + "";
                                    return;
                                }
                            }
                        }                     
                        NodeHoaDon = NodeHoaDon.pNext;
                    }          
                    // Đồ uống chưa có trong hóa đơn
                        if (num < 0)
                        {
                            MessageBox.Show("Bạn chưa order đồ uống này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtAmountOrder.Text = "1";
                            return;
                        }
                    else
                    {
                        LinkedListHD<HoaDon>.Node Node = dsHoaDon.pHead;
                        while( Node != null)
                        {
                            if (Node.data.douong.Promotion == 1)
                            {
                                lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) * 0.8 + "";
                                return;
                            }
                            else
                            {
                                if (Node.data.douong.Promotion == 2)
                                {
                                    lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) * 0.7 + "";
                                    return;
                                }
                            }
                            Node= Node.pNext;
                        }
                        
                        // Promotion == 0
                        lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text))) + "";
                        return;
                    }
                }
                else {
                    // Không convert được  
                }
            }
            // Đồ uống chưa có trong hóa đơn
            if (txtIDOrder.Text != "")
            {
                if ( num > 5 )
                {
                    LinkedListHD<HoaDon>.Node NodeHoaDon = dsHoaDon.pHead;
                    while (NodeHoaDon != null)
                    {
                        if ( NodeHoaDon.data.douong.ID.ToString() == txtIDOrder.Text )
                        {
                            if ( NodeHoaDon.data.douong.Promotion == 1 )
                            {
                                lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text)))*0.8 + "";
                                return;
                            }
                            else
                            {
                                if ( NodeHoaDon.data.douong.Promotion == 2 )
                                {
                                    lblPriceOrder.Text = (num * double.Parse(Get_Price(txtIDOrder.Text)))*0.7 + "";
                                    return;
                                }
                                else
                                {
                                    lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                                    return;
                                }
                            }
                        }
                        NodeHoaDon = NodeHoaDon.pNext;
                    }
                }
            }
        }

        public string Show_Textbox()
        {
            string output = "";
            LinkedListHD<HoaDon>.Node NodeHoaDon = dsHoaDon.pHead;
            while ( NodeHoaDon != null )
            {
                output += NodeHoaDon.data.douong.Name + "\r\n" + "Amount: " + NodeHoaDon.data.Count + "\r\n";
                NodeHoaDon = NodeHoaDon.pNext;
            }
            return output;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmHoaDon = new frmHoaDon();
         
            frmHoaDon.Width = 400;
            frmHoaDon.Height = 400;

            if (hoadon == null )
            {
                MessageBox.Show("Mời bạn order đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmHoaDon.lblIDBill.Text = hoadon.IdHD + "";
            frmHoaDon.lblNameCusBill.Text = txtNameCusOrder.Text;
            frmHoaDon.txtBill.Text = Show_Textbox() + "\r\n";
            frmHoaDon.lblTotalBill.Text = lblTotalOrder.Text + "";

            frmHoaDon.ShowDialog();

            txtNameCusOrder.Text = "";
            txtIDOrder.Text = "";
            txtAmountOrder.Text = "";
            lblPriceOrder.Text = "";
            lblTotalOrder.Text = "";
            Total = 0;
            IDHoaDon++;

            dsHoaDon = new LinkedListHD<HoaDon>();

        }

        private void addDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDrinks = new frmAddDrinks();

            frmAddDrinks.Width = 400;
            frmAddDrinks.Height = 300;

            frmAddDrinks.ShowDialog();
        }

        private void removeDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveDrinks = new frmRemoveDrink();

            frmRemoveDrinks.Width = 400;
            frmRemoveDrinks.Height = 300;

            frmRemoveDrinks.ShowDialog();
        }

        private void addAfterDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAfter = new frmAddAfter();

            frmAddAfter.Width = 400;
            frmAddAfter.Height = 500;

            frmAddAfter.ShowDialog();
        }

        private void addBeforeDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBefore = new frmAddBefore();

            frmAddBefore.Width = 400;
            frmAddBefore.Height = 500;

            frmAddBefore.ShowDialog();
        }
    }
}
