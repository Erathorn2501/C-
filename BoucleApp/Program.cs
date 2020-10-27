using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exo 1 :
            Console.WriteLine("Exo 1 :");
            Console.ReadLine();

            Console.WriteLine("Boucle for :");

            int i = 0;
            for (i = 0; i < 21; i++)
            {
                if(i%2 == 0) { Console.WriteLine($"{i}"); };

            }

            Console.ReadLine();

            Console.WriteLine("Boucle while :");

            i = 0;

            while (i < 21)
            {
                if (i % 2 == 0) { Console.WriteLine($"{i}"); };
                i++;
            }

            Console.ReadLine();
            
            //Exo 2 :
            Console.WriteLine("Exo 2 :");
            Console.ReadLine();

            Console.WriteLine("Ecrivez un nombre :");
            int k = int.Parse(Console.ReadLine());

            int compte = 0;

            for(int j = 1; j < k + 1; j++)
            {
                compte += j;
            }

            Console.WriteLine($"Compte = {compte}");
            Console.ReadLine();
            
            //Exo 3 :
            Console.WriteLine("Exo 3 :");
            Console.ReadLine();

            Console.WriteLine("Veuillez entrer un premier nombre :");
            int nombre1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un deuxième nombre :");
            int nombre2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un troisième nombre :");
            int nombre3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un quatrième nombre :");
            int nombre4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un cinquième nombre :");
            int nombre5 = int.Parse(Console.ReadLine());

            Console.WriteLine($"La somme des nombres est {nombre1 + nombre2 + nombre3 + nombre4 + nombre5}");
            Console.WriteLine($"La moyenne des nombres est {(nombre1 + nombre2 + nombre3 + nombre4 + nombre5)/5}");

            Console.ReadLine();
            
            //Exo 4 :
            Console.WriteLine("Exo 4 :");
            Console.ReadLine();

            Console.WriteLine("Veuillez entrer un premier nombre :");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un deuxième nombre :");
            int val2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"La somme des nombres est : {StaticClass.CalculSommeEntiers(val1, val2)}");

            Console.ReadLine();
            
            //Exo 5 :
            Console.WriteLine("Exo 5 :");
            Console.ReadLine();

            List<decimal> listeNum = new List<decimal>();

            Console.WriteLine("Veuillez entrer un premier nombre :");
            listeNum.Add(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer un deuxième nombre :");
            listeNum.Add(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer un troisième nombre :");
            listeNum.Add(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer un quatrième nombre :");
            listeNum.Add(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Veuillez entrer un cinquième nombre :");
            listeNum.Add(decimal.Parse(Console.ReadLine()));

            Console.WriteLine($"La moyenne des nombres est : {StaticClass.CalculMoyenne(listeNum)}");

            Console.ReadLine();
            */
            //Exo 6 :
            Console.WriteLine("Exo 6 :");
            Console.ReadLine();

            Console.WriteLine($"La somme des nombres de la liste commune est : {StaticClass.LastMethode()}");
            Console.ReadLine();
        }
    }
}
