using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPuissance4
{
    public class Joueur
    {
        //attributs
        private string _name;
        private string _jetons; //jetons X ou O

        //get-set
        public string Name { get => _name; set => _name = value; }
        public string Jetons { get => _jetons; set => _jetons = value; }

        //constructeur(s)
        public Joueur(string name, string jetons)
        {
            _name = name;
            _jetons = jetons; 
        }

        //méthodes

    }
}
