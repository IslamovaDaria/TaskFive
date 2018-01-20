using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskFive
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("input.txt");
            string buf = f.ReadLine();
            int size = Convert.ToInt32(buf);
            string[][] buf_arr = new string[size][];
            string s;
            int i = -1;
                        while ((s = f.ReadLine()) != null)
                buf_arr[++i] = s.Split(' ');
            f.Close();

            double[,] arr = new double[size, size];
                        for (int j = 0; j < size; j++)
                                for (int k = 0; k < buf_arr[j].Length; k++)
                arr[j,k] = Convert.ToDouble(buf_arr[j][k]);

            Print(arr);

            double max = -100000000000000;
            for (int k = size / 2; k >= 0; k--)
                for (int j = size - k - 1; j >= k; j--)
                    if (arr[j, k] > max)
                        max = arr[j, k];
            Console.WriteLine("Наибольший элемент в области: {0}", max);

            Console.ReadLine();
        }

        static void Print(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
