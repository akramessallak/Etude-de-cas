using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class Examen
    {
        private int time;
        private int dateouvert;
        private int datereferme;

        public Examen(int time, int dateouvert, int datereferme)
        {
            this.time = time;
            this.dateouvert = dateouvert;
            this.datereferme = datereferme;
        }


        public void settime(int time)
        {
            this.time = time;
        }
        public void setdateouvert(int dateouvert)
        {
            this.dateouvert = dateouvert;
        }
        public void setdatereferme(int datereferme)
        {
            this.datereferme = datereferme;
        }
        public int gettime()
        {
            return this.time;
        }
        public int getdateouvert()
        {
            return this.dateouvert;
        }
        public int getdatereferme()
        {
            return this.datereferme;
        }
    }
}
