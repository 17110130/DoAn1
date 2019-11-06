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
    public partial class frmAddBefore : Form
    {
        public frmAddBefore()
        {
            InitializeComponent();
        }

        private void btnAddBefore_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();

            string content = "";
            content += validation.Check_Empty("ID", txtIDAdd);
            content += validation.Check_Empty("Name", txtNameAdd);
            content += validation.Check_Empty("Promotion", txtPromotionAdd);
            content += validation.Check_Empty("Price", txtPriceAdd);
            content += validation.Check_Empty("Before ID", txtIDBefore);
            if (content != "")
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LinkedListHD<DoUong>.Node NodeDoUong = Form2.menu.pHead;
                while (NodeDoUong != null)
                {
                    if (NodeDoUong.data.ID.ToString() == txtIDAdd.Text)
                    {
                        MessageBox.Show("ID đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                LinkedListHD<DoUong>.Node pSearch = Form2.menu.pHead;
                LinkedListHD<DoUong>.Node pPre = null;
                if ( pSearch.data.ID == int.Parse(txtIDBefore.Text) )
                {
                    Form2.menu.AddFirst(douong);
                    MessageBox.Show("Đồ uống đã được thêm vào menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtIDAdd.Text = "";
                    txtNameAdd.Text = "";
                    txtPromotionAdd.Text = "";
                    txtPriceAdd.Text = "";
                    txtIDBefore.Text = "";
                    return;
                }              
                while( pSearch != null )
                {                   
                    if ( pSearch.data.ID == int.Parse(txtIDBefore.Text) )
                    {
                        Form2.menu.AddAfter(douong, pPre);
                        MessageBox.Show("Đồ uống đã được thêm vào menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtIDAdd.Text = "";
                        txtNameAdd.Text = "";
                        txtPromotionAdd.Text = "";
                        txtPriceAdd.Text = "";
                        txtIDBefore.Text = "";
                        return;
                    }
                    pPre = pSearch;
                    pSearch = pSearch.pNext;
                }

                MessageBox.Show("Không tìm thấy Before ID. Đồ uống được thêm vào cuối menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2.menu.Add(douong);
            }
        }
    }
}
