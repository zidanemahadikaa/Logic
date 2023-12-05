using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day08
    {
        public void Menu()
        {
            Console.Clear();
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    BayarParkir();
                    Program.Pause();
                    break;
                case ConsoleKey.D2:
                    MeminjamBuku();
                    Program.Pause();
                    break;
                case ConsoleKey.D3:
                    HariLibur();
                    Program.Pause();
                    break;
                case ConsoleKey.D4:
                    BocilWarnet();
                    Program.Pause();
                    break;
                case ConsoleKey.D5:
                    TiketKonser();
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
            Console.WriteLine("1. Bayar Parkir      ");
            Console.WriteLine("2. Meminjam Buku     ");
            Console.WriteLine("3. Hari Ujian        ");
            Console.WriteLine("4. Bocil Warnet      ");
            Console.WriteLine("5. Tiket Konser      ");
            Console.WriteLine("Press any key to Main Menu");
        }
        public void BayarParkir()
        {            
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();

            Console.WriteLine("masukkan tanggal & jam masuk");
            dt1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("masukkan tanggal & jam keluar");
            dt2 = DateTime.Parse(Console.ReadLine());

            TimeSpan interval = dt2 - dt1;
            int durasi = (int)Math.Ceiling(interval.TotalMinutes / 60);

            int biayaParkir = durasi * 3000;

            Console.WriteLine();
            Console.WriteLine(durasi);
            Console.WriteLine(biayaParkir);
        }
        public void MeminjamBuku()
        {
            CultureInfo tanggalId = new CultureInfo("id-ID");

            DateTime tgl1 = new DateTime();
            DateTime tgl2 = new DateTime();

            Console.Write("Masukkan Tanggal Pinjaman: ");
            tgl1 = DateTime.Parse(Console.ReadLine(), tanggalId);
            
            DateTime tgl3 = tgl1.AddDays(3);
            Console.WriteLine("Harus dikembalikan dalam tiga hari yaitu pada tanggal: {0}", tgl3.ToString("d", tanggalId));

            Console.Write("Masukkan Tanggal Pengembalian");
            tgl2 = DateTime.Parse(Console.ReadLine(), tanggalId);

            TimeSpan interval = tgl2 - tgl3;
            double durasi = (interval.TotalDays);

            if(durasi > 0)
            {
                Console.WriteLine("Kamu Telat {0} hari", durasi);
                Console.WriteLine("Kamu harus membayar denda sebesar: {0}", durasi*500);
            }
            else Console.WriteLine("Terima kasih telah meminjam");
        }
        public void HariLibur()
        {
            try
            {
                int hari = 0;

                //CultureInfo timeId = new CultureInfo("en-US");
                DateTime dt1;
                string libur;

                Console.Write("Masukkan Tanggal (mm/dd/yyyy): ");
                dt1 = DateTime.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.Write("Masukkan hari libur: ");
                libur = Console.ReadLine();
                string[] liburr = libur.Split(',');

                DateTime tglUjian = dt1.AddDays(10);

                while (hari < 11)
                {
                    if (!liburr.Any(a => int.Parse(a) == dt1.Day) && dt1.DayOfWeek != DayOfWeek.Saturday && dt1.DayOfWeek != DayOfWeek.Sunday)
                    {
                        hari++;
                    }
                    if (hari != 11) dt1 = dt1.AddDays(1);
                }
                Console.WriteLine($"Ujian akan dimulai pada tanggal {dt1.ToString("d", new CultureInfo("en-US"))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Masukkan format tanggal yang benar {0}", ex.Message);
                Console.ReadLine();
                Console.Clear();
                HariLibur();
            }
            

        }
        public void BocilWarnet()
        {
            try
            {
                CultureInfo cultureID = new CultureInfo("id-ID");

                int durasi;
                int sewa = 3500;
                int tambah;
                DateTime jam = new DateTime();

                Console.Write("Mau main berapa jam dek?: ");
                durasi = int.Parse(Console.ReadLine());
                Console.Write("Mulai dari jam: ");  
                jam = DateTime.Parse(Console.ReadLine(), cultureID);

                sewa = sewa * durasi;
                jam = jam.AddHours(durasi);
                Console.WriteLine("Selesai jam: {0}", jam.ToString("HH:mm", cultureID));
                Console.WriteLine("Biaya Sewa {0}", sewa);

                Console.WriteLine("Mau nambah gak dek? y/n");
                string konfirmasi = Console.ReadLine();

                if (konfirmasi == "y")
                {
                    Console.Write("Nambah berapa jam dek?: ");
                    tambah = int.Parse(Console.ReadLine());

                    jam = jam.AddHours(tambah);
                    Console.WriteLine("Selesai jam: {0}", jam.ToString("HH:mm", cultureID));
                    Console.WriteLine("Biaya Sewa {0}", sewa + (tambah * 3500));
                }
                else if (konfirmasi == "n")
                {
                    Console.WriteLine("Yaudah sana dek pulang dicariin mamah");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan , {0}", ex.Message);
                Console.ReadLine();
                Console.Clear();
                BocilWarnet();
            }
        }
        public void TiketKonser()
        {
            CultureInfo TimeId = new CultureInfo("id-ID");
            DateTime tglKonser = DateTime.Now;
            DateTime inputTgl = new DateTime();            

            Console.WriteLine("Masukkan tanggal lahir: (cth. 01/8/2003)");
            inputTgl = DateTime.Parse(Console.ReadLine(), TimeId);

            TimeSpan interval = tglKonser - inputTgl;
             

            int umur = (int)Math.Ceiling(interval.TotalDays / 365.25);


            Console.WriteLine($"{tglKonser:f}");
            Console.WriteLine($"{inputTgl:f}");
            if (umur < 18)
            {
                Console.WriteLine($"Umur kamu {umur}");
                Console.WriteLine("Kamu belum cukup umur");
            }
            else if(umur >= 18 && tglKonser.ToString("d/M", TimeId) == inputTgl.ToString("d/M", TimeId))
            {
                Console.WriteLine($"Umur kamu {umur}");
                Console.WriteLine("Selamat Ulang Tahun. kamu gratis nonton konser");
                Console.WriteLine("Silangkan melakukan pembayaran");
            }
            else
            {
                Console.WriteLine($"Umur kamu {umur}");
                Console.WriteLine("kamu bisa membeli tiket dengan harga RP1.500.000");
                Console.WriteLine("Silangkan melakukan pembayaran");
            }            
        }
    }
}
