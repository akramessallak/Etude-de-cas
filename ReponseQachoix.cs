using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class ReponseQachoix : reponse
    {
        private int degrecertitude;


        public ReponseQachoix(int note, string type, string Reponse,int degrecertitude) : base(note, type, Reponse)
        {   
            this.degrecertitude = degrecertitude;

        }
        public int getdegrecertitude()
        {
            return this.degrecertitude;
        }
        public void setdegrecertitude(int degrecertitude)
        {
            this.degrecertitude = degrecertitude;
        }

    }
}
