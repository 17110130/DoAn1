using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doan1
{
    public class Menu
    {
        private LinkedList<DoUong> dsnuoc;

        public Menu()
        {
            this.dsnuoc = new LinkedList<DoUong>();
        }

        internal LinkedList<DoUong> DsNuoc { get; set; }
    }
}
