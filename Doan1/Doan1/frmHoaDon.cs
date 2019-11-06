using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan1
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            FileStream fw = null;
            string msg = "";
            byte[] msgByte = null;

            fw = new FileStream("Bill.txt", FileMode.Create);

            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);
            msg = "";

            msg += lblNameCusBill.Text + "\r\n" + txtBill.Text + "\r\n" + lblTotalBill.Text + "\r\n";

            msgByte = Encoding.Default.GetBytes(msg);
            fw.Write(msgByte, 0, msgByte.Length);

            if (fw != null) fw.Close();

            MessageBox.Show("The file Bill.txt have created!");
        }
    }
}
