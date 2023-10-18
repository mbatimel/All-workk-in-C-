using System;
using System.Linq;

namespace classworkSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число к");
            string text = Console.ReadLine();
            float k = Convert.ToSingle(text);
            if (k > 1 && k < 0)
            {
                throw new Exception("к не принадлежит диапозону ");
            }
            float[] Number = Console.ReadLine().Split().Select(x => float.Parse(x)).ToArray();
            {
                for (int i = 0; i < Number.Length; i++)
                {
                    Number[i] = (float)Math.Sqrt(Number[i] * (i + 1) * k);
                    Console.Write($"{Number[i]} ");
                }
            }
            Console.ReadKey();
        }
        
       
    }
}
