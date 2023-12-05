using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day02
    {
        public void Menu()
        {
            PilihanMenu();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    IndeksNilai(70);
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    PointPulsa();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    DiskonGrab();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    VoucherSopi();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Generasi();
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
        public string IndeksNilai(int hasilNilai)
        {
            if (hasilNilai >= 90 && hasilNilai <= 100) return "A";
            else if (hasilNilai >= 70 && hasilNilai <= 89) return "B";
            else if (hasilNilai >= 50 && hasilNilai <= 69) return "C";
            else if (hasilNilai >= 30 && hasilNilai <= 49) return "D";
            else if (hasilNilai >= 0 && hasilNilai <= 29) return "E";
            else return "Undefined";
        }
        public void PointPulsa()
        {
            int pulsa;

            Console.Write("Masukkan Pulsa = ");
            pulsa = int.Parse(Console.ReadLine());

            if (pulsa >= 10000 && pulsa <= 24900)
            {
                Console.WriteLine("Selamat anda mendapatkan point +80");
            }
            else if (pulsa >= 25000 && pulsa <= 49000)
            {
                Console.WriteLine("Selamat anda mendapatkan point +200");
            }
            else if (pulsa >= 50000 && pulsa <= 99000)
            {
                Console.WriteLine("Selamat anda mendapatkan point +400");
            }
            else if (pulsa >= 100000)
            {
                Console.WriteLine("Selamat anda mendapatkan point +800");
            }
            else
            {
                Console.WriteLine("Terjadi kesalahan");
            }
        }
        public void DiskonGrab()
        {
            int belanja, jarak, ongkir;
            float diskon, total;
            string promo;

            Console.Write("Belanja = ");
            belanja = int.Parse(Console.ReadLine());
            Console.Write("Jarak (km) = ");
            jarak = int.Parse(Console.ReadLine());
            if (belanja >= 30000)
            {
                Console.Write("Masukkan kode Promo = ");
                promo = (Console.ReadLine());
                if (promo == "JKTOVO")
                {
                    Console.WriteLine("Anda Berhasil memasukkan kode promo");
                    diskon = belanja * .4f; 
                }
                else 
                {
                    Console.WriteLine("Anda gagal memasukkan promo");
                    diskon = 0;
                }
            }
            else
            {
                Console.WriteLine("Anda tidak dapat promo");
                diskon = 0;
            }
            Console.WriteLine("============");
            Console.WriteLine($"Belanja = {belanja}");
            Console.WriteLine($"Diskon = {diskon}");
            ongkir = jarak * 1000;
            Console.WriteLine($"Ongkir = {ongkir}");
            total = belanja + ongkir - diskon;
            Console.WriteLine($"Total belanja = {total}");
        }
        public void VoucherSopi()
        {
            int belanja, ongkir, potongan, diskon, total;
            int freeOngkir = potongan = 0;
            string promo1 = "1. Min Order 30rb free ongkir 5rb dan potongan harga belanja 5rb";
            string promo2 = "2. Min Order 50rb free ongkir 10rb dan potongan harga belanja 10rb";
            string promo3 = "3. Min Order 100rb free ongkir 20rb dan potongan harga belanja 10rb";

            Console.Write("Belanja = ");
            belanja = int.Parse(Console.ReadLine());
            Console.Write("Ongkir = ");
            ongkir = int.Parse(Console.ReadLine());
            if (belanja >= 30000 && belanja <= 49000)
            {
                Console.WriteLine("Anda mendapatkan voucher");
                Console.WriteLine(promo1);
            }
            else if (belanja >= 50000 && belanja <= 99000)
            {
                Console.WriteLine("Anda mendapatkan voucher");
                Console.WriteLine(promo1);
                Console.WriteLine(promo2);
            }
            else if (belanja >= 100000)
            {
                Console.WriteLine("Anda mendapatkan voucher");
                Console.WriteLine(promo1);
                Console.WriteLine(promo2);
                Console.WriteLine(promo3);
            }
            else Console.WriteLine("Anda tidak mendapat promo");
            Console.Write("Pilih Voucher : ");
            ConsoleKey keyboard = Console.ReadKey(true).Key;
            if (keyboard == ConsoleKey.D1)
            {
                potongan = freeOngkir = 5000;
            }
            else if (keyboard == ConsoleKey.D2)
            {
                potongan = freeOngkir = 10000;
            }
            else if (keyboard == ConsoleKey.D3)
            {
                potongan = freeOngkir = 20000;
            }
            else Console.WriteLine("Salah");
            Console.WriteLine("==============");
            Console.WriteLine($"Belanja = {belanja}");
            Console.WriteLine($"Ongkir = {ongkir}");
            Console.WriteLine($"Free Ongkir = {freeOngkir}");
            Console.WriteLine($"Diskon Belanja = {potongan}");
            diskon = freeOngkir + potongan;
            total = belanja + ongkir - diskon;
            Console.WriteLine($"Total Belanja = {total}");
        }
        public void Generasi()
        {
            string gen = null;
            string nama;
            int lahir;
            Console.Write("Nama = ");
            nama = Console.ReadLine();
            Console.Write("Tahun Lahir = ");
            lahir = int.Parse(Console.ReadLine());
            if (lahir >= 1944 && lahir <= 1964) gen = "Baby Boomer";
            else if (lahir >= 1965 && lahir <= 1979) gen = "Generasi X";
            else if (lahir >= 1980 && lahir <= 1994) gen = "Generasi Y";
            else if (lahir >= 1995 && lahir <= 2015) gen = "Generasi Z";
            Console.WriteLine($"Anda termasuk {gen}");
        }
    }
}
