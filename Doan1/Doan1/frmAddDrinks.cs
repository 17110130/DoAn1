using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan1
{
    public partial class frmAddDrinks : Form
    {
        public frmAddDrinks()
        {
            InitializeComponent();
        }

        //internal void Get_Data(LinkedListHD<DoUong> menu)
        //{
        //    this.menu = menu;
        //}

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();

            string content = "";
            content += validation.Check_Empty("ID", txtIDAdd);
            content += validation.Check_Empty("Name",txtNameAdd);
            content += validation.Check_Empty("Promotion", txtPromotionAdd);
            content += validation.Check_Empty("Price", txtPriceAdd);

            if ( content != "")
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LinkedListHD<DoUong>.Node NodeDoUong = Form2.menu.pHead;
                while(NodeDoUong != null )
                {
                    if ( NodeDoUong.data.ID.ToString() == txtIDAdd.Text )
                    {
                        MessageBox.Show("ID đã tồn tại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDAdd.Text = "";
                        return;
                    }
                    NodeDoUong = NodeDoUong.pNext;
                }
                DoUong douong = new DoUong();
                douong.ID = int.Parse(txtIDAdd.Text);
                douong.Name = txtNameAdd.Text;
                douong.Promotion = int.Parse(txtPromotionAdd.Text);
                douong.Price = double.Parse(txtPriceAdd.Text);

                Form2.menu.Add(douong);
                MessageBox.Show("Đồ uống đã được thêm vào menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtIDAdd.Text = "";
                txtNameAdd.Text = "";
                txtPromotionAdd.Text = "";
                txtPriceAdd.Text = "";
            }
        }
    }
}
