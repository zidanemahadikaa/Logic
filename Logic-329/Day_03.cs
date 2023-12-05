using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_03
    {
        private void PerulanganWhile()
        {
            bool ulangi = true;
            int nilai = 1;
            while (ulangi)
            {
                Console.WriteLine($"Proses ke {nilai}");
                nilai++;

                Console.WriteLine("ulangi proses ? (y/n)");
                ulangi = Console.ReadLine()=="y";
            }
        }
        private void PerulanganDoWhile()
        {
            bool ulangi = true;
            int nilai = 1;

            do
            {
                Console.WriteLine($"Nilai = {nilai++}");

                Console.WriteLine("Ulangi proses (y/n)");
                //ulangi = (Console.ReadLine()=="y");
            }
            while (Console.ReadLine() == "y");
        }
        private void PerulanganFor()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write((i % 2 != 0) ? i + "\n" : "");
            }
        }
        private void BreakContinue()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write((i % 2 != 0) ? i + "\n" : "");
                if (i == 50) continue;
                Console.WriteLine(i);
                if (i >= 60) break;
            }
        }
        private void PerulanganBersarang()
        {
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    Console.Write("({0},{1})", i, j);
                }
                Console.Write("\n");
            }
        }
        private void PerulanganForeach()
        {
            int[] namaArray = { 89, 79, 32, 21, 48 };
            int sum = 0;

            foreach (int x in namaArray)
            {
                Console.Write(x + ",");
                sum += x;
            }
            Console.WriteLine(sum);
        }
        private void LengthToUpper()
        {
            string nama = "mahirkoding";
            Console.WriteLine("Nama = " + nama);
            Console.WriteLine($"Jumlah karakter nama adalah {nama.Length} Karakter ");
        }
        private void Substring()
        {
            string kode = "P201203cx021";
            string tahun = kode.Substring(1, 4);
            string bulan = kode.Substring(5, 2);
            string lokasi = kode.Substring(7, 2);
            string no = kode.Substring(9);

            Console.WriteLine($"Kode = {kode}");
            Console.WriteLine($"Tahun = {tahun}");
            Console.WriteLine($"Bulan = {bulan}");
            Console.WriteLine($"Lokasi = {lokasi}");
            Console.WriteLine($"no = {no}");

            Console.WriteLine("Memotong string dengan Split");
            Console.WriteLine("================");
            string kata = "Aku Sayang Kamu";
            string[] kata2 = kata.Split(' ');
        }
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    PerulanganWhile();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    PerulanganDoWhile();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    PerulanganFor();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    BreakContinue();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    PerulanganBersarang();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    PerulanganForeach();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    LengthToUpper();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    Substring();
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
            Console.WriteLine("1. Perulangan While");
            Console.WriteLine("2. Perulangan Do While");
            Console.WriteLine("3. Perulangan For");
            Console.WriteLine("4. Break dan Continue");
            Console.WriteLine("5. Perulangan Bersarang");
            Console.WriteLine("6. Perulangan Foreach");
            Console.WriteLine("7. Length dan ToUpper");
            Console.WriteLine("8. Subtring");
        }
    }
}
