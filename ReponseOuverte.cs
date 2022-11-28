using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class ReponseOuverte : reponse
    {
        public questionouverte question;
        public ReponseOuverte(int note, string type, string Reponse) : base(note, type, Reponse)
        {

        }
    }
}
