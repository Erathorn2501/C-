using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        string cin;
        string nom;
        string prenom;
        string tel;

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Client(string cin, string nom, string prenom, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public void Afficher()
        {
            if (this.tel != "" && this.tel != null)
            {
                Console.WriteLine($"Le client se nomme {this.prenom} {this.nom}, il porte le numéro : {this.cin}, " +
                    $"et son numéro de téléphone est le : {this.tel}");
            }
            else
            {
                Console.WriteLine($"Le client se nomme {this.prenom} {this.nom}, il porte le numéro : {this.cin}, " +
                    $"et il n'a pas de numéro de téléphonne d'enregistré.");
            }
        }

        public string CIN
        {
            get { return cin; }
            set { cin = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { cin = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { cin = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { cin = value; }
        }
    }
}
