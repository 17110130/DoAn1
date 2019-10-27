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
        public Form2()
        {
            InitializeComponent();
            gioiThieuUC1.BringToFront();
            createDatabase();
            pnOrder.Hide();
            
        }
        LinkedList<DoUong> menu = new LinkedList<DoUong>();
        double Total = 0;

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
                   
            Total += double.Parse(lblPriceOrder.Text);
            lblTotalOrder.Text = Total + "";
        }

        private void txtIDOrder_TextChanged(object sender, EventArgs e)
        {
            txtAmountOrder.Text = "1";

            lblPriceOrder.Text = Get_Price(txtIDOrder.Text);
        }

        public string Get_Price(string id)
        {
            LinkedList<DoUong>.Node NodeDoUong = menu.pHead;
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
           Update_Price(txtIDOrder.Text, txtAmountOrder.Text, lblPriceOrder);
        }
        public void Update_Price(string id,string amount,Label lbl)
        {
            lbl.Text = int.Parse(amount) * int.Parse(Get_Price(id)) + "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
