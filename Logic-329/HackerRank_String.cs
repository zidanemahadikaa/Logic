using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class HackerRank_String
    {
        public static int minimumNumber(int n, string password)
        {
            char[] number = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] lower_case = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upper_case = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] special_characters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+' };

            int hasil = 0;
            if (password.IndexOfAny(number) == -1)
            {
                hasil++;
            }
            if (password.IndexOfAny(lower_case) == -1)
            {
                hasil++;
            }
            if (password.IndexOfAny(upper_case) == -1)
            {
                hasil++;
            }
            if (password.IndexOfAny(special_characters) == -1)
            {
                hasil++;
            }

            return hasil > 6 - n ? hasil : 6 - n;
        }
    }
}
