﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_006
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 5. Пользователь вводит два целых числа numerator и denominator, 
            // которые являются числителем и знаменателем соответственно
            // Нужно выяснить, можно ли сократить эту дробь
            // и если можно, то на какое число
            //   50     25      5     1
            // ----- = ---- = ---- = ---
            //  100     50     10     2

            // https://ru.wikipedia.org/wiki/Наибольший_общий_делитель
            // https://ru.wikipedia.org/wiki/Алгоритм_Евклида
            // Математика 5 класс. Тема "Сокращение дробей"

            Console.Write("\nВведите numerator:");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите denominator:");
            double denominator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Исходная дробь {numerator}/{denominator}");

            double a = numerator, b = denominator;

            #region for

            //for (int i = 0; i < 100000; i++)
            //{
            //    if (a != b) if (a > b) a = a - b; else b = b - a;
            //}

            #endregion
            if (a != b)
            {
                do
                {
                    if (a > b) a = a - b; else b = b - a;

                    Console.WriteLine($">>> {a} {b}");
                } while (a != b);
            }
            Console.WriteLine($"Можно сократить на {a}");

            Console.WriteLine($"Сокращённая дробь {numerator / a}/{denominator / a}");

        }
    }
}
