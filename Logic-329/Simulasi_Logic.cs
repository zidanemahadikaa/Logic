using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Simulasi_Logic
    {
        public void Menu()
        {
            Console.Clear();
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    UpperWord();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    InvoicePenjualan();
                    Program.Pause();
                    break;
                case ConsoleKey.D3:
                    KeranjangBuah();
                    Program.Pause();
                    break;
                case ConsoleKey.D4:
                    BantuanPakaian();
                    Program.Pause();
                    break;
                case ConsoleKey.D6:
                    DeretHimpunan();
                    Program.Pause();
                    break;
                case ConsoleKey.D7:
                    GradingStudents();
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
            Console.WriteLine("1. Upper Word        ");
            Console.WriteLine("2. Invoice Penjualan ");
            Console.WriteLine("3. Keranjang Buah    ");
            Console.WriteLine("4. Bantuan Pakaian   ");
            Console.WriteLine("5. .     ");
            Console.WriteLine("6. Deret Himpunan    ");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void UpperWord()
        {
            string kata = "AkuSayangKamuTapiKamu";
            Console.WriteLine(kata);
            int kataKapital = 0;

            for (int i = 0; i < kata.Length; i++)
            {
                if (char.IsUpper(kata[i]))
                {
                    kataKapital++;
                }
            }
            Console.WriteLine(kataKapital);
        }
        public void InvoicePenjualan()
        {
            CultureInfo tanggalId = new CultureInfo("id-ID");
            Console.Write("start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Tanggal: ");
            DateTime tanggal = DateTime.Parse(Console.ReadLine(), tanggalId);

            string[] pisahKata = tanggal.ToString("d", tanggalId).Split('/');

            for (int i = start; i <= end; i++)
            {
                int noDigit = 00000;
                Console.WriteLine($"XA-{string.Join("", pisahKata)}-{noDigit + i:d5}");
            }
        }
        public void KeranjangBuah()
        {
            int sisa = 0;
            List<int> keranjang = new List<int>();

            Console.Write("Keranjang 1: ");
            int keranjang1 = int.Parse(Console.ReadLine());
            keranjang.Add(keranjang1);
            Console.Write("Keranjang 2: ");
            int keranjang2 = int.Parse(Console.ReadLine());
            keranjang.Add(keranjang2);
            Console.Write("Keranjang 3: ");
            int keranjang3 = int.Parse(Console.ReadLine());
            keranjang.Add(keranjang3);

            Console.Write("Keranjang yang dibawa: ");
            int ambil = int.Parse(Console.ReadLine());
            keranjang.RemoveAt(ambil - 1);

            foreach (int i in keranjang)
            {
                sisa += i;
            }
            Console.WriteLine($"Keranjang {ambil} dibawa ke pasar, sisa buah = {sisa}");
        }
        public void BantuanPakaian()
        {
            int ld = 0;
            int wd = 0;
            int anak = 0;
            int bayi = 0;
            bool yn = true;
            List<int> pakaian = new List<int>();

            Console.WriteLine("Menu Bantuan Pakaian");
            Console.WriteLine("1. Laki-laki dewasa");
            Console.WriteLine("2. Wanita dewasa ");
            Console.WriteLine("3. anak-anak");
            Console.WriteLine("4. bayi");
            //Console.WriteLine("Tambah input? y/n");
            //yn = Console.ReadLine();
            Console.WriteLine();

            while (yn)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("Laki-Laki Dewasa: ");
                        pakaian.Add(int.Parse(Console.ReadLine()));
                        //ld = int.Parse(Console.ReadLine());                        
                        //Console.WriteLine(ld);
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Wanita dewasa: ");
                        pakaian.Add(int.Parse(Console.ReadLine()) * 2);
                        //wd = int.Parse(Console.ReadLine());                        
                        //Console.WriteLine(wd);
                        break;
                    case ConsoleKey.D3:
                        Console.Write("Anak-anak: ");
                        pakaian.Add(int.Parse(Console.ReadLine()) * 3);
                        //anak = int.Parse(Console.ReadLine());
                        //Console.WriteLine(anak);
                        break;
                    case ConsoleKey.D4:
                        Console.Write("Bayi: ");
                        pakaian.Add(int.Parse(Console.ReadLine()));
                        //bayi = int.Parse(Console.ReadLine());
                        //Console.WriteLine(bayi);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("y/n");
                string pilih = Console.ReadLine();
                if (pilih == "y")
                {
                    yn = true;
                }
                else if (pilih == "n")
                {
                    yn = false;
                }
            }
            int total = pakaian.Count;
            Console.WriteLine(pakaian);
            //for(int i = 0; i < pakaian.Count;i++)
            //{
            //    int total = pakaian.Count;
            //    Console.WriteLine(total);
            //}
            //ld = ld * 1;
            //wd = wd * 2;            
            //anak = anak * 3;            
            //bayi = bayi * 5;

            //int total = ld + wd + anak + bayi;
            //Console.WriteLine(total);

            //if(total % 2 != 0 && total > 10)
            //{
            //    wd = wd * 1;
            //}
            //total = total + wd;
            //Console.WriteLine(total);
        }
        public void DeretHimpunan()
        {
            int input;
            List<int> fibonaci = new List<int>();
            List<int> genap = new List<int>();
            List<int> ganjil = new List<int>();
            int angkaberikut = 0;
            int sumFibonaci = 0;
            int sumGenap = 0;
            int sumGanjil = 0;
            int avgGenap = 0;
            int avgGanjil = 0;

            fibonaci.Add(1);
            fibonaci.Add(1);

            Console.Write("Masukkan Maksimal himpunan : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input - 2; i++)
            {
                angkaberikut = fibonaci[i - 1] + fibonaci[i];
                fibonaci.Add(angkaberikut);
                //sumFibonaci += angkaberikut;
                //fibonaci.Add(angkaberikut);
                //angkaberikut = i + fibonaci.IndexOf(i);
                //fibonaci.Add(angkaberikut);

                //angkaberikut = i + i;

            }
            for (int i = 0; i < fibonaci.Count; i++)
            {
                sumFibonaci += fibonaci[i];
            }
            for (int i = 1; i <= input; i++)
            {
                angkaberikut = i * 2;
                genap.Add(angkaberikut);
                sumGenap += angkaberikut;
                avgGenap = sumGenap / input;
            }
            for (int i = 1; i <= input; i++)
            {
                angkaberikut = (i * 2) - 1;
                ganjil.Add(angkaberikut);
                sumGanjil += angkaberikut;
                avgGanjil = sumGanjil / input;
            }
            Console.WriteLine("Fibonacci : " + string.Join(", ", fibonaci));
            Console.WriteLine("Genap : " + string.Join(", ", genap));
            Console.WriteLine("Ganjil : " + string.Join(", ", ganjil));
            Console.WriteLine("Sum : " + sumFibonaci);
            Console.WriteLine("Sum : " + sumGenap);
            Console.WriteLine("Sum : " + sumGanjil);
            Console.WriteLine("Avg : " + (double)sumFibonaci / (double)input);
            Console.WriteLine("Avg : " + avgGenap);
            Console.WriteLine("Avg : " + avgGanjil);
        }
        
        public static long aVeryBigSum(List<long> ar)
        {
            long hasil = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                hasil += ar[i];
            }
            return hasil;
        }
        public void GradingStudents()
        {
            List<int> n = new List<int>() { 73, 67, 38, 33};           
            for (int i = 0; i < n.Count; i++)
            {
                int grade;
                grade = int.Parse(Console.ReadLine());

                if (grade < 38)
                {
                    Console.WriteLine(grade);
                    continue;
                }
                int rem = grade % 5;
                if (5 - rem < 3)
                    grade += 5 - rem;
                Console.WriteLine(grade);
            }
        }
    }
}
