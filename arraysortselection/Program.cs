using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortselection
{
    internal class Program
    {
        static int[] Selection(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                int d = array[i];
                array[i] = array[min];
                array[min] = d;
                min = i;
            }   
        return array;
        }
    
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Selection(array);

            Console.WriteLine();
            Console.WriteLine("Массив после сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
