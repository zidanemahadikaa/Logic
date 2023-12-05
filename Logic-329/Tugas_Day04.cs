using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day04
    {
        public void SplitString()
        {
            string kata = "aku bisa belajar c#";
            string[] arrayKata = kata.Split(' ');
            for (int i = 0; i < arrayKata.Length; i++)
            {
                Console.WriteLine($"Kata {i+1} =  {arrayKata[i]}");
            }
            Console.WriteLine($"Total kata = {arrayKata.Length}");
            Console.WriteLine();
            CheckCharacter();
            GantiKata();
            GantiKata2();
            HilangKata();
        }
        public void CheckCharacter()
        {
            string kata = "aku puNya BUKU";
            Console.WriteLine($"Kata = {kata}");
            int jumlahU = 0, jumlahKapital = 0;

            for (int i = 0; i < kata.Length; i++) 
            {
                if (kata[i] == 'u' || kata[i] == 'U') { jumlahU++; }
                if (char.IsUpper(kata[i])) { jumlahKapital++; }
            }
            Console.WriteLine($"Huruf U ada {jumlahU}");
            Console.WriteLine($"Huruf Kapital ada {jumlahKapital}");

            jumlahU = 0;
            jumlahKapital = 0;
            foreach (char c in kata)
            {
                jumlahU = (c == 'u' || c == 'U') ? jumlahU + 1: jumlahU + 0;
                jumlahKapital = (char.IsUpper(c)) ? jumlahKapital + 1 : jumlahKapital + 0;
            }
            Console.WriteLine($"Huruf U ada {jumlahU}");
            Console.WriteLine($"Huruf Kapital ada {jumlahKapital}");
        }
        public void GantiKata()
        {
            string kata = "Aku Sayang Kamu";
            string[] kata2 = kata.Split(' ');
            Console.WriteLine();
            foreach (string a in kata2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i != 0 && i < a.Length - 1)
                        Console.Write("*");
                    else Console.Write(a[i]);           
                }
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        public void GantiKata2()
        {
            string kata = "Aku Mau Makan";
            string[] kata2 = kata.Split(' ');
            foreach (string a in kata2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == 0 || i == a.Length - 1)
                        Console.Write("*");
                    else Console.Write(a[i]);
                }
                Console.Write (' ');
            }
            Console.WriteLine();
        }
        public void HilangKata()
        {
            string kataBaru = "";
            string[] kata = "Saya pasti bisa".Split(' ');
            //foreach (string a in kata)
            //{
            //    //for (int i = 0; i < a.Length; i++)
            //    //{
            //    //    if (i >=  a.Length - 3)
            //    //        Console.Write(a[i]);
            //    //    else Console.Write("");
            //    //}
            //    //Console.Write(a.Substring(a.Length - 3));
            //    //Console.Write(' ');
            //}
            kataBaru = string.Join(", ", kata);

            Console.WriteLine(kata);
            Console.WriteLine(kataBaru.Trim());
        }
    }
}
