using System;
using System.Linq;

namespace лабораторная_задача1
{
    class Program
    {


        static void Main(string[] args)
        {


            try
            {

                Console.WriteLine("Ввидите все элементы массива через пробел");



                int[] Number = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();



                for (int i = 0; i < Number.Length; i++)
                {
                    Console.Write($" {Number[i]} ");
                }










                Console.WriteLine("введите режим a или режим b");
                string text = Console.ReadLine();
                string k = Convert.ToString(text);//задание  с выбором режима





                switch (k)//в каждое значение записать класс с методом 
                {
                    case "a"://по возврастанию ставит
                        Console.WriteLine($"режим 1 активирован:\t");

                        int currentMin = int.MinValue;
                        for (int i = 0; i < Number.Length; i++)
                        {
                            int current = int.MaxValue;
                            int minCount = 0;
                            for (int j = 0; j < Number.Length; j++)
                            {
                                if (Number[j] < current && Number[j] > currentMin)
                                {
                                    current = Number[j];
                                    minCount = 0;
                                }
                                if (Number[j] == current)
                                    minCount++;
                            }
                            while (minCount-- > 0)
                                Console.Write($"{current}\t");
                            currentMin = current;
                        }
                        break;
                    case "b"://по убыванию ставит
                        Console.WriteLine($"режим 2 активирован:\t");
                        int currentMax = int.MaxValue;
                        for (int i = 0; i < Number.Length; i++)
                        {
                            int current = int.MinValue;
                            int minCount = 0;
                            for (int j = 0; j < Number.Length; j++)
                            {
                                if (Number[j] > current && Number[j] < currentMax)
                                {
                                    current = Number[j];
                                    minCount = 0;
                                }
                                if (Number[j] == current)
                                    minCount++;
                            }
                            while (minCount-- > 0)
                                Console.Write($"{current}\t");
                            currentMax = current;
                        }

                        break;
                    default:
                        Console.WriteLine($"Режим не выбран, заканчиваю работу…\t");
                        break;



                }
                Console.WriteLine("\r\r\r\n");
                int[] Number2 = Number;
                for (int i = 0; i < Number2.Length; i++)
                {
                    if (Number2[i] % 2 == 0)
                    {
                        Console.Write($"{Number2[i]}\t");
                    }
                }
            }

            catch (ArgumentNullException) 
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }
            catch (FormatException )
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }
            catch (OverflowException )
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }




        }




    }
}



