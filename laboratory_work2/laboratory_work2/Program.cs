using System;
using System.IO;
using System.Text ;


namespace laboratory_work2
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
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
                {

                   /* //первый массив из файла
                    string[] LenghtArray = new string[1];
                    string[] ArrayInstring = new string[1];
                    LenghtArray = File.ReadAllLines(@$"/Users/macbook/Desktop/эксперемент.txt");
                    ArrayInstring = LenghtArray[0].Split(' ');

                    int[] Axes = new int[2];
                    Axes[0] = int.Parse(ArrayInstring[0]);
                    Axes[1] = int.Parse(ArrayInstring[1]);



                    int[,] SeconsdArray2 = new int[1, 1];
                    string[] stroka = new string[1];

                    SeconsdArray2 = new int[Axes[0], Axes[1]];
                    for (int i = 0; i < Axes[0]; i++)
                    {
                        stroka = LenghtArray[i + 1].Split(' ');
                        for (int j = 0; j < stroka.Length; j++)
                            SeconsdArray2[i, j] = Convert.ToInt32(stroka[j]);

                    }
                    Console.WriteLine("\r");
                    Console.WriteLine("Заполненный массив - SeconsdArray2");
                    for (int i = 0; i < Axes[0]; i++)
                    {
                        for (int j = 0; j < Axes[1]; j++)
                        {
                            Console.Write(SeconsdArray2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    */

                    string[] lines = File.ReadAllLines(@"/Users/macbook/Desktop/эксперемент.txt");
                    string[] column_and_string = lines[0].Split(' ');
                    int[] int_column_and_string = new int[2];
                    int_column_and_string[0] = int.Parse(column_and_string[0]);
                    int_column_and_string[1] = int.Parse(column_and_string[1]);
                    //Console.WriteLine("Заполните массив построчно: ");
                    int[,] array1 = new int[int_column_and_string[0], int_column_and_string[1]];
                    for (int i = 0; i < int_column_and_string[0]; i++)
                    {
                        string[] stroka = lines[i + 1].Split(' ');
                        for (int j = 0; j < stroka.Length; j++)
                            array1[i, j] = Convert.ToInt32(stroka[j]);

                    }

                    Console.WriteLine("\r");
                    Console.WriteLine("Заполненный массив - array1");
                    for (int i = 0; i < int_column_and_string[0]; i++)
                    {
                        for (int j = 0; j < int_column_and_string[1]; j++)
                        {
                            Console.Write(array1[i, j] + " ");
                        }
                        Console.WriteLine();
                    }



















                    

                    Console.WriteLine("нахождение максимального и минамального элементов матрицы:");

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
                    Console.WriteLine($"(X{w};Y{q}):{maxNumber} ");
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
                    Console.WriteLine($"(X{r};Y{e}):{minNumber}");
                    Console.WriteLine();

                    //второй массив
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
                    Console.WriteLine("Заполненный массив - thirdArray");
                    for (int i = 0; i < Axes2[0]; i++)
                    {
                        for (int j = 0; j < Axes2[1]; j++)
                        {
                            Console.Write(thirdArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }


                    if ((Axes[0] != Axes2[0]) && (Axes[1] != Axes2[1]))
                    {
                        throw new InvalidOperationException
                              ("Матрицы не совместимы. Число столбцов первой матрицы должно быть равно числу строк второй матрицы. попробуйте еще раз");
                    }



                    //нахожнение произведения,суммы и разности массивов
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("произведение матриц:");
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


                    Console.WriteLine("сумма матриц:");
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



                    Console.WriteLine("разность  матриц:");
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
                static void Main2()
                {

                    Console.WriteLine("введение параметров первого массива:");
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

                        for (int i = 0; i < y; i++)
                        {
                            for (int j = 0; j < x; j++)
                            {

                                Console.Write($"{SeconsdArray[i, j]} ");

                            }
                            Console.WriteLine();
                        }



                    }



                    Console.WriteLine("нахождение максимального и минамального элементов матрицы:");

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
                    Console.WriteLine($"(X{w};Y{q}):{maxNumber} ");
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
                    Console.WriteLine($"(X{r};Y{e}):{minNumber}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("введение параметров второго массива:");
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
                    Console.WriteLine("произведение матриц:");
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


                    Console.WriteLine("сумма матриц:");
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


                    Console.WriteLine("разность  матриц:");
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
            catch (Exception)
            {
                Console.WriteLine("Неккоретный ввод элементов массива.попробуйте заново");
            }


            Console.ReadKey();


        }

    }
}
    