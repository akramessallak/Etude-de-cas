using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class reponse
    {
        private int degrecertitude;
        private int duree;

        public reponse() { }
        public int getdegrecertitude()
        {
            return degrecertitude;
        }
        public void setduree(int dure)
        {
            duree = dure;
        }
    }
}
