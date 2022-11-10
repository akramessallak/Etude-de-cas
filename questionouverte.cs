using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class questionouverte : question

    {
        private byte maxchar;
        public questionouverte(string enonce, int note, string type, byte maxchar) : base(enonce, note, type)
        {
            this.maxchar = maxchar;
        }
        public byte getmaxchar()
        {
            return maxchar;
        }
        public void setmaxchar(byte maxchar)
        {
            this.maxchar = maxchar;
        }
    }
}
