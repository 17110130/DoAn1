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
            gioiThieuUC1.BringToFront();
            createDatabase();
            pnOrder.Hide();
            
        }

        public static LinkedListHD<DoUong> menu = new LinkedListHD<DoUong>();
        LinkedListHD<HoaDon> dsHoaDon = new LinkedListHD<HoaDon>();
        frmHoaDon frmHoaDon = null;
        frmAddDrinks frmAddDrinks = null;
        frmRemoveDrink frmRemoveDrinks = null;

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
            menuUC1.BringToFront();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            moneyUC1.BringToFront();

        }

        private void btnPromotions_Click(object sender, EventArgs e)
        {
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

            if ( content != "" )
            {
                MessageBox.Show(content, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Total += double.Parse(lblPriceOrder.Text);
                lblTotalOrder.Text = Total + "";

                LinkedListHD<DoUong>.Node NodeDoUong = menu.pHead;
                while (NodeDoUong != null)
                {
                    if (NodeDoUong.data.ID.ToString() == txtIDOrder.Text)
                    {
                        DoUong douong = NodeDoUong.data;
                        LinkedListHD<HoaDon>.Node NodeHoaDon = dsHoaDon.pHead;
                        while ( NodeHoaDon != null )
                        {
                            if (NodeHoaDon.data.douong.ID.ToString() == txtIDOrder.Text )
                            {
                                NodeHoaDon.data.Count += int.Parse(txtAmountOrder.Text);
                                hoadon.Total += double.Parse(lblPriceOrder.Text);
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
                        IDHoaDon++;
                    }
                    NodeDoUong = NodeDoUong.pNext;
                }              
            }
           
            
        }

        private void txtIDOrder_TextChanged(object sender, EventArgs e)
        {
            txtAmountOrder.Text = "1";

            //lblPriceOrder.Text = Get_Price(txtIDOrder.Text);
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
            if ( txtAmountOrder.Text == "" || txtAmountOrder.Text == "0" )
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
                    }
                    while (NodeHoaDon != null)
                    {
                        if (NodeHoaDon.data.douong.ID.ToString() == txtIDOrder.Text)
                        {
                            if (num > 0)
                            {
                                lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                                return;
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
                                    lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";
                                    return;
                                }
                            }
                        }                     
                        NodeHoaDon = NodeHoaDon.pNext;
                    }                  
                        if (num < 0)
                        {
                            MessageBox.Show("Bạn chưa order đồ uống này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtAmountOrder.Text = "1";
                            return;
                        }                                     
                }
                else {}
            }       
            lblPriceOrder.Text = num * double.Parse(Get_Price(txtIDOrder.Text)) + "";        
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
            frmHoaDon.Height = 300;
            frmHoaDon.lblNameCusBill.Text = txtNameCusOrder.Text;
            frmHoaDon.txtBill.Text = Show_Textbox() + "\r\n";
            frmHoaDon.lblTotalBill.Text = lblTotalOrder.Text + "";

            frmHoaDon.ShowDialog();

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
    }
}
