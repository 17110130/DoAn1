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

        //public double Price_Min(LinkedListHD<DoUong> D)
        //{
        //    LinkedListHD<DoUong>.Node Node = D.pHead;
        //    double min = Node.data.Price;
        //    while (Node != null)
        //    {
        //        if (Node.data.Price < min)
        //        {
        //            min = Node.data.Price;
        //        }
        //        Node = Node.pNext;
        //    }
        //    return min;
        //}

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            LinkedListHD<DoUong> increase = new LinkedListHD<DoUong>();


            double temp = 0;

            while (increase.count != Form2.menu.count)
            {
                double min = 10000000000;
                LinkedListHD<DoUong>.Node NodeDoUong = Form2.menu.pHead;

                while (NodeDoUong != null)
                {
                    if (NodeDoUong.data.Price <= min && NodeDoUong.data.Price > temp)
                    {
                        min = NodeDoUong.data.Price;
                    }
                    NodeDoUong = NodeDoUong.pNext;
                }

                LinkedListHD<DoUong>.Node Node = Form2.menu.pHead;

                while (Node != null)
                {
                    if (Node.data.Price == min)
                    {
                        DoUong douong = Node.data;
                        increase.Add(douong);
                    }
                    Node = Node.pNext;
                }
                temp = min;
            }


                txbMoney.Text = "";
                LinkedListHD<DoUong>.Node PrintNode = increase.pHead;
                while (PrintNode != null)
                {
                    if (PrintNode.data.ID.ToString().Length < 2)
                    {
                        txbMoney.Text += PrintNode.data.ID + "                   " + PrintNode.data.Price + "\r\n";
                    }
                    else
                    {
                        txbMoney.Text += PrintNode.data.ID + "                 " + PrintNode.data.Price + "\r\n";

                    }
                    PrintNode = PrintNode.pNext;
                }   
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
          txbMoney.Text = "";
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

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            // Tạo LinkedList increase
            LinkedListHD<DoUong> increase = new LinkedListHD<DoUong>();

            double temp = 0;

            while (increase.count != Form2.menu.count)
            {
                double min = 10000000000;
                LinkedListHD<DoUong>.Node NodeDoUong = Form2.menu.pHead;

                while (NodeDoUong != null)
                {
                    if (NodeDoUong.data.Price <= min && NodeDoUong.data.Price > temp)
                    {
                        min = NodeDoUong.data.Price;
                    }
                    NodeDoUong = NodeDoUong.pNext;
                }

                LinkedListHD<DoUong>.Node Node = Form2.menu.pHead;

                while (Node != null)
                {
                    if (Node.data.Price == min)
                    {
                        DoUong douong = Node.data;
                        increase.Add(douong);
                    }
                    Node = Node.pNext;
                }
                temp = min;
            }
            // Đảo ngược LinkedList increase
            LinkedListHD<DoUong> decrease = new LinkedListHD<DoUong>();
            LinkedListHD<DoUong>.Node Nodedu = increase.pHead;

            while (Nodedu != null)
            {
                DoUong du = Nodedu.data;
                decrease.AddFirst(du);
                Nodedu = Nodedu.pNext;
            }

            LinkedListHD<DoUong>.Node PrintNode = decrease.pHead;
            txbMoney.Text = "";
            while (PrintNode != null)
            {
                if (PrintNode.data.ID.ToString().Length < 2)
                {
                    txbMoney.Text += PrintNode.data.ID + "                   " + PrintNode.data.Price + "\r\n";
                }
                else
                {
                    txbMoney.Text += PrintNode.data.ID + "                 " + PrintNode.data.Price + "\r\n";
                }
                PrintNode = PrintNode.pNext;
            }                
        }
    }
}
