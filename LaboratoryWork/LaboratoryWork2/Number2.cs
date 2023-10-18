using System;
using System.Linq;

namespace laboratory_work2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
                if (y != z)
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

                        for (int k = 0; k < x; k++)
                        {
                            Matrix[i, j] = SeconsdArray[i, k] * thirdArray[k, j];


                        }
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

                        for (int k = 0; k < x; k++)
                        {
                            Matrix2[i, j] = SeconsdArray[i, k] + thirdArray[k, j];


                        }
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

                        for (int k = 0; k < x; k++)
                        {
                            Matrix3[i, j] = SeconsdArray[i, k] - thirdArray[k, j];


                        }
                        Console.Write($"{Matrix3[i, j]} ");


                    }
                    Console.WriteLine();

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

        }


    }
}

