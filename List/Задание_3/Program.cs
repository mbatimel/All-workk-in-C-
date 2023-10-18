using System;
using System.Collections.Generic;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Добавьте число");
            while(true)
            {
                int number =Convert.ToInt32(Console.ReadLine());
                if(set.Contains(number) == true)
                {
                    Console.WriteLine("данное число уже имеется");

                }
                if (set.Contains(number) == false)
                {
                    Console.WriteLine("Число успешно сохранено");
                    set.Add(number);
                }
            }
        }
    }
}
