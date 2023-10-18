using System;
using System.Linq;

namespace _3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {//ввод массива
                Console.WriteLine("введите количество строк массива");
                string text = Console.ReadLine();
                int x = Convert.ToInt32(text);
                int[][] Array = new int[x][];
                Random random = new Random();
                for (int i = 0; i < Array.Length; i++)
                {

                    Console.WriteLine($"Введите строку элементов:{i + 1}");

                    Array[i] = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

                }
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array[i].Length; j++)
                    {
                        Console.Write($"{Array[i][j]}  ");
                    }
                    Console.WriteLine();
                }
                //нахождение Max and Min
                int MaxElement = Array[0][0];
                int MaxIndex1 = 0;
                int MaxIndex2 = 0;
                int MinElement = Array[0][0]; ;
                int MinIndex1 = 0;
                int MinIndex2 = 0;

                Console.WriteLine();
                Console.WriteLine();
                //нахождение максимального элемента
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array[i].Length; j++)
                    {
                        MaxElement = Array[0][0];
                        if (MaxElement < Array[i][j])
                        {
                            MaxElement = Array[i][j];
                            MaxIndex1 = i;
                            MaxIndex2 = j;
                        }
                    }

                }
                Console.WriteLine($"максимальный эдемент массива:{MaxIndex1} {MaxIndex2}-{MaxElement} ");
                Console.WriteLine();

                //нахождение минимального элемента массива
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array[i].Length; j++)
                    {
                        MaxElement = Array[0][0];
                        if (MinElement > Array[i][j])
                        {
                            MinElement = Array[i][j];
                            MinIndex1 = i;
                            MinIndex2 = j;
                        }
                    }

                }

                Console.WriteLine($"минимальный эдемент массива:{MinIndex1} {MinIndex2}-{MinElement } ");
                Console.WriteLine();

                //замена одного из элементов массива
                Console.WriteLine("Введите координаты элемента,которого хотите заменить:");
                int q = 0;
                int w = 0;
               
                int[] Element = new int[2];
                Console.WriteLine("Введите строку, в которой находится эелемент");
                Element[0] = int.Parse(Console.ReadLine());
                q = Element[0];
                Console.WriteLine("Введите столбец, в котором находится эелемент");
                Element[1] = int.Parse(Console.ReadLine());
                w = Element[0];

                Array[q][w] = random.Next();

                Console.WriteLine($"эелемент массива был изменен на {Array[q][w]}");



                //вывод обработаного массива:
                Console.Write("обработанный массив:");
                Console.WriteLine();
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array[i].Length; j++)
                    {
                        if (q == i && w == j)
                        {
                            Array[i][j] = Array[q][w];
                        }

                        Console.Write($"{Array[i][j]}  ");
                    }
                    Console.WriteLine();
                }

            }
                
         catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
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
