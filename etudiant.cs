using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etude_de_cas
{
    internal class etudiant
    {
        private string nom;
        private string prenom;
        private int id;

        public etudiant(string nom, string prenom,int id)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
        }
        public string getnom()
        {
            return this.nom;
        }
        public void setnom(string nom)
        {
            this.nom = nom;
        }
        public string getprenom()
        {
            return this.prenom;
        }
        public void settype(string prenom)
        {
            this.prenom = prenom;
        }
        public int getid()
        {
            return this.id;
        }
        public void setid(int id)
        {
            this.id = id;
        }
    }
}
