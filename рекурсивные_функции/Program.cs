using System;

namespace рекурсивные_функции
{
    class Program
    {// рекурсивные функции(методы),те функции(методы),которые вызывают сами себя
       
    
        static int Factorial(int n)//вычисление факториала 
        {/*  фактриал считается так: 5!=1*2*3*4*5=120;
          *   на функции это выгладеть так:
          *   Factorial(5)=5*Factorial(4)=5*4*Factorial(3)...=5*4*3*2*1*Factorial(0)=120*/
            if (n == 0)//надо определить базовый вариант, к которому сходится функция 
            

                return 1;
            
            else
            
                return n * Factorial(n - 1);
            
        }
        //передставим через сумму фибаначи(число равно сумме двух предыдущих чисел)
        //f(n)=f(n-1)+f(n-2)
        //1,1,2,3,5,8,13,21...
        static int Fibanachi(int k)
        {
            if (k == 0)
                return 0;
            if (k == 1)
                return 1;
            else
                return Fibanachi(k - 1) + Fibanachi(k - 2);

        }


        static void Main(string[] args)

        {
            Console.WriteLine("введите  первое число");
            string number = Console.ReadLine();
            int n = Convert.ToInt32(number);
            Console.WriteLine("введите второе  число");
            string number2 = Console.ReadLine();
            int k = Convert.ToInt32(number2);

            int c = Fibanachi(k);
            int x = Factorial(n);
            Console.WriteLine($"Factorial({n})={x}");
            Console.WriteLine($"Fibanachi({k})={c}");
            Console.ReadKey();

        }
    }
}
