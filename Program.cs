using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) нахождения минимального значения среди элементов любой строки двумерного массива;
            //б) нахождение максимального значения среди элементов любого столбца двумерного массива.
            Random rnd = new Random();
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A.GetLength(1); ++j)
                {

                    A[i, j] = rnd.Next(1, 99);
                    Console.Write(A[i, j] + "   ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine("Введите номер строки (отсчет с нуля)");
            int str = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int j = 0; j < A.GetLength(1); ++j)
            {
                if (A[str, j] < min) min = A[str, j];

            }
            Console.WriteLine("Минимальный элемент в {0} строке -> {1}", str, min);
            Console.WriteLine("Введите номер столбца (отсчет с нуля)");
            int str2 = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                if (A[i, str2] > max) max = A[i, str2];

            }
            Console.WriteLine("Максимальный элемент в {0} столбце -> {1}", str2, max);
            Console.ReadKey();

        }
    }

}
    

