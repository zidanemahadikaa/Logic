using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_06
    {
        public void ErrorHandling()
        {
            try
            {
                int angka;
                Console.Clear();

                Console.WriteLine("Masukkan sebuah bilangan bulat (0 untuk berhenti): ");
                angka = int.Parse(Console.ReadLine());

                if (angka == 0)
                {
                    Console.WriteLine("Selamat Jalan .... ");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine($"Bilangan yang dimasukkan adalah bilangan bulat {angka} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tekan Enter untuk melanjutkan....");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Finally....");
                Console.ReadLine();
            }
            ErrorHandling();
        }
    }
}
