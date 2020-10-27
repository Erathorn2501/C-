using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Compte
    {
        int solde;
        int numeroDeCompte;
        static int nbreDeComptes;
        Client propriétaire;

        public Compte()
        {
            nbreDeComptes = ++nbreDeComptes;
            numeroDeCompte = nbreDeComptes;
        }

        public Compte(Client propriétaire)
        {
            this.propriétaire = propriétaire;
            this.solde = 0;
            nbreDeComptes = ++nbreDeComptes;
            numeroDeCompte = nbreDeComptes;
        }

        public Compte(int solde, Client propriétaire)
        {
            this.solde = solde;
            this.propriétaire = propriétaire;
            nbreDeComptes = ++nbreDeComptes;
            numeroDeCompte = nbreDeComptes;
        }

        public void Crediter(int somme)
        {
            this.solde = this.solde + somme;
            Console.WriteLine($"La somme de {somme} a bien été ajoutée.");
        }

        public void Crediter(int somme, Compte compte)
        {
            compte.solde = compte.solde - somme;
            this.solde = this.solde + somme;
            Console.WriteLine($"La somme de {somme} a bien été virée depuis le compte de {compte.propriétaire.Prenom} {compte.propriétaire.Nom}.");
        }

        public void Debiter(int somme)
        {
            this.solde = this.solde - somme;
            Console.WriteLine($"La somme de {somme} a bien été enlevée.");
        }

        public void Debiter(int somme, Compte compte)
        {
            compte.solde = compte.solde + somme;
            this.solde = this.solde - somme;
            Console.WriteLine($"La somme de {somme} a bien été virée vers le compte de {compte.propriétaire.Prenom} {compte.propriétaire.Nom}.");
        }

        public void ConsulterCompte()
        {
            propriétaire.Afficher();
            Console.WriteLine($"Son compte numéro : {this.numeroDeCompte} est à {this.solde}");
        }

        public static void ConsulterNombreComptes()
        {
            Console.WriteLine($"Le nombre de compte(s) est : {nbreDeComptes}.");
        }

        public int Solde
        {
            get { return solde; }
        }

        public int NumeroDeCompte
        {
            get { return numeroDeCompte; }
        }

        public string NomProprio
        {
            get { return propriétaire.Nom; }
            set { propriétaire.Nom = value; }
        }

        public string PrenomProprio
        {
            get { return propriétaire.Prenom; }
            set { propriétaire.Prenom = value; }
        }

        public string CinProprio
        {
            get { return propriétaire.CIN; }
            set { propriétaire.CIN = value; }
        }

        public string TelProprio
        {
            get { return propriétaire.Tel; }
            set { propriétaire.Tel = value; }
        }
    }
}
