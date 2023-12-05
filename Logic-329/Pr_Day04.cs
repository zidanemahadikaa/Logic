using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Pr_Day04
    {
        public void Palindrome()
        {
            string kata;

            Console.Write("Masukkan kata: ");
            kata = Console.ReadLine();

            char[] inputArray = kata.ToCharArray();
            Array.Reverse(inputArray);
            string outputArray = new string(inputArray);

            Console.WriteLine(outputArray);
            if (outputArray == kata) { Console.WriteLine("OK");  }
            else if(outputArray != kata) { Console.WriteLine("NO");  }
            Console.WriteLine();
            Console.WriteLine("=====================");

            Console.Write("Masukkan kata: ");
            kata = Console.ReadLine();
            string reverse = "";

            for (int i = kata.Length - 1; i >= 0; i--)
            {
                reverse = reverse + kata[i];
            }

            if (kata.ToLower() == reverse.ToLower())
            {
                Console.WriteLine($"{kata} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{kata} is not Palindrome");
            }

            //int depan = 0;
            //int belakang = kata.Length - 1;

            //char a = kata[belakang];
            //char b = kata[depan];

            //kata = (a == b) ? "Palindrome" : "Bukan Palindrome";
            //Console.WriteLine(kata);
        }
        public void Belanja()
        {
            //int uang;
            //int baju = 0;
            //int celana = 0;
            //int total = 0;


            //35,40,50,20
            //40,30,45,10


            //Console.Write("Uang Andi: ");
            //uang = int.Parse(Console.ReadLine());

            //if (uang >= 95) { baju = 50; celana = 45; }
            //else if (uang >= 90) { baju = 50; celana = 40; }
            //else if (uang >= 85) { baju = 40; celana = 45; }
            //else if (uang >= 80) { baju = 40; celana = 40; }
            //else if (uang >= 75) { baju = 35; celana = 40; }
            //else if (uang >= 70) { baju = 40; celana = 30; }
            //else if (uang >= 60) { baju = 50; celana = 10; }
            //else if (uang >= 10) { baju = 20; celana = 10; }

            //total = baju + celana;
            //Console.WriteLine($"{baju} + {celana} = {total}");
            
            int baju, celana, uang, jumlah;

            Console.Write("Masukkan uang: ");
            uang = int.Parse(Console.ReadLine());

            Console.Write("Masukan jumlah baju dan celana: ");
            jumlah = int.Parse(Console.ReadLine());
            int[] hargaBaju = new int[jumlah];
            int[] hargaCelana = new int[jumlah];
            int[] total = new int[jumlah];
            int[] selisih = new int[jumlah];


            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"Harga Baju ke- {i + 1} ");
                hargaBaju[i] = int.Parse(Console.ReadLine());
                Console.Write($"Harga Celana ke- {i + 1} ");
                hargaCelana[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < jumlah; i++)
            {
                total[i] = hargaBaju[i] + hargaCelana[i];
                //if (total[i] < uang)
                //{
                //    selisih[i] = uang - total[i];
                //}
                //else
                //{
                //    selisih[i] = total[i];
                //}
                selisih[i] = (total[i] < uang)? uang - total[i] : total[i];
            }
            Array.Sort(selisih);
            Console.WriteLine("{0}", uang - selisih[0]);
            //for (int i = 0; i < baju.Length; i++) 
            //{
            //    total[i] = baju[i] + celana[i];

            //    Console.Write($"{baju[i]} + {celana[i]}  = {total[i]}");
            //    Console.WriteLine(); 
            //
        }
    }
}
