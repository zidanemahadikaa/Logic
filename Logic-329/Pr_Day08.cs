using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day08
    {
        public void Menu()
        {
            Console.Clear();
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    BeautifulDay();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    LoliGratis();
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
            Console.WriteLine("1. Beautiful Day     ");
            Console.WriteLine("2. Es Loli gratis    ");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void BeautifulDay()
        {
            
            int i, j, k;
            
            List<int> hari = new List<int>();
            try
            {
                Console.Write("Masukkan tanggal pertama: ");
                i = int.Parse(Console.ReadLine());
                Console.Write("Masukkan tanggal terakhir: ");
                j = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka pembagi: ");
                k = int.Parse(Console.ReadLine());

                for (i = i; i <= j; i++)
                {
                    string strI = i.ToString();
                    int iReverse = (strI.Length > 1) ? int.Parse(strI[1].ToString() + strI[0].ToString()) : i;

                    Console.WriteLine($"{i} - {iReverse} / {k} = " + (double)(Math.Abs(i - iReverse)) / k);

                    if ((i - iReverse) % k == 0)
                    {
                        hari.Add(i);
                    }
                }
                Console.WriteLine($"Hari indah {string.Join(", ", hari)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan , {0}", ex.Message);
                Console.ReadLine();
                Console.Clear();
                BeautifulDay();
            }
        }
        public void LoliGratis()
        {
            int loli = 1000;
            int uang = 0;
            int beliLoli = uang / loli;
            int bonus = beliLoli / 5;
            try
            {
                Console.Write("Masukkan jumlah uang: ");
                uang = int.Parse(Console.ReadLine());

                Console.WriteLine($"uang {uang} bambang dapat loli sebanyak {beliLoli} dan mendapat bonus {bonus}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan , {0}", ex.Message);
                Console.ReadLine();
                Console.Clear();
                LoliGratis();
            }
        }
    }
}
