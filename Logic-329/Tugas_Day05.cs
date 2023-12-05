using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day05
    {
        public void Menu()
        {
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    TimeConversion();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    TiupLilin();
                    Program.Pause();
                    break;
                case ConsoleKey.D3:
                    SplitBill();
                    Program.Pause();
                    break;
                case ConsoleKey.D4:
                    DiagonalDifferences();
                    Program.Pause();
                    break;
                case ConsoleKey.D5:
                    GantiPosisi();
                    Program.Pause();
                    break;
                default:
                    break;
            }
        }
        static void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Time Conversion     ");
            Console.WriteLine("2. Tiup Lilin          ");
            Console.WriteLine("3. Split Bill          ");
            Console.WriteLine("4. Diagonal Differences");
            Console.WriteLine("5. Ganti Posisi        ");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void TimeConversion()
        {
            CultureInfo CultureUS = new CultureInfo("en-US");
            CultureInfo CultureID = new CultureInfo("id-ID");

            DateTime dt1 = DateTime.Parse("07:05:45 PM", CultureUS);

            Console.WriteLine($"Jam : {dt1.ToString("hh:mm:ss tt", CultureUS)}");
            Console.WriteLine($"Jam : {dt1.ToString("HH:mm:ss", CultureID)}");

            Console.WriteLine();

            Console.WriteLine("Masukkan Jam:  ");
            string jam = Console.ReadLine();
            Console.WriteLine(DateTime.Parse(jam).ToString("HH:mm:ss"));
        }
        public void TiupLilin()
        {
            int[] lilin = { 3, 2, 1, 3 };
            Console.WriteLine($"lilin: {string.Join(", ", lilin)}");

            Array.Sort(lilin);

            int lilinTertinggi = lilin[lilin.Length - 1];
            int jmlLilinTertinggi = 0;

            foreach (int x in lilin) {
                jmlLilinTertinggi += x == lilinTertinggi? 1 : 0;
            }
            Console.WriteLine($"Jumlah lilin yang ditiup = {jmlLilinTertinggi}");
        }
        public void SplitBill()
        {
            int totalMenu, indexAlergi, uangelsa, makananElsa, total=0;
            double totalElsa, kembalianElsa;

            Console.WriteLine("Total Menu: ");
            totalMenu = int.Parse(Console.ReadLine());

            Console.WriteLine("Index Makanan Alergi: ");
            indexAlergi = int.Parse(Console.ReadLine());
            int[] harga = new int[totalMenu];

            for (int i = 0; i < totalMenu; i++)
            {
                Console.Write($"Harga Menu ke-{i+1}");
                harga[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uang Elsa: ");
            uangelsa = int.Parse(Console.ReadLine());

            foreach (int i in harga) total += i;

            Console.WriteLine($"Total makanan yang dipesan Dimas & Elsa {total}");
        }
        public void DiagonalDifferences()
        {
            int jumlah = 0, jumlah2 = 0;
            int[,] matriks = new int[,]
            {
                {11,2,4},
                {4,5,6},
                {10,8,-12}
            };
            for (int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i==j) jumlah += matriks[i,j];
                    if(i==2-j) jumlah2 += matriks[i,j];
                }
            }
            //jumlah *= (jumlah < 0) ? -1 : 0;
            //jumlah = Math.Abs(jumlah);

            Console.WriteLine($"Perbedaan Diagonal adalah: |{jumlah} - {jumlah2}| = {Math.Abs(jumlah - jumlah2)}");
        }
        public void GantiPosisi()
        {
            List <int> arr = new List<int>(){ 5, 6, 7, 0, 1 };
            int rot = 5;
            for (int i=0;i<rot;i++)
            {
                arr.Add(arr[0]);
                arr.RemoveAt(0);
                Console.WriteLine("Output {0}: {1}",i+1, string.Join(", ", arr));
                
            }
        }
    }
}
