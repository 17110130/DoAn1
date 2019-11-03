using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Doan1
{
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();          
        }

        private void MenuUC_Load(object sender, EventArgs e)
        {
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    txbMenu.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Name + "\r\n";
                }
                else
                {
                    txbMenu.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Name + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
        }
    }
}
