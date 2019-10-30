using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan1
{
    public class HoaDon
    {
        private int idHD;
        private string customerName;
        private double total;
        private int count;

        public DoUong douong;

        public HoaDon()
        {
            Count = 0;
            douong = new DoUong();
        }
        public int IdHD {
            get { return idHD; }
            set { idHD = value; }
        }

        public string CustomerName {
            get { return CustomerName; }
            set { customerName = value; }
        }

        public double Total {
            get { return total; }
            set { total = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

    }
}
