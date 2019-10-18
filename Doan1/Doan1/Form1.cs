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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin")
            {
                if(textBox2.Text=="admin")
                {
                    MessageBox.Show("login success");
                    Form a = new Form2();
                    this.Hide();
                    a.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("password!!!");
                }
            }
            else
            {
                MessageBox.Show("username!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
