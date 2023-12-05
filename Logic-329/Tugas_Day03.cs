using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day03
    {
        public void PohonFaktor()
        {
            int angka = 0;
            int hasil = 0;
            Console.Write("Masukkan Angka = ");
            angka = int.Parse(Console.ReadLine());
            for (int i = 0; i <= angka; i++)
            {
                if (angka % i == 0)
                {
                    hasil = angka / i;
                    Console.WriteLine($"{angka} / {i} = {hasil}");
                }
            }
        }
    }
}
