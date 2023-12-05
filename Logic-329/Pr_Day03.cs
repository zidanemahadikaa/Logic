using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day03
    {
        public void GajiKaryawan()
        {
            int gol, upahGol = 0;
            int jamker, upah=0;
            double lembur=0, total = 0;
            Console.WriteLine("GAJI KARYAWAN");
            Console.WriteLine("1. golongan 1 dengan upah per jam 2000 rupiah");
            Console.WriteLine("2. golongan 2 dengan upah per jam 3000 Rupiah");
            Console.WriteLine("3. golongan 3 dengan upah per jam 4000 Rupiah");
            Console.WriteLine("4. golongan 4 dengan upah per jam 5000 Rupiah");
            Console.Write("Masukkan Golongan: ");
            gol = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Jam kerja: ");
            jamker = int.Parse(Console.ReadLine());

            if (jamker <=40 )
            {
                lembur = 0;
                if (gol == 1) upahGol = 2000;
                else if (gol == 2) upahGol = 3000;
                else if (gol == 3) upahGol = 4000;
                else if (gol == 4) upahGol = 5000;
                upah = jamker * upahGol;
            }
            else if (jamker > 40)
            {
                if (gol == 1) upahGol = 2000;
                else if (gol == 2) upahGol = 3000;
                else if (gol == 3) upahGol = 4000;
                else if (gol == 4) upahGol = 5000;
                lembur = (jamker - 40) * upahGol * 1.5;
                upah = (jamker*upahGol) - ((jamker-40)*upahGol);
            }
            Console.WriteLine($"Upah: {upah}");
            Console.WriteLine($"Lembur: {lembur}");
            total = upah + lembur;
            Console.WriteLine($"Total: {total}");
        }
        public void Faktorial()
        {
            //int n = 5, faktorial = 1;

            //for (int i = 0; i <= n; i++) { faktorial *= i; }
            //Console.WriteLine($"{n}! = {faktorial}");

            Console.Write("Masukkan bilangan untuk dihitung faktorialnya: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int faktorial = 1;
            
            // Menghitung faktorial
            for (int i = 1; i <= n; i++)
            {
                faktorial *= (int)i;
                Console.Write("{0}x{1} ", i, n);
            }
            Console.Write("= ");
            Console.WriteLine($"{n}! = {faktorial}");
        }
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    GajiKaryawan();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Faktorial();
                    Program.Pause();
                    Menu();
                    break;
                    //case ConsoleKey.D3:
                    //    Console.Clear();
                    //    NilaiSiswa();
                    //    Program.Pause();
                    //    Menu();
                    //    break;
                    //default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        public void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Gaji Karyawan");
            //Console.WriteLine("2. Body Mass Index");
            //Console.WriteLine("3. Nilai Siswa");
        }
    }
}
