using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            
            const decimal pi = 3.14159M; 

            //Exo 1 :
            Console.WriteLine("Exo 1 :");
            Console.ReadLine();
            decimal i = 12 + 5 * 12.5M - 1253.68M;

            decimal moyenne = (1 + 5.5M + 9.9M + 2.8M + 9.6M) / 5;

            Console.WriteLine(i);
            Console.WriteLine(moyenne);
            Console.ReadLine();

            //Exo 2 :
            Console.WriteLine("Exo 2 :");
            Console.ReadLine();
            Console.WriteLine("Renseignez un nombre entier :");
            string tamp = Console.ReadLine();
            int n = Int32.Parse(tamp);
            Console.WriteLine($"Le périmètre du cercle est : {n * 2 * pi}");
            Console.WriteLine($"La surface du cercle est : {n * n * pi}");
            Console.ReadLine();

            //Exo 3 :
            Console.WriteLine("Exo 3 :");
            Console.ReadLine();
            string test = "zenat";
            char[] arr = test.ToCharArray(0, 5);

            for (int y = 0; y < arr.Length; y++) {
                Console.Write(arr[y]);
            }
            Console.ReadLine();

            ClasseTest newText = new ClasseTest(arr);
            newText.changeLetter();
            string chmouf = newText.ToString();
            Console.WriteLine(chmouf);
            Console.ReadLine();

            //Exo 4 :
            Console.WriteLine("Exo 4 :");
            Console.ReadLine();
            string text = System.IO.File.ReadAllText(@"C:\Users\33612\Desktop\test.txt");
            Console.WriteLine(text);
            Console.ReadLine();
            
            //Exo 5 :
            Console.WriteLine("Exo 5 :");
            Console.ReadLine();
            int[] ages = { 10, 15, 20, 25, 30, 35 };
            string[] prenom = { "Julien", "Michel", "Jannot", "Raoul", "Zack", "Bernard" };

            for(int z = 0; z < 6; z++)
            {
                Console.WriteLine($"Prénom : {prenom[z]}, âge : {ages[z]}");
            }
            Console.ReadLine();
            
            // Exo 6 :
            Console.WriteLine("Exo : 6");
            Console.ReadLine();

            var fruits = new List<string> { "Fraise", "Banane" };
            fruits.Add("Pastèque");
            fruits.Add("Framboise");
            fruits.Add("Cerise");
            fruits.Add("Raisin");
            fruits.Add("Poire");

            fruits.Remove("Banane");

            Console.Write("La liste des fruits est : ");
            foreach(var fruit in fruits)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
            
            //Exo 7 :
            Console.WriteLine("Exo 7 :");
            Console.ReadLine();

            Dictionary<string, int> dico = new Dictionary<string, int>();
           
            dico.Add("Julien Calvignac", 15);
            dico.Add("Jeanne Pernot", 20);
            dico.Add("Yvan Trieul", 25);
            dico.Add("Sébastien Boyer", 30);
            dico.Add("Célia Denarse", 35);
            dico.Add("Nathalie Moriset", 40);

            int value;
            if (dico.TryGetValue("Julien Calvignac", out value))
            {
                Console.WriteLine($"Nom : Julien Calvignac, âge : { dico["Julien Calvignac"]}");
            }
            if (dico.TryGetValue("Jeanne Pernot", out value))
            {
                Console.WriteLine($"Nom : Jeanne Pernot, âge : { dico["Jeanne Pernot"]}");
            }
            if (dico.TryGetValue("Yvan Trieul", out value))
            {
                Console.WriteLine($"Nom : Yvan Trieul, âge : { dico["Yvan Trieul"]}");
            }
            Console.WriteLine();
            Console.ReadLine();

            if (dico.TryGetValue("Yvan Trieul", out value))
            {
                dico.Remove("Yvan Trieul");
            }
            if (dico.TryGetValue("Célia Denarse", out value))
            {
                dico.Remove("Célia Denarse");
            }

            if (dico.TryGetValue("Yvan Trieul", out value))
            {
                Console.WriteLine($"Nom : Yvan Trieul, âge : { dico["Yvan Trieul"]}");
            }
            else
            {
                Console.WriteLine("Yvan a bien été supprimé");
            }

            Console.ReadLine();

            var list = new List<string>(dico.Keys);

            foreach (string nom in list)
            {
                string tampPrenom = "";
                foreach(char c in nom)
                {
                    if(c==' ') 
                    {
                        break;
                    }
                    else
                    {
                        tampPrenom += c;
                    }
                }
                int age = dico[nom];
                Console.WriteLine($"Prénom : {tampPrenom}, age : {age}");
            }
            Console.ReadLine();
            
            //Exo 8 :
            Console.WriteLine("Exo : 8");
            Console.ReadLine();

            CompteBancaire.nbreDeComptes = 0;

            CompteBancaire jack = new CompteBancaire("Jack Olson", 1500, "euros");
            jack.Decrire();
            Console.WriteLine($"Ajouter une somme (tapez 0 si pas d'ajout) :");
            jack.Crediter(int.Parse(Console.ReadLine()));
            jack.Decrire();
            CompteBancaire.ConsulterNbreDeComptes(); 
            Console.WriteLine($"Enlever une somme (tapez 0 si pas d'ajout) :");
            jack.Debiter(int.Parse(Console.ReadLine()));
            jack.Decrire();
            CompteBancaire.ConsulterNbreDeComptes();

            Console.ReadLine();
            
            //Exo 9 :
            Console.WriteLine("Exo : 9 ( test de la classe Compte)");
            Console.ReadLine();

            Client client1 = new Client("001", "Sparrow", "Jack");
            Compte compte1 = new Compte(50, client1);

            Client client2 = new Client("024", "Swan", "Elizabeth");
            Compte compte2 = new Compte(5000, client2);

            Client client3 = new Client("071", "Sébastien", "Patrice");
            Compte compte3 = new Compte(2500, client2);

            Compte.ConsulterNombreComptes();
            Console.ReadLine();
            Console.WriteLine("Tapez 1 pour consulter le compte de Jack");
            Console.WriteLine("Tapez 2 pour consulter le compte de Elizabeth");
            Console.WriteLine("Tapez 3 pour consulter le compte de Patrice");
            int choix1 = int.Parse(Console.ReadLine());

            switch (choix1)
            {
                case 1:
                    compte1.ConsulterCompte();
                    break;
                case 2:
                    compte2.ConsulterCompte();
                    break;
                case 3:
                    compte3.ConsulterCompte();
                    break;
            }

            Console.WriteLine("Créditer quel compte (1, 2, 3) ?");
            int choix2 = int.Parse(Console.ReadLine());

            Console.WriteLine("De combien ?");
            int montant1 = int.Parse(Console.ReadLine());

            switch (choix2)
            {
                case 1:
                    compte1.Crediter(montant1);
                    break;
                case 2:
                    compte2.Crediter(montant1);
                    break;
                case 3:
                    compte3.Crediter(montant1);
                    break;
            }

            Console.WriteLine("Déditer quel compte (1, 2, 3) ?");
            int choix3 = int.Parse(Console.ReadLine());

            Console.WriteLine("De combien ?");
            int montant2 = int.Parse(Console.ReadLine());

            switch (choix3)
            {
                case 1:
                    compte1.Debiter(montant2);
                    break;
                case 2:
                    compte2.Debiter(montant2);
                    break;
                case 3:
                    compte3.Debiter(montant2);
                    break;
            }

            compte1.ConsulterCompte();
            compte2.ConsulterCompte();
            compte3.ConsulterCompte();

            Console.ReadLine();
            
            //Exo 10 :
            Console.WriteLine("Exo : 9");
            Console.ReadLine();

            Article article1 = new Article();
            Article article2 = new Article("Jouet", "Beyblade");
            Article articleTamp = new Article("Console", "Wii", 200, 22);
            Article article3 = new Article(articleTamp);
            Article article4 = new Article("Ordinateur", "Acer 802 pro", 1200, 15);

            article1.AfficherArticle();
            article2.AfficherArticle();
            article3.AfficherArticle();
            article4.AfficherArticle();

            Console.WriteLine($"Le prix TTC de l'article 1 est : {article1.CalculerPrixTTC()}");
            Console.WriteLine($"Le prix TTC de l'article 2 est : {article2.CalculerPrixTTC()}");
            Console.WriteLine($"Le prix TTC de l'article 3 est : {article3.CalculerPrixTTC()}");
            Console.WriteLine($"Le prix TTC de l'article 4 est : {article4.CalculerPrixTTC()}");

            Console.ReadLine();

        }
    }
}
