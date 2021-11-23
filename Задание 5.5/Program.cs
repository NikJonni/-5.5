using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целочисленное значение:  ");
            //Random random = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = n;
            int[,] shit = new int[n, n1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    if ((i+j)%2==0)
                    {
                        shit[i, j] = 1;
                    }
                    else
                    {
                        shit[i, j] = 0;
                    }
                    Console.Write("{0,4}",shit[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
