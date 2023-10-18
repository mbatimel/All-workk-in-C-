using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            for(int i=0;i<100;i++)
            {
                numbers.Add(random.Next(0, 101));
            }
            Stringresult(numbers);
            Console.WriteLine("\nОбработанный массив");
            Recontructarray(numbers);
            Console.ReadLine();
        }

        /// <summary>
        /// Вывод обработанного масиива
        /// </summary>
         static void Stringresult(List<int> numbers)
        {
            foreach (var result in numbers)
            {
                Console.Write($"{result} ");
            }
        }
        /// <summary>
        /// обработка массива
        /// </summary>
        static void Recontructarray(List<int> numbers)
        { 
            numbers.RemoveAll(num=>num>50||num<25);
           Stringresult(numbers);
        }

    }
}
