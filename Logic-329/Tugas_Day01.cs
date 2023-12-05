using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day01
    {
        public void LuasKelilingLingkaran()
        {

            const double phi = 22/7.0;
            double r;

            Console.Write("Masukkan nilai jari-jari = ");
            r = double.Parse(Console.ReadLine());

            double k = 2 * phi * r;
            double l = phi * r * r;
            Console.WriteLine($"nilai K= {k}");
            Console.WriteLine($"nilai L= {l}");


        }
        public void RumusPersegi()
        {
            int s;

            Console.Write($"Masukan nilai sisi = ");
            s = int.Parse(Console.ReadLine());

            double l = s * s;
            double k = 4 * s;
            Console.WriteLine($"Luas = {l}");
            Console.WriteLine($"Keliling = {k}");

        }
        public void NilaiModulus()
        {
            int angka, pembagi, nilaimod;

            Console.Write("masukkan angka1 = ");
            angka = int.Parse(Console.ReadLine());
            Console.Write("masukkan angka2 = ");
            pembagi = int.Parse(Console.ReadLine());

            nilaimod = angka % pembagi;


            Console.WriteLine($"{angka} % {pembagi} adalah {nilaimod}");
            if (nilaimod == 0){
                Console.WriteLine("Tidak ada sisa");
            }
            else
            {
                Console.WriteLine("ada sisa mod");
            }
        }
        public void PuntungRokok()
        {
            int puntung, batang, harga, sisa;

            Console.Write("berapa puntung yang didapat = ");
            puntung = int.Parse(Console.ReadLine());
            batang = (puntung / 8);
            sisa = (puntung % 8);
            harga = 500 * batang;
            Console.Write($"Batang rokok yang di dapat = {batang}");
            Console.WriteLine();
            Console.Write($"sisa puntung rokok yang di dapat = {sisa}");
            Console.WriteLine();
            Console.Write($"Harga yang dijual = {harga}");
        }
    }
}
