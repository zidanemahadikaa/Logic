using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day06
    {
        public void Menu()
        {
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    SinyalSos();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    BintangAdenia();
                    Program.Pause();
                    break;
                default:
                    break;
            }
        }
        static void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Sinyal SOS    ");
            Console.WriteLine("2. Bintang Adenia");
            Console.WriteLine("3. ..............");
            Console.WriteLine("4. ..............");
            Console.WriteLine("5. ..............");
            Console.WriteLine("Press any key to Main Menu");
        }
        private static void SinyalSos()
        {
            int range = 3;
            string input ;
            int sinyalBenar = 0, sinyalSalah = 0;

            Console.WriteLine("Masukkan kode SOS: ");
            input = Console.ReadLine().ToUpper();

            for(int i=0; i < input.Length; i += range)
            {
                if(input.Substring(i, range) == "SOS")
                {
                    sinyalBenar++;
                }
                else
                {
                    sinyalSalah++;
                }
            }
            Console.WriteLine(sinyalBenar);
            Console.WriteLine(sinyalSalah);

            
        }
        private static void BintangAdenia()
        {
            Console.Write("Masukkan nama: ");
            string input = Console.ReadLine().ToLower();
            
            //looping menampilkan per karakter dalam satu baris
            for (int i = 0; i < input.Length; i++)
            {
                // menambahkan bintang sebelum karakternya sebanyak setengah panjang karakter
                for (int j = 0; j < input.Length / 2; j++)
                {
                    Console.Write("*");
                }
                //menampilkan karakter yang diinput
                Console.Write(input[i]);
                // menambahkan bintang setelah karakternya sebanyak setengah panjang karakter
                for (int j = 0; j < input.Length / 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("=====================");
            foreach (char c in input)
            {
                int a = input.Length % 2;
                if(a == 0)
                {
                    Console.WriteLine(c.ToString().PadLeft(input.Length / 2 + 1, '*').PadRight(input.Length + 1, '*'));
                }
                else 
                Console.WriteLine(c.ToString().PadLeft(input.Length / 2 + 1, '*').PadRight(input.Length, '*'));
            }
        }
    }
}
