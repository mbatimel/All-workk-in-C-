using System;
using System.IO;
using System.Linq;

namespace main
{
    public class Number1
    {

        public void Number_1()
        {
          
            
                try
                {//запрос у пользователя,чтобы он выбрал режим работы
                    bool cki = false;
                    Console.WriteLine("Выберете режим работы в каком должна работать программа(fl-считывание из файла;kb-ввод массива вручную)");
                    string i = Console.ReadLine();
                    do
                    {

                        switch (i)
                        {
                            case "kb"://ручной ввод
                                {
                                    cki = true;
                                     kb_1();
                                    break;
                                }
                            case "fl"://ввод из файла
                                {
                                    cki = true;
                                    fl_1();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Ввод некоректен.Попробуйте заново");
                                    i = Console.ReadLine();
                                    break;
                                }

                        }

                    } while (cki == false);

                    static void fl_1()
                    { //метод,который считывает из файла
                        string[] Array = new string[1];//создание массива в котором будут вписаны значения из файла
                        Array = File.ReadAllLines($@"/Users/macbook/Desktop/файл для 1-ого задания.txt");

                        string[] Number = Array[0].Split(' ', ',', '.');//массив,который обрабатывает введенные данные и разделяет их на элементы массива
                        int[] intArray = new int[Number.Length];
                        for (int i = 0; i < Number.Length; i++)
                        {
                            intArray[i] = int.Parse(Number[i]);//парсит в инт новый массив 
                            Console.WriteLine(intArray[i]);

                        }
                        int maxNumber = intArray[0];
                        int IndexNumber = 0;
                        int minNumber = intArray[0];
                        int IndexNumber2 = 0;
                     Console.Write($"Массив:\n ");
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
                        Console.WriteLine($"Минимальный элемент массива: №({IndexNumber }) {maxNumber}");
                        for (int j = 1; j < intArray.Length; j++)
                        {
                            if (intArray[j] < minNumber)//минимальный элемент
                            {
                                minNumber = intArray[j];
                                IndexNumber2 = j;
                            }

                        }
                        Console.WriteLine($"Максимальный элемент массива:№({IndexNumber2 }) {minNumber}");



                    bool mode;
                    do
                    {
                        mode = true;
                        Console.WriteLine("\nВыберете режим a или режим b");
                        string text = Console.ReadLine();
                        string k = Convert.ToString(text);//задание  с выбором режима
                        
                  
                        
                        if(mode)
                        {
                            switch (k)//в каждое значение записать класс с методом 
                            {
                                case "a"://по возврастанию ставит
                                    mode = true;
                                    Console.WriteLine($"Режим 1 активирован:\t");
                                    Console.Write($"Массив посроенный по возврастанию:\n ");
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
                                    mode = true;
                                    Console.WriteLine($"Режим 2 активирован:\t");
                                    Console.Write($"Массив посроенный по убыванию:\n ");
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
                                    mode = false;
                                    Console.WriteLine($"Режим  выбран не правильно, попробуйте заново");
                                    break;
                            }
                        }
               
                    } while (mode ==false);
                    Console.WriteLine();
                        Console.WriteLine("Четные элементы массива:");
                         int[] Number2 = intArray;//четные элементы массива
                        for (int i = 0; i < Number2.Length; i++)
                        {
                            if (Number2[i] % 2 == 0)
                            {
                                
                                Console.Write($"{Number2[i]} ");
                            }
                        }





                    }


                    static void kb_1()
                    {

                        Console.WriteLine("Ввидите все элементы массива через пробел");
                    
                    
                        int[] Number = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                 
                    

                        int maxNumber = Number[0];
                        int IndexNumber = 0;
                        int minNumber = Number[0];
                        int IndexNumber2 = 0;
                    Console.Write($"Массив :\n ");
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
                        Console.WriteLine($"Максимальный элемент массива:№({IndexNumber }) {maxNumber}");
                        for (int j = 1; j < Number.Length; j++)
                        {
                            if (Number[j] < minNumber)//минимальный элемент
                            {
                                minNumber = Number[j];
                                IndexNumber2 = j;
                            }

                        }
                        Console.WriteLine($"Минимальный элемент массива:№({IndexNumber2 }){minNumber}");



                    bool mode;
                    do
                    {
                        mode = true;
                     Console.WriteLine("\nВыберете  режим a или режим b:");
                     string text = Console.ReadLine();
                     string k = Convert.ToString(text);//задание  с выбором режима
                        if (mode)
                        {

                            switch (k)//в каждое значение записать класс с методом 
                            {
                                case "a"://по возврастанию ставит
                                    mode = true;
                                    Console.WriteLine($"Режим 1 активирован:\t");
                                    Console.Write($"Массив посроенный по возрастанию:\n ");
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
                                    mode = true;
                                    Console.WriteLine($"Режим 2 активирован:\t");
                                    Console.Write($"Массив посроенный по убыванию:\n ");
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
                                    mode = false;
                                    Console.WriteLine($"Режим выбран не правильно,попробуйте заново");
                                    break;
                            }
                        }
                        }while (mode == false) ;



                     
                    Console.WriteLine();
                    Console.WriteLine("Четные элементы массива");
                    int[] Number2 = Number;//четные элементы массива
                        for (int i = 0; i < Number2.Length; i++)
                        {
                            if (Number2[i] % 2 == 0)
                            {
                                
                                Console.Write($"{Number2[i]} ");
                            }
                        }




                    }
                }

                catch (ArgumentNullException)
                {
                    Console.WriteLine("Некоретный ввод элементов массива .Попробуйте заново");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некоретный ввод элементов массива.Попробуйте заново");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Некоретный ввод элементов массива.Попробуйте заново");
                }

            }



       
    }
}

    




    

