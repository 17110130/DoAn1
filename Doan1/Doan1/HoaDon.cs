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
        private int count;
        private double total;

        private LinkedListHD<DoUong> dsHoaDon;

        public int IdHD { get; set; }

        public string CustomerName { get; set; }

        public int Count { get; set; }

        public double Total { get; set; }

        internal LinkedListHD<DoUong> DsHoaDon { get; set; }

    }
}
