using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal abstract class question
    {
        private string enonce;
        private int note;
        private string type;

        public question(string enonce, int note, string type)
        {
            this.enonce = enonce;
            this.note = note;
            this.type = type;
        }

        public string getenonce()
        {
            return this.enonce;
        }
        public void setenonce(string enonce)
        {
            this.enonce = enonce;
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


    }
}
