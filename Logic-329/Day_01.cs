using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    public class Day_01
    {
        private string nama;
        private string alamat;
        private int umur, hasil;
        public void Main()
        {
            //inputBiodata();
            //Console.WriteLine();
            //outputBiodata();
        }
        public void inputBiodata()
        {
            Console.Write("Nama: ");
            nama = Console.ReadLine();
            Console.Write("Alamat: ");
            alamat = Console.ReadLine();
            Console.Write("Umur: ");
            umur = int.Parse(Console.ReadLine());
            Console.Clear();
            Menu();
        }
        public void outputBiodata()
        {
            //Console.WriteLine("=== BIODATA SAYA ===");
            //Console.Write("Nama: ");
            //Console.Write(nama);
            //Console.WriteLine();
            //Console.WriteLine("Alamat: " + alamat + "\n");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur}");
            hasil = umur + 10;
            Console.WriteLine($"Umur di 10 tahun kedepan: {hasil}");
        }
        public void DataTypeConvertion()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            char myChar = '1';

            int yourInt;
            double yourDouble;
            bool yourBool;
            char yourChar;

            Console.WriteLine($"myInt = {myInt}");
            Console.WriteLine($"myDouble = {myDouble}");
            Console.WriteLine($"myBool = {myBool}");
            Console.WriteLine($"myChar = {myChar}");

            //yourInt = Convert.ToInt32(myDouble);
            //yourDouble = Convert.ToDouble(myInt);
            //yourBool = Convert.ToBoolean(0);

            yourInt = (int)myDouble;
            yourDouble = (double)myInt;
            yourBool = Convert.ToBoolean(0);
            yourChar = myChar;

            Console.WriteLine($"yourInt = {yourInt}");
            Console.WriteLine($"yourDouble = {yourDouble}");
            Console.WriteLine($"yourBool = {yourBool}");
            Console.WriteLine($"yourChar = {yourChar}");
        }
        public void Menu()
        {
            PilihanMenu();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    inputBiodata();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    outputBiodata();
                    Program.Pause();
                    Menu();
                    break; 
                case ConsoleKey.D3:
                    Console.Clear();
                    DataTypeConvertion();
                    Program.Pause();
                    Menu();
                    break;
                case ConsoleKey.D0:
                    Console.Clear();
                    Program.Menu();
                    Program.Pause();
                    break;
                default:
                    Console.Clear();
                    Program.Menu();
                    break;
            }
        }
        private void PilihanMenu()
        {
            Console.WriteLine("=" .PadRight(25, '='));
            Console.WriteLine("1. Input Biodata");
            Console.WriteLine("2. Output Biodata");
            Console.WriteLine("3. Data Type Convertion");
            Console.WriteLine("0. Kembali");
            Console.WriteLine("=".PadRight(25, '='));

        }
    }
}
