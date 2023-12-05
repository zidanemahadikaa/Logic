using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_329
{
    internal class HackerRank
    {
        public void MiniMax()
        {
            List<int> arr = new List<int>() { 1,2,3,4,5 };
            long sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + i);
                sum += arr[i];
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < 5; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void plusMinus()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //scan.close();
            double pos = 0;
            double neg = 0;
            double zero = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > 0)
                {
                    pos = pos + 1;
                }
                else if (arr[i] < 0)
                {
                    neg = neg + 1;
                }
                else
                {
                    zero = zero + 1;
                }
            }
            //DecimalFormat df = new DecimalFormat("#.000");
            Console.WriteLine(pos / N);
            Console.WriteLine(neg / N);
            Console.WriteLine(zero / N);
        }
        public void TimeConversion()
        {
            CultureInfo timeId = new CultureInfo("id_ID");
            DateTime dateTime = new DateTime();

            dateTime = DateTime.Parse(Console.ReadLine(), timeId);
            Console.WriteLine(dateTime.ToString("HH:mm:ss", timeId));

            Console.WriteLine("\n Alternatif \n");
            string s = Console.ReadLine();
            Console.WriteLine(DateTime.Parse(s).ToString("HH:mm:ss"));
        }
        public void OneDim()
        {
            int n = 7;
            Console.WriteLine("No. 1");
            for (int i = 0; i < n + n; i++) //no1
            {
                int j = i + 1;
                if (j % 2 != 0)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("No. 2");
            for (int i = 0; i < n + n; i++)// no2
            {
                int j = i + 1;
                if (j % 2 == 0)
                {
                    Console.Write(j);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("No. 3");
            int x = 1;
            for (int i = 1; i <= n; i++)// no3
            {
                Console.Write($"{x} ");
                x = x + 3;
            }
            Console.WriteLine();
            x = 1;
            Console.WriteLine("No. 4");
            for (int i = 1; i <= n; i++)// no4
            {
                Console.Write($"{x} ");
                x = x + 4;
            }
            Console.WriteLine();
            x = 1;
            Console.WriteLine("No. 5");// no 5
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write($"{x} ");
                if (x == 5 || x == 13)
                {
                    Console.Write("* ");
                }
                x = x + 4;
            }
            Console.WriteLine();
            x = 1;
            Console.WriteLine("No. 6");
            for (int i = 0; i < n; i++)// no6
            {
                if (i == 2 || i == 5)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write($"{x} ");
                }
                x = x + 4;
            }
            Console.WriteLine();
            x = 2;
            Console.WriteLine("No. 7");
            for (int i = 0; i < n; i++)// no7
            {
                Console.Write($"{x} ");
                x = x * 2;
            }
            Console.WriteLine();
            x = 3;
            Console.WriteLine("No. 8");
            for (int i = 0; i < n; i++)// no8
            {
                Console.Write($"{x} ");
                x = x * 3;
            }
            Console.WriteLine();
            x = 4;
            Console.WriteLine("No. 9");
            for (int i = 1; i < n - 1; i++)// no9
            {
                Console.Write($"{x} ");
                x = x * 4;
                if (i == 2 || i == 4)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
            x = 3;
            Console.WriteLine("No. 10");
            for (int i = 0; i < n; i++)// no10
            {
                if (i == 3)
                {
                    Console.Write("XXX ");
                }
                else
                {
                    Console.Write($"{x} ");
                }
                x = x * 3;
            }
        }
        public void TwoDimensions()
        {

        }
        public void Fibonacci()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write("Fibonacci : " + firstNumber + " " + SecondNumber + " ");

                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
                Console.WriteLine();
                Console.Write("Fibonacci Genap: ");
                firstNumber = 0;
                SecondNumber = 1;
                nextNumber = 0;
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    if (nextNumber % 2 == 0)
                    {
                        Console.Write(nextNumber + " ");
                        firstNumber = SecondNumber;
                        SecondNumber = nextNumber;
                    }
                    else
                    {
                        firstNumber = SecondNumber;
                        SecondNumber = nextNumber;
                    }
                }

            }
        }
        public void StairCase()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; ++i)//perulangan tangga
            {
                for (int j = 1; j <= n; ++j)//perulangan penempatan tangga
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
