﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 1. Сгенерировать 10 случайных чисел от -8 до 9

            Random r = new Random();
            int i = 0;
            while ( i < 10)
            {
                Console.Write($"{r.Next(-8, 10)} ");
                i++;
            }

            Console.ReadKey();
        }
    }
}
