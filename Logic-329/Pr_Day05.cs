using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day05
    {
        public void Menu()
        {
            Console.Clear();
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    BubbleSorting();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    BilanganPrima();
                    Program.Pause();
                    break;
                default:
                    break;
            }
        }
        static void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("=====================");
            Console.WriteLine("1. Bubble Sorting    ");
            Console.WriteLine("2. Bilangan Prima    ");
            Console.WriteLine("3. ..................");
            Console.WriteLine("4. ..................");
            Console.WriteLine("5. ..................");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void BubbleSorting()
        {
            //int n = 0;
            //int[] angka = { 2, 5, 4, 1, 3 };
            //for (int i = 0; i < angka.Length; i++)
            //{
            //    Console.Write("{0}, ", angka[i]);
            //}
            //Console.WriteLine();
            //for(int j = 0; j <= angka.Length - 2; j++)
            //{
            //    for (int i = 0; i <= angka.Length - 2; i++)
            //    {
            //        n = n + 1;
            //        if(angka[i] > angka[i +1 ])
            //        {
            //            int temp = angka[i + 1];
            //            angka[i + 1] = angka[i];
            //            angka[i] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("After Sorting Array :");
            //foreach (int item in angka)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            List<int> angka = new List<int>() { 2, 5, 4, 1, 3 };
            Console.WriteLine("Angka Awal: " + String.Join(", ", angka));

        }
        public void BilanganPrima()
        {
            int angka1 = 1;
            int angka2 = 20;
            //Console.Write("Enter The Start Number: ");
            //int startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the End Number : ");
            //int endNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
            for (int i = angka1; i <= angka2; i++)
            {
                int c = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                        break;
                    }
                }

                if (c == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
