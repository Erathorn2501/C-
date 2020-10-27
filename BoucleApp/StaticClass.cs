using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoucleApp
{
    class StaticClass
    {
        public static int Addition(params int[] list)
        {
            int somme = 0;
            foreach(int val in list)
            {
                somme += val;
            }
            return somme;
        }

        public static int CalculSommeEntiers(int x, int y)
        {
            int somme = 0;
            for (int i = x; i < y + 1; i++)
            {
                somme += i;
            }
            return somme;
        }

        public static decimal CalculMoyenne(List<decimal> list)
        {
            decimal moyenne = 0;

            foreach(decimal num in list)
            {
                moyenne += num;
            }

            moyenne = moyenne / list.Count;

            return moyenne;
        }

        public static int LastMethode()
        {
            int somme = 0;

            List<int> multiples3 = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0) { multiples3.Add(i); }
            }

            List<int> multiples5 = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0) { multiples5.Add(i); }
            }

            foreach (int number3 in multiples3)
            {
                foreach (int number5 in multiples5)
                {
                    if (number3 == number5 )
                    {
                        Console.WriteLine($"liste 3 = {number3}, liste 5 = {number5}");
                        somme += number3 + number5;
                    }
                }
            }

            return somme;
        }
    }
}
