using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Article
    {
        string reference;
        string designation;
        int prixHT;
        static int tauxTVA = 20;

        public Article()
        {
            this.reference = "Non référencé";
            this.designation = "Sans Désignation";
            this.prixHT = 0;
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = 0;
        }

        public Article(Article article)
        {
            this.reference = article.reference;
            this.designation = article.designation;
            this.prixHT = article.prixHT;
        }

        public Article(string reference, string designation, int prixHT, int tauxTVA)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = prixHT;
        }

        public int CalculerPrixTTC()
        {
            int prixTTC = prixHT + (prixHT * tauxTVA / 100);
            return prixTTC;
        }

        public void AfficherArticle()
        {
            Console.WriteLine($"Cet article désigné : {this.designation}, référencé : {this.reference}, vaut {prixHT} HT avec un taux TVA de : {tauxTVA}.");
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public int PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }

        public int TauxTVA
        {
            get { return tauxTVA; }
            set { tauxTVA = value; }
        }
    }
}
