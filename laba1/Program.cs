using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /*
            Console.WriteLine("Input x : ");
            int x = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Input z : ");
            int z = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToDouble( x - (z / (z - ((Math.Pow(x, 2) / 4))))) - ((Math.Pow(x, 2)) / (1*2*3*4*5));
            Console.WriteLine(y);
            */


            //Task 2
            // квадратна матриця (n x n)
            // [n1, n2, n3]
            // [n4, n5, n6]
            // [n7, n8, n9]
            // обчислити суму n1 + n2 + n3 + n5 + n6 + n9 !> n1 + n5 + n9 + n4 + n7 + n8
            // якщо сума n1 + n2 + n3 + n5 + n6 + n9 < n1 + n5 + n9 + n4 + n7 + n8 то вивести повідомлення відповідне
            /*
            Console.Write("Input size of matrix (n): ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, n];

            Console.WriteLine("Input elements of matrix:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            double sumAboveDiagonal = 0;
            double sumBelowDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        sumAboveDiagonal += matrix[i, j];
                    }
                    else
                    {
                        sumBelowDiagonal += matrix[i, j];
                    }
                }
            }

            if (sumAboveDiagonal <= sumBelowDiagonal)
            { 
                Console.WriteLine($"Сума елементiв на головнiй дiагоналi та вище вiд неї не перевищує суму елементiв нижче головної дiагоналi.");
                Console.WriteLine($"Сума на головнiй дiагоналi та вище вiд неї: {sumAboveDiagonal}");
                Console.WriteLine($"Сума елементiв нижче головної дiагоналi: {sumBelowDiagonal}");
            }
            else
            {
                Console.WriteLine($"Сума елементів на головнiй дiагоналi та вище вiд неї перевищує суму елементiв нижче головної дiагоналi.");
            }
            */


            //Task 3
            // n - натуральне число(1,2,3,4...)
            // a - цілі числа a1 ... a(n)
            // відрізок послідовності a1 ... a(n)
            
            List<int> arr = new List<int> { 5, 25, 2, 125, 625, 3, 4, 5, 25, 125, 1, 5, 25, 125, 625, 125 };
            List<int> result = FindPowerOfFiveSegments(arr);

            Console.WriteLine("Найбiльший вiдрiзок ступенiв п'ятiрки:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
            

        }
        static List<int> FindPowerOfFiveSegments(List<int> arr)
        {
            List<int> maxSegment = new List<int>();
            List<int> currentSegment = new List<int>();

            foreach (int num in arr)
            {
                if (IsPowerOfFive(num))
                {
                    currentSegment.Add(num);
                }
                else
                {
                    if (currentSegment.Count > maxSegment.Count)
                    {
                        maxSegment = new List<int>(currentSegment);
                    }
                    currentSegment.Clear();
                }
            }

            if (currentSegment.Count > maxSegment.Count)
            {
                maxSegment = new List<int>(currentSegment);
            }

            return maxSegment;
        }

        static bool IsPowerOfFive(int num)
        {
            while (num > 1)
            {
                if (num % 5 != 0)
                {
                    return false;
                }
                num /= 5;
            }

            return num == 1;
        }

    }
}
