using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class Tugas_Day06
    {
        public void LembahGunung()
        {
            int input = 0;
            string kata = "";
            int d = 0;

            Console.WriteLine("Masukkan input: ");
            kata = Console.ReadLine().ToLower();

            foreach(char c in kata)
            {
                if (c == 'd')
                {
                    input -= 1;
                }
                else if (c == 'u')
                {
                    input += 1;
                }
                if (input == 0 && c == 'u')
                {
                    d++;
                }
            }
            Console.WriteLine(d);

        }
        public void PasswordEncryption()
        {
            //List<string> kata = new List<string>();
            //string arr = "abcdefghijklmnopqrstuvwxyz";
            ////char[] kata = arr.ToCharArray();
            //int rot = 3;
            //foreach (char a in arr)
            //{
            //    //    Console.Write($"{a}");
            //    //    for (int i = 0; i < rot; i++)
            //    //    {
            //    //        kata.Add(a.ToString());
            //    //    //    arr.IndexOf(kata[0]);
            //    //    //    Console.Write("Setelah Dienkripsi: {0}", kata[i]);
            //    //    }
            //    //    Console.WriteLine(string.Join(", ",  kata));
            //    //}

            //    for (int i = 0; i < rot; i++)
            //    {
            //        kata.Add(kata[0]);
            //        kata.RemoveAt(0);
            //        Console.WriteLine("Output {0}: {1}", i + 1, string.Join("", kata));
            //    }
            //}
            //int n = int.Parse(Console.ReadLine());
            //String input = Console.ReadLine();
            //int k = int.Parse(Console.ReadLine());

            //List<int> builder = new List<int>(input.length());
            //for (int i = 0; i < n; i++)
            //{
            //    char temp = input.charAt(i);
            //    boolean upperCase = Character.isUpperCase(temp);
            //    if (Character.isLetter(temp))
            //    {
            //        temp += k % 26;
            //        if (!Character.isLetter(temp) || (upperCase && !Character.isUpperCase(temp)))
            //        {
            //            temp -= 26;
            //        }
            //    }
            //    builder.append(temp);
            //}

            //System.out.println(builder.toString());
        }
        public void ElementTinggi()
        {
            string panjang = "1 3 1 4 6 2 1 1 3 5 2 3 1 1 1 1 5 2 3 1 3 5 4 3 2 5";
            string[] tinggi = panjang.Split(' ');
            string huruf = "abcdefghijklmnopqrstuvwxyz";
            
            int idxTertinggi = 0;

            Console.Write("Masukkan kata: ");
            string input = Console.ReadLine().ToLower();
            

            foreach(char s in input)
            {
                if (char.IsLetter(s))
                {
                    if (int.Parse(tinggi[huruf.IndexOf(s)]) > idxTertinggi)
                    {
                        idxTertinggi = int.Parse(tinggi[huruf.IndexOf(s)]);
                    }
                }
            }
            Console.WriteLine(idxTertinggi);
            Console.WriteLine(input.Length);
            Console.WriteLine($"{idxTertinggi}x{input.Length}: {idxTertinggi * input.Length}");
        }
        public void VokalKonsonan()
        {
            string input = "";
            string vokal = "";
            string konsonan = "";

            Console.WriteLine("Masukkan kata: ");
            input = Console.ReadLine().ToLower();
            char[] arrayKata = input.ToCharArray();
            Array.Sort(arrayKata); 

            foreach (char c in arrayKata)
            {
                if (c == 'a' || c == 'e' || 
                    c == 'i' || c == 'o' || 
                    c == 'u')
                {
                    vokal += c;
                }
                else
                {
                    konsonan += c;
                }
            }
            Console.WriteLine(vokal.Trim());
            Console.WriteLine(konsonan.Trim());

            Console.WriteLine();
            Console.WriteLine("====================");
            konsonan = "aiueo";
            bool isKonsonan = false;

            isKonsonan = !konsonan.Any(a => input.Any(i => a == i));


        }
        public void KataSandi()
        {
            string password;
            string simbol = "!@#$%^&*()-+";
            string huruf = "abcdefghijklmnopqrstuvwxyz";
            string kapital = huruf.ToUpper();
            string angka = "1234567890";

            bool isKurangAngka = false, isKurangHurufBesar = false,
                isKurangHurufKecil = false, isKurangSimbol = false, 
                isKurangPanjang = false;

            try
            {
                Console.Clear();
                Console.Write("Masukkan Password anda: ");
                password = Console.ReadLine();

                isKurangPanjang = (password.Length < 6);
                isKurangAngka = !angka.Any(a => password.Any(p => a == p));
                isKurangHurufBesar = !kapital.Any(a => password.Any(p => a == p));
                isKurangHurufKecil = !huruf.Any(a => password.Any(p => a == p));
                isKurangSimbol = !simbol.Any(a => password.Any(p => a == p));

                if (isKurangAngka || isKurangHurufBesar || isKurangHurufKecil || isKurangSimbol || isKurangPanjang)
                {
                    Console.WriteLine(
                        "PassWord Weak"
                        + (isKurangPanjang ? " & Kurang dari 6 digit" : "")
                        + (isKurangHurufBesar ? "& Kurang Huruf Besar" : "")
                        + (isKurangHurufKecil ? "& Kurang Huruf Kecil" : "")
                        + (isKurangSimbol ? "& kurang simbol" : "")
                        + (isKurangAngka ? "& kurang Angka" : ""));
                }
                else
                {
                    Console.WriteLine("Password Strong!!!");
                }
            } catch(Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: {0}", ex.Message);
                Console.WriteLine("Silahkan Coba lagi ... ");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
