using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Day_07
    {
        private void RandomNumber()
        {
            Random rnd = new Random();
            Console.WriteLine("Angka Random yang dihasilkan: {0:N0}", rnd.Next());
        }

        private void RandomNumberWithRange()
        {
            Guid guid = Guid.NewGuid();
            Random rnd = new Random();
            Console.WriteLine("Angka Random yang dihasilkan antara 18-40: {0:N0}", rnd.Next(18, 40));
        }

        private void RandomWithGUID()
        {
            Guid guid = Guid.NewGuid();
            Console.WriteLine("Angka Random yang dihasilkan GUID: {0}", guid);
        }

    }
}
