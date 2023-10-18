using System;
using System.Linq;

namespace лабораторная_задача1
{
    public class Namber3
    {


        public static int Aliments { get; protected set; }

        public static int[] Massiv()
        {
           

            Console.WriteLine("Ввидите все элементы массива через пробел");
            
            
                int[] Number = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

           
            
                for (int i = 0; i < Number.Length; i++)
                {
                    Console.Write($" {Number[i]} ");
                }
           
            return Number;
        }

        




    }
}




