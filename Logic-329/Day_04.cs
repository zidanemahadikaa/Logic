using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_04
    {
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    AngkaGanjil();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    ArrayCollection();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    SplitJoin();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    MencariArray();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Array2D();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    ListCollection();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    DateTimeVar();
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
            Console.WriteLine("=".PadRight(25, '='));
            Console.WriteLine("1. Angka Ganjil");
            Console.WriteLine("2. Array Collection");
            Console.WriteLine("3. Split Join");
            Console.WriteLine("4. Mencari Array");
            Console.WriteLine("5. Array 2D");
            Console.WriteLine("6. List Collection");
            Console.WriteLine("7. Date Time");
            Console.WriteLine("=".PadRight(25, '='));
        }
        private void AngkaGanjil()
        {
            for (int i = 0; i < 50; i++)
            {
                i += 1;
                Console.WriteLine(i);
            }
        }
        public void ArrayCollection()
        {
            int[] array = new int[5];
            Console.WriteLine("Jumlah elemen Array1: " + array.Length);
            Console.WriteLine();

            int[] array2 = new int[5] {1, 2, 3, 4, 5};
            Console.WriteLine("Jumlah elemen Array2: " + array2.Length);
            foreach (int element in array2) { Console.Write(element + " "); }
            Console.WriteLine();

            int[] array3 = new int[] { 6, 7, 8, 9, 10 };
            Console.WriteLine("Jumlah elemen Array3: " + array3.Length);
            foreach (int element in array3) { Console.Write(element + " "); }
            Console.WriteLine();

            string[] array4 = { "satu", "dua", "tiga", "empat" };
            Console.WriteLine("Jumlah elemen Array4: " + array4.Length);
            foreach (string element in array4) { Console.Write(element + " "); }
            Console.WriteLine();

            float[] array5;
            array5 = new float[] { 1.1f, 1.2f, 1.3f, 1.4f };
            Console.WriteLine("Jumlah elemen Array5: " + array5.Length);
            foreach (float element in array5) { Console.Write(element + " "); }
            Console.WriteLine();

            string kalimat = "Ini adalah sebuah kalimat";
            char[] charArray = kalimat.ToCharArray();
            Console.WriteLine("Jumlah elemen CharArray: " + charArray.Length);
            Console.WriteLine();
            foreach (char element in charArray) { Console.Write(element); }
            Console.WriteLine();
            Array.Sort(charArray);
            foreach (char element in charArray) { Console.Write(element); }
            Console.WriteLine();

            string kalimat2 = "Ini adalah sebuah kalimat";
            char[] charArray2 = kalimat2.ToCharArray();
            string kalimatBaru2 = "";
            Array.Sort(charArray);
            Console.WriteLine();
            foreach (char element in charArray) { 
                Console.Write(element);
                kalimatBaru2 += element;
            }

            Console.WriteLine();
            Console.WriteLine("2 kalimat tersebut adalah anagram? " + (kalimatBaru2));
        }
        public void SplitJoin()
        {
            string kalimat = "Sukses datang kepada meraka yang bekerja keras";
            string[] kata2 = kalimat.Split(' ');
            Console.WriteLine(kalimat);
            foreach (string kata in kata2)
            {
                Console.WriteLine(kata);
            }
            Console.WriteLine(string.Join('-', kata2));
        }
        public void MencariArray()
        {
            string[] nama = { "alan", "budi", "kusuma", "susi", "susanti" };
            Console.WriteLine(string.Join(", ", nama));

            Console.Write("Nama yang dicari: ");
            string yangDicari = Console.ReadLine();
            Console.WriteLine("Apakah Ada {0}? {1}", yangDicari, (Array.IndexOf(nama, yangDicari)>=0?"ada":"Tidak ada"));
        }
        public void Array2D()
        {
            int[,] array2D = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Array Length: " + array2D.Length);
            for (int i=0; i < 3; i++)
            {
                for (int j=0; j < 3; j++)
                {
                    Console.Write(array2D[i,j]+ ",");
                }
                Console.WriteLine();
            }
        }
        public void ListCollection()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            //primeNumbers.Add(11);

            Console.WriteLine("Jumlah elemen list = {0}", primeNumbers.Count);
            Console.WriteLine("Bilangan Prima {0}", string.Join(", ", primeNumbers));
            Console.WriteLine("Bilangan 11 ada di indeks ke {0}", primeNumbers.IndexOf(11));

            primeNumbers.Add(11);
            primeNumbers.Add(17);
            Console.WriteLine("Menambahkan bilangan 11 ke dalam list");
            Console.WriteLine("Bilangan Prima {0}", string.Join(", ", primeNumbers));
            Console.WriteLine("Bilangan 11 ada di indeks ke {0}", primeNumbers.IndexOf(11));

            primeNumbers.Insert(primeNumbers.IndexOf(17), 13);
            Console.WriteLine("Menyisipkan bilangan 13 diantara 11 dan 17 di dalam list");
            Console.WriteLine("Bilangan Prima {0}", string.Join(", ", primeNumbers));

            Console.WriteLine("Membuang bilangan 13 list");
            primeNumbers.Remove(13);
            Console.WriteLine("Bilang prima {0}", string.Join(", ", primeNumbers));

            Console.WriteLine("membuang index ke-0 dari list");
            primeNumbers.RemoveAt(0);
            Console.WriteLine("Bilang prima {0}", string.Join(", ", primeNumbers));

        }
        public void DateTimeVar()
        {
            CultureInfo idCulture = new CultureInfo("en-US");
            DateTime dt1 = new DateTime();
            DateTime dt2 = DateTime.Parse("2023-09-18", idCulture);  // akan diterima karena menggunakan format sta
            //DateTime dt2a = DateTime.Parse("09-18-2023", idCulture);  // akan diterima karena sama format tanggal
            //DateTime dt2b = DateTime.Parse("18-09-2023", idCulture);  // akan menghasilkan error karena beda format tanggal
            
            //ambil datetime dari sistem komputer
            DateTime dt3 = DateTime.Now;
            DateTime dt4 = new DateTime(2023, 9, 18, 8, 51, 25);

            Console.WriteLine($"dt1 = {dt1}");
            Console.WriteLine($"dt2 = {dt2.ToString("MMM dd, yyyy hh:mm:sstt")}");
            Console.WriteLine($"dt3 = {dt3.ToString("MMM dd, yyyy hh:mm:sstt K")}");
            Console.WriteLine($"dt3 dengan CultureInfo US format ShortDate = {dt3.ToString("d", idCulture)}");
            Console.WriteLine($"dt3 dengan CultureInfo US format LongDate = {dt3.ToString("D", idCulture)}");
            Console.WriteLine($"dt3 dengan CultureInfo ID format LongDate = {dt3.ToString("F", new CultureInfo("id-ID"))}");
            Console.WriteLine($"dt4 = {dt4.ToString("f", idCulture)}");

            //DateTime Parsing
            int tahun = dt4.Year; 
            int bulan = dt4.Month;
            int tanggal = dt4.Day;
            int jam = dt4.Hour;
            int menit = dt4.Minute;
            int detik = dt4.Second;
            int nilaiDetik = dt4.Millisecond;
            int hariDalamPekan = (int)dt4.DayOfWeek;

            //hasil parsing dt4
            Console.WriteLine("Hasil Parsing dt4: ");
            Console.WriteLine($"Tahun dt4 = {tahun}");
            Console.WriteLine($"Bulan dt4 = {bulan}");
            Console.WriteLine($"Tanggal dt4 = {tanggal}");
            Console.WriteLine($"jam dt4 = {jam}");
            Console.WriteLine($"menit dt4 = {menit}");
            Console.WriteLine($"Detik dt4 = {detik}");
            Console.WriteLine($"Milisecond dt4 = {nilaiDetik}");
            Console.WriteLine($"Hari dalam Pekan dt4 = {hariDalamPekan}");

            //Datetime add untuk menambahkan nilai ke dalam Datetime
            DateTime dt3Date5 = dt3.AddDays(5), dt3Date15 = dt3.AddDays(15);
            Console.WriteLine();
            Console.WriteLine($"Sekarang tanggal: {dt3Date5.ToString("d", idCulture)}");
            Console.WriteLine($"5 hari ke depan adalah tanggal {dt3Date5.ToString("d", idCulture)}");
            Console.WriteLine($"15 hari ke depan adalah tanggal {dt3Date15.ToString("d", idCulture)}");

            //Datetime Ticks
            Console.WriteLine();
            Console.WriteLine($"1 {dt1} = {dt1.Ticks}, Ticks");
            Console.WriteLine($"Hari ini  {dt3} = {dt3.Ticks:N}, Ticks");

            //Date Time TimeSpan
            DateTime dtAwal = DateTime.Parse("2023-09-17 09:42:01");
            DateTime dtAkhir = DateTime.Parse("2023-09-18 09:42:01");
            TimeSpan interval = dtAkhir - dtAwal;
            Console.WriteLine();
            Console.WriteLine("Date TiemSpan");
            Console.WriteLine($"dtAwal = {dtAwal.ToString("F")}");
            Console.WriteLine($"dtAkhir = {dtAkhir.ToString("F")}");

            Console.WriteLine($"Interval keduanya = {interval.Ticks:N} Ticks");
            Console.WriteLine($"Interval keduanya = {interval.TotalDays:N} Hari");
            Console.WriteLine($"Interval keduanya = {interval.TotalHours:N} Jam");
            Console.WriteLine($"Interval keduanya = {interval.TotalMinutes:N} Menit");
            Console.WriteLine($"Interval keduanya = {interval.TotalSeconds:N} Detik");
        }
    }
}
