using System;

namespace массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 3, 4, 5, 7, 8, 9 };
            foreach (int i in num)//позволяет сразу запихнуть в одну переменную все эелементы массива
            { 
                Console.WriteLine(i);
            }
            /*for(int i=0;i<num.Length ;i++)
            {
                Console.WriteLine(num[i]);
            }можно использовать этот метод записи цикла */
            /*int a = num.Length;
           while(a>0) цикл вайл
            {
                Console.WriteLine(a);
                
                a--;
                    }*/
            Console.ReadKey();
            
        }
    }
}
