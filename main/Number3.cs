using System;
using System.IO;
using System.Linq;

namespace main
{
    public class Number3
    {

            public void Number_3()
        {
            try
            {
                bool cki = false;
                Console.WriteLine("Введите режим работы в каком должна работать программа(fl-считывание из файла;kb-ввод массива вручную)");
                string i = Console.ReadLine();
                do
                {

                    switch (i)
                    {
                        case "kb":
                            {
                                cki = true;
                                kb_3();
                                break;
                            }
                        case "fl":
                            {
                                cki = true;
                                fl_3();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Ввод некоректен. Попробуйте заново!");
                                i = Console.ReadLine();
                                break;
                            }

                    }

                } while (cki == false);



                static void fl_3()
                {
                    Random random = new Random();//ввод рандомной переменной,чтобы потом можно было заменить им одни из элементов массива

                    string[] FileOpened = new string[1];//получает строку из файла
                    FileOpened = File.ReadAllLines(@$"/Users/macbook/Desktop/файл для 3-его задания.txt");
                    int StringArrayFl = 0;//переменная,в которую будут конвертироваться элементы из файла 
                    StringArrayFl = Convert.ToInt32(FileOpened[0]);
                    int[][] Array = new int[1][];//массив в которос будет содержаться преобразованный файл
                    string[] axisX = new string[1];//будет содержать строку массива из файла

                    Array = new int[StringArrayFl][];
                    for (int i = 0; i < StringArrayFl; i++)
                    {
                        axisX = FileOpened[i + 1].Split(' ');
                        Array[i] = new int[axisX.Length];
                        for (int j = 0; j < axisX.Length; j++)
                        {
                            Array[i][j] = Convert.ToInt32(axisX[j]);

                        }
                    }
                    Console.WriteLine("\r");
                    Console.WriteLine("Полученный из файла массив - Array");
                    for (int i = 0; i < StringArrayFl; i++)
                    {
                        for (int j = 0; j < Array[i].Length; j++)
                        {
                            Console.Write(Array[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\r");

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
                    Console.WriteLine($"Максимальный эдемент массива:Y:{MaxIndex1} X{MaxIndex2}-{MaxElement} ");
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

                    Console.WriteLine($"Минимальный эдемент массива:{MinIndex1} {MinIndex2}-{MinElement } ");
                    Console.WriteLine();

                    //замена одного из элементов массива
                    Console.WriteLine("Введите координаты элемента,которого хотите заменить:");
                    int q = 0;
                    int w = 0;
                    Console.WriteLine("Введите строку, в которой находится эелемент");
                    //Element[0] = int.Parse(Console.ReadLine());
                    q = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец, в котором находится эелемент");
                    w = int.Parse(Console.ReadLine());
                    Array[q - 1][w - 1] = random.Next();
                    Console.WriteLine($"Новый элемент: {Array[q - 1][w - 1]}");
                    Console.WriteLine();

                    //вывод обработаного массива:
                    Console.Write("Обработанный массив:");
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
                //////////////////////////////////////////////////////////////////////////
                static void kb_3()
                {//ввод массива

                    Console.WriteLine("Введите количество строк массива");
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
                    Console.WriteLine($"Максимальный эдемент массива:Y:{MaxIndex1} X:{MaxIndex2}-{MaxElement} ");
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

                    Console.WriteLine($"Минимальный эдемент массива:Y:{MinIndex1} X:{MinIndex2}-{MinElement } ");
                    Console.WriteLine();

                    //замена одного из элементов массива
                    Console.WriteLine("Введите координаты элемента,которого хотите заменить:");
                    int q = 0;
                    int w = 0;
                    Console.WriteLine("Введите строку, в которой находится эелемент");
                    //Element[0] = int.Parse(Console.ReadLine());
                    q = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите столбец, в котором находится эелемент");
                    w = int.Parse(Console.ReadLine());
                    Array[q - 1][w - 1] = random.Next();
                    Console.WriteLine($"Новый элемент: {Array[q - 1][w - 1]}");
                    Console.WriteLine();

                    //вывод обработаного массива:
                    Console.Write("Обработанный массив:");
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
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Некоретный ввод элементов массива.попробуйте заново");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоретный ввод элементов массива.попробуйте заново");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Некоретный ввод элементов массива.попробуйте заново");
            }
            catch (Exception)
            {
                Console.WriteLine("Некоретный ввод элементов массива.попробуйте заново");
            }

        
        }
    
    }


}
        



    

