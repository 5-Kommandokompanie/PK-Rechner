using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Rechner_WPF
{
    public class KWEA
    {
        public int Nummer { get; set; }
        public string Name { get; set; }

        public KWEA(int _nummer, string _name)
        {
            Nummer = _nummer;
            Name = _name;
        }
    }
}
