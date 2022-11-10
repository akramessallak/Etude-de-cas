using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class questionachoix : question
    {
        string proposition;

        public questionachoix(string enonce, int note, string type, string proposition) : base(enonce, note,type)
        {
            this.proposition = proposition;
        }
        public string getproposition()
        {
            return proposition;
        }
        public void setproposition(string proposition)
        {
            this.proposition = proposition;
        }
    }
}
