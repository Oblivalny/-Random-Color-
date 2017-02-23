using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_2
{
    class Program
    {

        static int[] Заполнение_массива(int[] arr)//Рандомное заполение массива !
        {
            Random x = new Random();

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = x.Next(100);
            }
            return arr;
        }

        static void Вывод_массива(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Элимент №{0}: {1}",i,arr[i]);
            }

        }
        
        static void Main(string[] args)
        {

            

            int n = 0 ;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Заполнение_массива(arr);
            Вывод_массива(arr);
            Console.ReadLine();

        }
    }
}
