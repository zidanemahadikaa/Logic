using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day01
    {
        public string IndeksNilai(int nilai)
        {
            if (nilai >= 80 && nilai <= 100) return "A";
            else if (nilai >= 60 && nilai < 80) return "B";
            else if (nilai < 60) return "C";
            else return "Undefined";
        }
        public void GanjilGenap()
        {
            Console.Write("Masukkan angka: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.Write($"angka {angka} adalah genap");
            }
            else if (angka % 2 != 0)
            {
                Console.Write($"angka {angka} adalah ganjil");
            }
            else
            {
                Console.WriteLine("Tidak terdefinisi");
            }
        }
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Masukkan Nilai: ");
                    string input = IndeksNilai(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Indeks hasil: " + (input));
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    GanjilGenap();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    Program.MenuPr();
                    Program.Pause();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        private void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Indeks Nilai");
            Console.WriteLine("2. Ganjil Genap");
            Console.WriteLine("0. Kembali");

        }
    }
}
