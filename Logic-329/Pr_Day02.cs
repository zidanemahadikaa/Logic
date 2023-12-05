using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day02
    {
        public void TunjanganGajiPokok()
        {
            string nama;
            double tunjangan, gapok, bulan, pajak = 0, gt, gb = 0, total = 0;
            double bpjs = 3 / 100.0;

            Console.Write("Nama = ");
            nama = Console.ReadLine();
            Console.Write("Tunjangan = ");
            tunjangan = double.Parse(Console.ReadLine());
            Console.Write("Gaji Pokok = ");
            gapok = double.Parse(Console.ReadLine());
            Console.Write("Bulan = ");
            bulan = double.Parse(Console.ReadLine());
            gt = tunjangan + gapok;

            if (gt <= 5000000)
            {
                pajak = 5 / 100.0;
                pajak = pajak * gt;
                bpjs = bpjs * gt;
                gb = gt - (pajak + bpjs);
                total = gb * bulan;
            }
            else if (gt > 5000000 && gt <= 10000000)
            {
                pajak = 10 / 100.0;
                pajak = pajak * gt;
                bpjs = bpjs * gt;
                gb = gt - (pajak + bpjs);
                total = gb * bulan;
            }
            else if (gt > 10000000)
            {
                pajak = 15 / 100.0;
                pajak = pajak * gt;
                bpjs = bpjs * gt;
                gb = gt - (pajak + bpjs);
                total = gb * bulan;
            }
            Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut:");
            Console.WriteLine($"Pajak : {pajak}");
            Console.WriteLine($"BPJS : {bpjs}");
            Console.WriteLine($"Gaji/Bulan : {gb}");
            Console.WriteLine($"Total Gaji/Banyak bulan : {total}");
        }
        public void BodyMassIndex()
        {
            double berat, tinggi, bmi;
            string golongan = "";

            Console.Write("Masukkan Berat badan anda (kg): ");
            berat = double.Parse(Console.ReadLine());
            Console.Write("Masukkan Tinggi badan anda (cm): ");
            tinggi = double.Parse(Console.ReadLine());
            tinggi = tinggi * 0.01;
            bmi = berat / (tinggi*tinggi);

            if (bmi < 18.5)
            {
                golongan = "Kurus";
            }
            else if(bmi >=  18.5 && bmi < 25.0)
            {
                golongan = "sehat";
            }
            else if (bmi >= 25.0)
            {
                golongan = "Gemuk";
            }
            Console.WriteLine($"Anda Termasuk golongan {golongan}");
        }
        public void NilaiSiswa()
        {
            int mtk = 0, fisika = 0, kimia = 0, rata2;

            Console.Write("Masukkan nilai MTK: ");
            mtk = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai Fisika: ");
            fisika = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai Kimia: ");
            kimia = int.Parse(Console.ReadLine());
            rata2 = (mtk + fisika + kimia) / 3;
            Console.WriteLine($"Nilai Rata-rata: {rata2}");

            if (rata2 >= 75)
            {
                Console.WriteLine("Selamat\nKamu berhasil\nKamu Hebat");
            }
            else {
                Console.WriteLine("Maaf\nkamu gagal");
            }
        }
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    TunjanganGajiPokok();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    BodyMassIndex();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    NilaiSiswa();
                    Program.Pause();
                    Menu();
                    break;
                default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        public void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(20, '='));
            Console.WriteLine("1. Tunjangan Gaji Pokok");
            Console.WriteLine("2. Body Mass Index");
            Console.WriteLine("3. Nilai Siswa");
        }
    }
}
