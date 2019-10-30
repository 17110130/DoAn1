using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan1
{
    public class DoUong
    {
        private int id;
        private string name;
        private int promotion;
        private double price;


        public int ID {
            get { return id; }
            set { id = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Promotion {
            get { return promotion; }
            set { promotion = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
