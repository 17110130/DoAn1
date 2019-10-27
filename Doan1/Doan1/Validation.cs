using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Doan1
{
    public class Validation
    {
        public string Check_Empty ( string name, TextBox txt)
        {
            if (txt.Text == "")
                return "Mời nhập " + name + " !\n";
            return "";
        }      
    }
}
