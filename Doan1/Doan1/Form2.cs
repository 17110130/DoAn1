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
            menuUC1.BringToFront();
            
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
