using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day07
    {
        public void Menu()
        {
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D2:
                    JudiOnlen();
                    Program.Pause();
                    break;
                case ConsoleKey.D4:
                    KuePukis();
                    Program.Pause();
                    break;
                case ConsoleKey.D5:
                    Matriks();
                    Program.Pause();
                    break;
                default:
                    break;
            }
        }
        static void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. ..........");
            Console.WriteLine("2. Judi Onlen");
            Console.WriteLine("3. ..........");
            Console.WriteLine("4. Kue Pukis ");
            Console.WriteLine("5. Matriks   ");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void JudiOnlen()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 9);
            int point, taruhan;
            string tebakan;
            char again;
            bool kembali = true;

            Console.Write("Point: ");
            point = int.Parse(Console.ReadLine());

            while (kembali)
            {
                Console.Write("Taruhan: ");
                taruhan = int.Parse(Console.ReadLine());

                Console.Write("Tebakan U/D: ");
                tebakan = Console.ReadLine().ToUpper();

                if (random > 5 && tebakan == "U")
                {
                    Console.WriteLine("Kamu Menang");
                    point += taruhan;
                }
                else if (random < 5 && tebakan == "D")
                {
                    Console.WriteLine("Kamu Menang");
                    point += taruhan;
                }
                else if ((random == 5 && tebakan == "U") || (random == 5 && tebakan == "D")) 
                {
                    Console.WriteLine("Seri");
                }
                else
                {
                    Console.WriteLine("Kamu kalah");
                    point -= taruhan;
                }
                Console.WriteLine($"Random yang keluar : {random}");
                Console.WriteLine();
                Console.WriteLine($"Poin kamu sekarang: {point}");

                Console.WriteLine("Main Lagi y/n: ");
                again = char.Parse(Console.ReadLine());

                if (again != 'y')
                {
                    kembali = false;
                    Console.WriteLine("Permainan berakhir");
                }
                Console.WriteLine($"Poin kamu sekarang: {point}");
            }
        }
        public void KuePukis ()
        {
            int pukis = 15;
            int terigu = 115;
            int gula = 190;
            int susu = 100;

            Console.Write("Masukkan jumlah Pukis: ");
            double nPukis = double.Parse(Console.ReadLine());

            double nTerigu = ((double)terigu / (double)pukis) * nPukis;
            double nGula = ((double)gula / (double)pukis) * nPukis;
            double nSusu = ((double)susu / (double)pukis) * nPukis;

            Console.WriteLine($"Yang anda butuhkan sebanyak: ");
            Console.WriteLine($"Terigu: {nTerigu}");
            Console.WriteLine($"Gula: {nGula}");
            Console.WriteLine($"Susu: {nSusu}");
        }
        private static void Matriks()
        {
            
            int n = 0;

            Console.Write("Masukkan nilai n = ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int a = 2;
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(a+" ");
                    }
                    else if (i == n)
                    {
                        Console.Write(a+" ");
                   
                    }
                    else if (i == j)
                    {
                        Console.Write(a);

                    }
                    else Console.Write("  ");
                    a += 2;
                    //Console.Write(a*j);
                }
                Console.WriteLine();
            }


        }
    }
}
