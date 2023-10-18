using System;

namespace Skillbox2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maxvelue = 1000000000;
            Console.WriteLine("Введите количество элементов массиве");
            int count = int.Parse(Console.ReadLine());
            int[] newarray = new int[count];
            for (int i = 0; i < newarray.Length; i++) 
            {
                Console.WriteLine($"Введите число для {i + 1} элемента массива");
                newarray[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<newarray.Length;i++)
            {
                if (newarray[i]<Maxvelue)
                {
                    Maxvelue = newarray[i];
                }
            }
            Console.WriteLine($"Минимальное число равняется={Maxvelue}");
            
        }
    }
}
