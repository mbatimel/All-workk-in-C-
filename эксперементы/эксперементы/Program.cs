using System;
using System.Linq;

namespace эксперементы
{
    class Program
    {
        static void Main(string[] args)
        {
            {    
                int[] mas = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i]);
                }

            }
        }
    }
}

