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
    public partial class MoneyUC : UserControl
    {
        public MoneyUC()
        {
            InitializeComponent();
        }

        private void MoneyUC_Load(object sender, EventArgs e)
        {
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    txbMoney.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Price + "\r\n";
                }
                else
                {
                    txbMoney.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Price + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
        }
    }
}
