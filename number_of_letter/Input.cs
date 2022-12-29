using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace number_of_letter
{
    internal class Input
    {
        internal int get(string s)
        {
            if (s != null)
            {
                int choice;
                int.TryParse(s, out choice);
                return choice;
            }
            return 0;
        }
    }
}
