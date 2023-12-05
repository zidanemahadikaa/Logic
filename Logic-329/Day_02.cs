using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_02
    {
        public void OperatorAritmatika()
        {
            int mangga, apel, hasil;
            string namaDepan, namaBelakang;

            Console.Write("Nama Depan: ");
            namaDepan = Console.ReadLine();

            Console.Write("Nama Belakang: ");
            namaBelakang = Console.ReadLine();

            Console.WriteLine("Nama Lengkap = {0}", namaDepan + namaBelakang);

            Console.Write("Jumlah mangga = ");
            mangga = int.Parse(Console.ReadLine());

            Console.Write("Jumlah apel = ");
            if(int.TryParse(Console.ReadLine(), out apel))
            {
                Console.WriteLine("Sukses memasukkan angka");

                hasil = mangga + apel;

                Console.WriteLine("Hasil Mangga + Apel = {0}", hasil);
                Console.WriteLine("Hasil Mangga - Apel = {0}", mangga - apel);
                Console.WriteLine("Hasil Mangga / Apel = {0}", (float)mangga / (float)apel);
                Console.WriteLine("Hasil Mangga * Apel = {0}", mangga * apel);

                Console.WriteLine();
                Console.WriteLine("Mangga = {0}", mangga);
                Console.WriteLine("Apel = {0}", apel);

                Console.WriteLine();
                Console.WriteLine("Hasil Mangga / 2 = {0}", (double)mangga / 2.0);
                Console.WriteLine("Hasil Mangga Mod 7 = {0}", mangga % 7);
                //mangga++;
                //apel++;
                Console.WriteLine();
                Console.WriteLine("Hasil ++mangga = {0}", ++mangga);
                Console.WriteLine("Hasil ++apel = {0}", ++apel);
                Console.WriteLine("Hasil --mangga = {0}", --mangga);
                Console.WriteLine("Hasil --apel= {0}", --apel);
                Console.WriteLine("Hasil mangga++ = {0}", mangga++);
                Console.WriteLine("Hasil apel++ = {0}", apel++);
                Console.WriteLine("Hasil mangga-- = {0}", mangga--);
                Console.WriteLine("Hasil apel-- = {0}", apel--);
            }
            else
            {
                Console.WriteLine("Masukkan angka");
                OperatorAritmatika();
            }
        }
        public void OperatorPenugasan()
        {
            int a;

            //Operator Penugasan(Assignmet)
            a = 15;
            Console.WriteLine("a = " + a);

            a = a + 10;
            Console.WriteLine("a + 10 = " + a);

            a += 10;
            Console.WriteLine("a += 10 = " + a);

            a -= 10;
            Console.WriteLine("a -= 10 = " + a);

            a *= 10;
            Console.WriteLine("a *= 10 = " + a);

            a /= 10;
            Console.WriteLine("a /= 10 = " + (float)a);

            a %= 10;
            Console.WriteLine("a %= 10 = " + (float)a);
        }
        public void OperatorPerbandingan()
        {
            int mangga, apel = 0;

            Console.Write("Jumlah mangga = ");
            //Error Handling
            if (int.TryParse(Console.ReadLine(), out mangga))
            {
                Console.Write("Jumlah Apel = ");

                //Error Handling
                if (int.TryParse(Console.ReadLine(), out apel))
                {
                    Console.WriteLine("Hasil Perbandingan");
                    Console.WriteLine($"Mangga > Apel? {mangga > apel}");
                    Console.WriteLine($"Mangga >= Apel? {mangga >= apel}");
                    Console.WriteLine($"Mangga < Apel? {mangga < apel}");
                    Console.WriteLine($"Mangga <= Apel? {mangga <= apel}");
                    Console.WriteLine($"Mangga == Apel? {mangga == apel}");
                    Console.WriteLine($"Mangga != Apel? {mangga != apel}");
                }
                else
                {
                    Console.WriteLine("Masukkan Angka");
                }
            }
            else
            {
                Console.WriteLine("Masukkan Angka");
            }
        }
        public void OperatorLogika()
        {
            int age;
            string password;
            bool isAdult, isPasswordValid;

            Console.Write("Masukan Usia = ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Password = ");
            password = Console.ReadLine();

            isAdult = (age > 18);
            isPasswordValid = (password == "admin");

            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE JUNGLE");
            }
            else
            {
                Console.WriteLine("Please try again");
                Console.ReadLine();
                Console.Clear();
                OperatorLogika();
            }
        }
        public int FungsiPenjumlahan1(int angka1, int angka2)
        {
            return (angka1 + angka2);
        }
        public int FungsiPenjumlahan2(int angka1, int angka2) => (angka1 + angka2);

        public void FungsiKondisi()
        {
            int x = 10;
            

            if (x == 10)
            {
                Console.WriteLine("X value equals to 10");
            }
            else if (x > 10)
            {
                Console.WriteLine("x value is greater than 10");
            }
            else
            {
                Console.WriteLine("x value is less than 10");
            }
        }
        public string NilaiHuruf(int hasilNilai)
        {
            //Console.Write("Masukan Nilainya = ");
            //hasilNilai = int.Parse(Console.ReadLine());

            if (hasilNilai >= 80 && hasilNilai <= 100)
            {
                return  "A";
            }
            else if (hasilNilai >= 60 && hasilNilai <= 79)
            {
                return "B";
            }
            else if (hasilNilai >= 50 && hasilNilai <= 59)
            {
                return  "C";
            }
            else if (hasilNilai >= 30 && hasilNilai <= 49)
            {
                return  "D";
            }
            else if (hasilNilai >= 0 && hasilNilai <= 29)
            {
                return  "E";
            }
            else
            {
                return  "Undefined";
            }
        }
        public string StatusKelulusan(string nilaiHuruf)
        {
            switch (nilaiHuruf)
            {
                case "A": return "Lulus Sempurna";
                case "B": return "Lulus";
                case "C": return "Lulus tapi pas-pasan";
                case "D": return "Lulus tapi perlu extend";
                case "E": return "Silahkan mengulang kembali";
                default: return "Nilai tidak ditemukan";
            }
        }
        public void Menu()
        {
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    OperatorAritmatika();
                    Console.Clear();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    OperatorPenugasan();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    OperatorPerbandingan();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine();
                    OperatorLogika();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine();
                    FungsiKondisi();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine();
                    Console.Write("Masukkan Nilai: ");
                    string nilaiHuruf = NilaiHuruf(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Indeks hasil: " + (nilaiHuruf));
                    Console.WriteLine("Hasil Kelulusan: " + (StatusKelulusan(nilaiHuruf)));
                    break;
                default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        public void PilihanMenu()
        {
            Console.WriteLine("=".PadRight(25, '='));
            Console.WriteLine("1. Operator Aritmatika");
            Console.WriteLine("2. Operator Penugasan");
            Console.WriteLine("3. Operator Perbandingan");
            Console.WriteLine("4. Operator Logika");
            Console.WriteLine("5. Fungsi Kondisi");
            Console.WriteLine("6. Indeks Nilai");
            Console.WriteLine("=".PadRight(25, '='));
            Console.WriteLine("Press any key to Back");
        }
    }
}