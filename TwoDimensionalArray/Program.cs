using System;

namespace TwoDimensionalArray
{
    class Program
    {//если рассматривать двумерный массив то  это как ось у и ось х
        // первый (у,х) только координаты точки находятся сначала у потом х
        static void Main(string[] args)
        {
            // тип_данных [ , ] имя_массива;
            int[,] TowMAssiv;//просто создали ярлык в котором должны храниться данные
                             //или же мы просто можем указать так:int[,] TowMAssiv = new int[3, 5];
                             //чтобы вывксти какое то определенное значение массива,нам нам нужно указать имя массива и в квадратных скобках указать строку и столб

            TowMAssiv = new int[,]//чтобы не контралировалось кол-во столбов и т.д можно не впис туда знач
               {//главное,чтобы количество столбов было одинаковое
                   {34,45,65,78,6 },
                   { 23,35,46,58,6},
                   {12,4,5,67,8 }, 
                   {12,43,56,54,67 },
                   {24,4,7,68,9765 }

               };//1 способ
            int Height = TowMAssiv.GetLength (0);
            int Width = TowMAssiv.GetLength(1);
          for(int y=0;y<Height;y++)
            {
                for(int x=0;x<Width;x++)
                {
                    Console.Write(TowMAssiv[y, x]+"\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //второй способ
            for (int y = 0; y < TowMAssiv.GetLength(0); y++)
            {
                for (int x = 0; x < TowMAssiv.GetLength(1); x++)
                { 
                    Console.Write(TowMAssiv[y, x] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            int[,] Massiv = new int[10, 6];
            Random random = new Random();
            for (int i = 0; i < Massiv.GetLength(0); i++)
            {
                for (int j = 0; j < Massiv.GetLength(1); j++)
                {
                    Massiv[i, j] = random.Next(5);
                }
            }



                    for (int y = 0; y < Massiv.GetLength(0); y++)
            {
                
                for (int x = 0; x < Massiv.GetLength(1); x++)
                {
                    Console.Write(Massiv[y, x] + "\t ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();




            int[,] Massiv2 = new int[3, 4];
            for (int y = 0; y < Massiv2.GetLength(0); y++)
            {

                for (int x = 0; x < Massiv2.GetLength(1); x++)
                {
                    Console.WriteLine("Y " + y + "X " + x);
                    Massiv2[y, x] = int.Parse(Console.ReadLine());
                }

            }
            for (int y = 0; y < Massiv2.GetLength(0); y++)
            {

                for (int x = 0; x < Massiv2.GetLength(1); x++)
                {
                    Console.Write(Massiv2[y, x] + "\t ");
                }
                Console.WriteLine();

            }


                string [,] Massiv3 = new string[3, 4];

                for (int y = 0; y < Massiv3.GetLength(0); y++)
                {

                    for (int x = 0; x < Massiv3.GetLength(1); x++)
                    {
                        Console.WriteLine("Y " + y + "X " + x);
                    Massiv3[y,x] = Console.ReadLine();
                    }

                }

                for (int y = 0; y < Massiv3.GetLength(0); y++)
                {

                    for (int x = 0; x < Massiv3.GetLength(1); x++)
                    {
                        Console.Write(Massiv3[y, x] + "\t ");
                    }
                    Console.WriteLine();

                }
            Console.WriteLine(TowMAssiv.GetLength(1));//сколькомерный массив выводит надпись RAnk
            //если мы введем Length,то нам выведет количество элементов в массиве
            //метод GetLength() позволяет узнать количество элементов массива в определенном измерении 
        }

      
    }
}
