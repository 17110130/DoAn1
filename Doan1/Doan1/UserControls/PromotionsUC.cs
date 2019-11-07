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
    public partial class PromotionsUC : UserControl
    {
        public PromotionsUC()
        {
            InitializeComponent();
        }

        private void PromotionsUC_Load(object sender, EventArgs e)
        {
            LinkedListHD<DoUong>.Node NodeMenu = Form2.menu.pHead;
            while (NodeMenu != null)
            {
                if (NodeMenu.data.ID.ToString().Length < 2)
                {
                    txbPromotions.Text += NodeMenu.data.ID + "                   " + NodeMenu.data.Price + "\r\n";
                }
                else
                {
                    txbPromotions.Text += NodeMenu.data.ID + "                 " + NodeMenu.data.Price + "\r\n";
                }
                NodeMenu = NodeMenu.pNext;
            }
        }

        private void btnExportPromotion_Click(object sender, EventArgs e)
        {
            FileStream fw = null;
            string msg = "";
            byte[] msgByte = null;

            fw = new FileStream("Promotion.txt", FileMode.Create);

            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);
            msg = "";

            msg += txbPromotions.Text + "\r\n";

            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);

            if (fw != null) fw.Close();

            MessageBox.Show("The file Promotion.txt have created!");
        }
    }
}
