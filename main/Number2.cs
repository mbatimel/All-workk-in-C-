
using System;
using System.IO;
using System.Text;
namespace main
{
    public class Number2
    {


        public void Number_2()
        {
            try
            {
                bool cki = false;
                Console.WriteLine("Выберете  режим работы в каком должна работать программа(fl-считывание из файла;kb-ввод массива вручную)");
                string i = Console.ReadLine();
                do
                {

                    switch (i)
                    {
                        case "kb":
                            {
                                cki = true;
                                kb_2();
                                break;
                            }
                        case "fl":
                            {
                                cki = true;
                                fl_2();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Некорректный ввод режима.попробуйте заново");
                                i = Console.ReadLine();
                                break;
                            }

                    }

                } while (cki == false);





                static void fl_2()
                {
                   
                    //первый массив из файла
                    string[] LenghtArray = new string[1];//принимает файл 
                    string[] ArrayInstring = new string[1];

                    LenghtArray = File.ReadAllLines(@$"/Users/macbook/Desktop/файл для 2-ого задания №1.txt");
                    ArrayInstring = LenghtArray[0].Split(' ');

                    int[] Axes = new int[2];//делит на столбы и строки массив,точно так же,как он и записан в файле
                    Axes[0] = int.Parse(ArrayInstring[0]);//записывает колическтво строк
                    Axes[1] = int.Parse(ArrayInstring[1]);//записывает количество  столбов

                    string[] stroka = new string[1];//создает массив,который будет принимать значения в файле и будет конвертировать их  в int
                    int[,] SeconsdArray2 = new int[Axes[0], Axes[1]];//задается массив,который будет делить на строки 
                    for (int i = 0; i < Axes[0]; i++)
                    {
                        stroka = LenghtArray[i + 1].Split(' ');
                        for (int j = 0; j < stroka.Length; j++)
                            SeconsdArray2[i, j] = Convert.ToInt32(stroka[i]);

                    }
                    Console.WriteLine("\r");
                    Console.WriteLine("Полученный из файла первый массив - SeconsdArray2");
                    for (int i = 0; i < Axes[0]; i++)
                    {
                        for (int j = 0; j < Axes[1]; j++)
                        {
                            Console.Write(SeconsdArray2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }


                    Console.WriteLine("Нахождение максимального и минамального элементов матрицы:");

                    //нахождение максимального элемента 
                    int maxNumber = SeconsdArray2[0, 0];
                    int q = 0;
                    int w = 0;
                    for (int i = 1; i < Axes[0]; i++)
                    {
                        for (int j = 1; j < Axes[1]; j++)
                        {
                            if (SeconsdArray2[i, j] > maxNumber)
                            {
                                maxNumber = SeconsdArray2[i, j];
                                q = i;
                                w = j;
                            }
                        }
                    }
                    Console.WriteLine($"Максимальный эелемент массива:(X{w};Y{q}):{maxNumber} ");
                    //нахождение минимального элемента 
                    int minNumber = SeconsdArray2[0, 0];
                    int e = 0;
                    int r = 0;
                    for (int i = 1; i < Axes[0]; i++)
                    {
                        for (int j = 1; j < Axes[1]; j++)
                        {
                            if (SeconsdArray2[i, j] < minNumber)
                            {
                                minNumber = SeconsdArray2[i, j];
                                e = i;
                                r = j;
                            }
                        }
                    }
                    Console.WriteLine($"Минимальный элеменет массива:(X{r};Y{e}):{minNumber}");
                    Console.WriteLine();
                    
                    //второй массив
                    //все точно также как и при вводе первого двумерного массива
                    string[] LenghtArray2 = new string[1];
                    string[] ArrayInstring2 = new string[1];
                    LenghtArray2 = File.ReadAllLines(@$"/Users/macbook/Desktop/файл для 2-ого задания №2.txt");
           
                    ArrayInstring2 = LenghtArray2[0].Split(' ');

                    int[] Axes2 = new int[2];
                    Axes2[0] = int.Parse(ArrayInstring2[0]);
                    Axes2[1] = int.Parse(ArrayInstring2[1]);



                    int[,] thirdArray = new int[1, 1];
                    string[] stroka2 = new string[1];

                    thirdArray = new int[Axes2[0], Axes2[1]];
                    for (int i = 0; i < Axes2[0]; i++)
                    {
                        stroka2 = LenghtArray2[i + 1].Split(' ');
                        for (int j = 0; j < stroka2.Length; j++)
                            thirdArray[i, j] = Convert.ToInt32(stroka2[j]);

                    }
                    Console.WriteLine("\r");
                    Console.WriteLine("Полученный из второго файла массив - thirdArray");
                    for (int i = 0; i < Axes2[0]; i++)
                    {
                        for (int j = 0; j < Axes2[1]; j++)
                        {
                            Console.Write(thirdArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }


                    if (Axes[0] != Axes2[0]&& Axes[1] != Axes2[1])
                    {
                        throw new InvalidOperationException
                              ("Массивы не совместимы. Число столбцов первого массива должно быть равно числу столбов второго массива. попробуйте еще раз");
                    }



                    //нахожнение произведения,суммы и разности массивов

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Произведение массивов:");
                    int[,] Matrix = new int[Axes[0], Axes2[1]];

                    for (int i = 0; i < Axes[0]; i++)
                    {
                        for (int j = 0; j < Axes2[1]; j++)
                        {



                            Matrix[i, j] = SeconsdArray2[i, j] * thirdArray[i, j];




                            Console.Write($"{Matrix[i, j]} ");


                        }
                        Console.WriteLine();

                    }


                    Console.WriteLine("Сумма массивов:");
                    int[,] Matrix2 = new int[Axes[0], Axes2[1]];

                    for (int i = 0; i < Axes[0]; i++)
                    {
                        for (int j = 0; j < Axes2[1]; j++)
                        {



                            Matrix2[i, j] = SeconsdArray2[i, j] + thirdArray[i, j];




                            Console.Write($"{Matrix2[i, j]} ");


                        }
                        Console.WriteLine();

                    }



                    Console.WriteLine("Разность массивов:");
                    int[,] Matrix3 = new int[Axes[0], Axes2[1]];

                    for (int i = 0; i < Axes[0]; i++)
                    {
                        for (int j = 0; j < Axes2[1]; j++)
                        {



                            Matrix3[i, j] = SeconsdArray2[i, j] - thirdArray[i, j];




                            Console.Write($"{Matrix3[i, j]} ");


                        }
                        Console.WriteLine();

                    }

                }

                //////////////////////////////////////////////
                static void kb_2()
                {

                    Console.WriteLine("Введение параметров первого массива:");
                    Console.Write("Кол-во Столбцов: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Кол-Во Строк: ");
                    int y = int.Parse(Console.ReadLine());


                    //ввод первого массива
                    int[,] SeconsdArray = new int[y, x];
                    {
                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {
                                Console.WriteLine("X " + j + "Y " + i);

                                SeconsdArray[i, j] = int.Parse(Console.ReadLine());


                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Полученный массив-SeconsdArray:");
                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {

                                Console.Write($"{SeconsdArray[i, j]} ");

                            }
                            Console.WriteLine();
                        }



                    }



                    Console.WriteLine("Нахождение максимального и минамального элементов матрицы:");

                    //нахождение максимального элемента 
                    int maxNumber = SeconsdArray[0, 0];
                    int q = 0;
                    int w = 0;
                    for (int i = 1; i < y; i++)
                    {
                        for (int j = 1; j < x; j++)
                        {
                            if (SeconsdArray[i, j] > maxNumber)
                            {
                                maxNumber = SeconsdArray[i, j];
                                q = i;
                                w = j;
                            }
                        }
                    }
                    Console.WriteLine($"Максимальный элемент массива:(X{w};Y{q}):{maxNumber} ");
                    //нахождение минимального элемента 
                    int minNumber = SeconsdArray[0, 0];
                    int e = 0;
                    int r = 0;
                    for (int i = 1; i < y; i++)
                    {
                        for (int j = 1; j < x; j++)
                        {
                            if (SeconsdArray[i, j] < minNumber)
                            {
                                minNumber = SeconsdArray[i, j];
                                e = i;
                                r = j;
                            }
                        }
                    }
                    Console.WriteLine($"Минимальный элемент массива:(X{r};Y{e}):{minNumber}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Введение параметров второго массива:");
                    Console.Write("Кол-во Столбцов: ");
                    int z = int.Parse(Console.ReadLine());
                    Console.Write("Кол-Во Строк: ");
                    int a = int.Parse(Console.ReadLine());


                    //ввод второго массива
                    
                    int[,] thirdArray = new int[a, z];
                    {
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < z; j++)
                            {
                                Console.WriteLine("X " + j + "Y " + i);
                                thirdArray[i, j] = int.Parse(Console.ReadLine());



                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Полученный массив - hirdArray:");
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < z; j++)
                            {

                                Console.Write($"{thirdArray[i, j]} ");

                            }
                            Console.WriteLine();
                        }


                    }
                    //проверка матриц на совместимость 
                    if ((x != z) && (y != a))
                    {
                        throw new InvalidOperationException
                              ("Матрицы не совместимы. Число столбцов первой матрицы должно быть равно числу строк второй матрицы. попробуйте еще раз");
                    }

                    //нахожнение произведения,суммы и разности массивов
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Произведение массивов:");
                    int[,] Matrix = new int[y, z];

                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < z; j++)
                        {


                            Matrix[i, j] = SeconsdArray[i, j] * thirdArray[i, j];



                            Console.Write($"{Matrix[i, j]} ");


                        }
                        Console.WriteLine();

                    }


                    Console.WriteLine("Сумма массивов:");
                    int[,] Matrix2 = new int[y, z];

                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < z; j++)
                        {


                            Matrix2[i, j] = SeconsdArray[i, j] + thirdArray[i, j];



                            Console.Write($"{Matrix2[i, j]} ");


                        }
                        Console.WriteLine();

                    }


                    Console.WriteLine("Разность  массивов:");
                    int[,] Matrix3 = new int[y, z];

                    for (int i = 0; i < y; i++)
                    {
                        for (int j = 0; j < z; j++)
                        {


                            Matrix3[i, j] = SeconsdArray[i, j] - thirdArray[i, j];



                            Console.Write($"{Matrix3[i, j]} ");


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

         


    

