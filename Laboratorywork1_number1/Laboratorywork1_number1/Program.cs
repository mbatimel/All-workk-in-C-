using System;
using System.IO;
using System.Linq;
using System.Text;

namespace лабораторная_задача1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {//запрос у пользователя,чтобы он выбрал режим работы
                bool cki = false;
                Console.WriteLine("введите режим работы в каком должна работать программа(fl-считывание из файла;kb-ввод массива вручную");
                string i = Console.ReadLine();
                do
                {

                    switch (i)
                    {
                        case "kb":
                            {
                                cki = true;
                                Main2();
                                break;
                            }
                        case "fl":
                            {
                                cki = true;
                                Main3();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("ввели дичь.попробуйте заново");
                                i = Console.ReadLine();
                                break;
                            }

                    }

                } while (cki == false);

                static void Main3()
                { //метод,который считывает из файла
                    string[] Array = new string[1];
                    Array = File.ReadAllLines($@"/Users/macbook/Desktop/laybrarywork1.txt");

                    string[] Number = Array[0].Split(' ', ',', '.', '\n');
                    int[] intArray = new int[Number.Length];
                    for (int i = 0; i < Number.Length; i++)
                    {
                        intArray[i] = int.Parse(Number[i]);
                        Console.WriteLine(intArray[i]);

                    }
                    int maxNumber = intArray[0];
                    int IndexNumber = 0;
                    int minNumber = intArray[0];
                    int IndexNumber2 = 0;

                    for (int i = 0; i < intArray.Length; i++)
                    {
                        Console.Write($"{intArray[i]} ");//вывод всех элеменов массива


                    }

                    Console.WriteLine("\n");//максимальный элемент
                    for (int i = 1; i < intArray.Length; i++)
                    {
                        if (intArray[i] > maxNumber)
                        {
                            maxNumber = intArray[i];
                            IndexNumber = i;
                        }

                    }
                    Console.WriteLine($"{IndexNumber } {maxNumber}");
                    for (int j = 1; j < intArray.Length; j++)
                    {
                        if (intArray[j] < minNumber)//минимальный элемент
                        {
                            minNumber = intArray[j];
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
                            for (int i = 0; i < intArray.Length; i++)
                            {
                                int current = int.MaxValue;
                                int minCount = 0;
                                for (int j = 0; j < intArray.Length; j++)
                                {
                                    if (intArray[j] < current && intArray[j] > currentMin)
                                    {
                                        current = intArray[j];
                                        minCount = 0;
                                    }
                                    if (intArray[j] == current)
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
                            for (int i = 0; i < intArray.Length; i++)
                            {
                                int current = int.MinValue;
                                int minCount = 0;
                                for (int j = 0; j < intArray.Length; j++)
                                {
                                    if (intArray[j] > current && intArray[j] < currentMax)
                                    {
                                        current = intArray[j];
                                        minCount = 0;
                                    }
                                    if (intArray[j] == current)
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
                    int[] Number2 = intArray;//четные элементы массива
                    for (int i = 0; i < Number2.Length; i++)
                    {
                        if (Number2[i] % 2 == 0)
                        {
                            Console.WriteLine("Четные элементы массива");
                            Console.Write($"\n{Number2[i]} ");
                        }
                    }





                }


                static void Main2()
                {

                    Console.WriteLine("Ввидите все элементы массива через пробел");
                    bool dik = false;

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
                            Console.WriteLine("Четные элементы массива");
                            Console.Write($"\n{Number2[i]} ");
                        }
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

    


