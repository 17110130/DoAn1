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
    public partial class frmRemoveDrink : Form
    {
        public frmRemoveDrink()
        {
            InitializeComponent();
        }

        private void btnRemoveDrink_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();

            string content = "";
            content += validation.Check_Empty("ID", txtIDRemove);

            if (content != "")
            {
                MessageBox.Show(content, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LinkedListHD<DoUong>.Node NodeDoUong = Form2.menu.pHead;
                while (NodeDoUong != null)
                {
                    if ( NodeDoUong.data.ID.ToString() == txtIDRemove.Text )
                    {                      
                        Form2.menu.Remove(NodeDoUong);
                        MessageBox.Show("Đồ uống đã được xóa khỏi menu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtIDRemove.Text = "";
                        return;
                    }
                    NodeDoUong = NodeDoUong.pNext;
                }
                MessageBox.Show("Đồ uống không có trong menu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDRemove.Text = "";
                
            }
        }
    }
}
