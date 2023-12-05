using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_08
    {
        public async Task ProsesAsync()
        {
            Console.WriteLine("Test Loop 1M: ");
            await TestLoop100();
            Console.WriteLine("Test Loop 100");
            await TestLoop1000();
            Console.WriteLine();
        }
        private async Task<byte> TestLoop100()
        {
            byte nilai = 0;
            for (int i = 0; i < 1000; i++)
            {
                nilai++;
            }
            return nilai;
            //Console.WriteLine($"Nilai akhir : {nilai}");
        }
        private async Task<int> TestLoop1000()
        {
            int nilai = 0;
            for (int i = 0; i < 100; i++)
            {
                nilai++;
            }
            return nilai;
            //Console.WriteLine($"Nilai akhir : {nilai}");
        }
    }
}
