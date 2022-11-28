using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class questionouverte : question

    {
        private ReponseOuverte reponse;
        public questionouverte(string enonce, int note, string type) : base(enonce, note, type)
        {
            
        }
    }
}
