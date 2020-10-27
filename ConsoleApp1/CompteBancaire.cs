using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompteBancaire
    {
        private string titulaire;
        private int solde;
        private string devise;
        static public int nbreDeComptes;

        public string Titulaire
        {
            get { return titulaire; }
        }
        public int Solde
        {
            get { return solde; }
        }
        public string Devise
        {
            get { return devise; }
        }

        public CompteBancaire(string titulaire, int solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
            nbreDeComptes = ++nbreDeComptes;
        }

        public void Crediter(int somme)
        {
            this.solde += somme;
            Console.WriteLine($"La somme de {somme} {this.devise} a été ajoutée.");
        }

        public void Debiter(int somme)
        {
            this.solde -= somme;
            Console.WriteLine($"La somme de {somme} {this.devise} a été enlevée.");
        }

        public void Decrire()
        {
            Console.WriteLine($"Le titulaire du compte est : {this.titulaire}, il possède : {this.solde} {this.devise}");
        }

        public static void ConsulterNbreDeComptes()
        {
            Console.WriteLine($"Le nombre de compte(s) est : {nbreDeComptes}");
        }
    }
}
