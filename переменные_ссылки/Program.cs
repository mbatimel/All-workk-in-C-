using System;

namespace переменные_ссылки
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref  используется чтобы указать ссылку на переменную
            //позволяет изменять значение переменной и через ссылку передавать значение переменной из другого метода

            /* int x = 10;
             ref int xRef = ref x;
             Console.WriteLine($"x={x}");
             Console.WriteLine($"xRef={xRef}");
             xRef = 125;
             Console.WriteLine($"x={x}")*/
            int[] numbers = { 12, 34, 5, 36, 57, 657, 78, 7 };
            ref int nRef = ref Find(numbers, 5);
            Console.WriteLine(numbers[2]);
            nRef = 45;
            Console.WriteLine(numbers[2]);

        }
        static ref int Find(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("число не найдено повториье попытку"); 
            

        }//основная задача была показать,что мы можем сделать ссылку между массивами,чтобы передавать,изменять значение переменноьй
        
    }
}
