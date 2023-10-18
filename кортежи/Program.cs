using System;

namespace кортежи
{//чтобы дать название элементам кортежа надо: перед элеметом написать его имя (:) пример var tuople(count:5,num:3);
    class Program
    {
        static void Main(string[] args)
        {//тип кортежа можно задать  2 способами
            /*первый*/
            var tuole = (5, 10);//для кортежа соответствует переменная var и внутри скобок записываются элементы кортежа
            /*второй*/
            (int, int) tuole2 = (7, 3);
            Console.WriteLine(tuole.Item1);//для выводна на кансоль элементов кортежа нам нужно указать название самого кортежа и корядковый  комер эелемента через Item1(2)
            tuole.Item2 += 20;
            Console.WriteLine(tuole.Item2);

            Console.WriteLine(tuole2.Item1);
            tuole2.Item2 += 20;
            Console.WriteLine(tuole2.Item2);
            //можем для каждого элемента кортежа определить собственные переменные
            var (name, age) = ("Tom", 25);
            Console.WriteLine($"{ name }={ age }");
            //кортеджи полезны при возвращение методом некоторого значения
            var tuole3 = GetValue();
            Console.WriteLine(tuole3.Item1);
            Console.WriteLine(tuole3.Item2);
            //можно через кортеж задавать значение для метода
            var tuple5=GetValue2(("Bob",50),10);
            Console.WriteLine(tuple5);

            Console.ReadKey();
        }
        static (int,int) GetValue()//тобы вернуть значение то мы указываем картеж в самом методе рядои с названием
        {
            int result1 = 1;
            int result2 = 3;
            return (result1, result2);

        }
        static (string , int) GetValue2((string, int) tuple4, int x)
        {
            var result = (name: tuple4.Item1, age: tuple4.Item2 + x);
            return result;
        }
    }
}
