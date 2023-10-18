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


                //int[] Number = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                int[] Number = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                int maxNumber = Number[0];
                int IndexNumber = 0;
                int minNumber = Number[0];
                int IndexNumber2 = 0;

                for (int i = 0; i < Number.Length; i++)
                {
                    Console.Write($"{Number[i]} ");//вывод всех элеменов массива


                }

                Console.WriteLine("\n");//максимальный элемент
                for (int i = 1; i < Number.Length; i++)
                {
                    if (Number[i] > maxNumber)
                    {
                        maxNumber = Number[i];
                        IndexNumber = i;
                    }

                }
                Console.WriteLine($"{IndexNumber } {maxNumber}");
                for (int j = 1; j < Number.Length; j++)
                {
                    if (Number[j] < minNumber)//минимальный элемент
                    {
                        minNumber = Number[j];
                        IndexNumber2 = j;
                    }

                }
                Console.WriteLine($"{IndexNumber2 } {minNumber}");






                Console.WriteLine("\nвведите режим a или режим b");
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
                                Console.Write($"{current} ");
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
                                Console.Write($"{current} ");
                            currentMax = current;
                        }

                        break;
                    default:
                        Console.WriteLine($"Режим не выбран, заканчиваю работу…");
                        break;



                }
                Console.WriteLine();
                int[] Number2 = Number;//четные элементы массива
                for (int i = 0; i < Number2.Length; i++)
                {
                    if (Number2[i] % 2 == 0)
                    {
                        Console.Write($"{Number2[i]} ");
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }




        }




    }
}




