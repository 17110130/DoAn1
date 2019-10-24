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
            taoDuLieu();
            
        }
        LinkedList<DoUong> CSDL_DoUong = new LinkedList<DoUong>();
       
        public void taoDuLieu()
        {          
            string dsnuoc = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\dsnuoc.txt";
            string giatien = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\gia.txt";
            string khuyenmai = @"C:\Users\Admin\Desktop\New folder\DoAn1\Doan1\Doan1\bin\Debug\dskhuyenmai.txt";

            string[] arrnuoc;
            string[] arrgia;
            string[] arrkhuyenmai;

            if (System.IO.File.Exists(dsnuoc))
            {
                string n1, n2, t1, t2, k1, k2;
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

                    t1 = x.Substring(0, 3).Trim();
                    t2 = x.Substring(3).Trim();

                    k2 = k.Substring(3).Trim();

                    douong.ID = int.Parse(n1);
                    douong.Name = n2;
                    douong.Promotion = int.Parse(k2);
                    douong.Price = double.Parse(t2);

                    CSDL_DoUong.Add(douong);
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
    }
}
