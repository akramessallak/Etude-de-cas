using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal abstract class reponse
    {
        private int note;
        private string type;
        private string Reponse;

        public reponse(int note,string type, string Reponse)
        {
            this.note = note;
            this.type = type;
            this.Reponse = Reponse;
        }
        public int getnote()
        {
            return this.note;
        }
        public void setnote(int note)
        {
            this.note = note;
        }
        public string gettype()
        {
            return this.type;
        }
        public void settype(string type)
        {
            this.type = type;
        }
        public string getReponse()
        {
            return this.Reponse;
        }
        public void setReponse(string Reponse)
        {
            this.Reponse = Reponse;
        }
    }
}
