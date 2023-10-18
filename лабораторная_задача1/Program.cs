using System;
using System.IO;
using System.Linq;

namespace лабораторная_задача1
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            string[] LenghtArray = new string[1];//принимает файл 
            string[] ArrayInstring = new string[1];
            LenghtArray = File.ReadAllLines(@$"/Users/macbook/Desktop/эксперемент.txt");
            ArrayInstring = LenghtArray[0].Split(' ');

            int[] Axes = new int[2];//делит на столбы и строки массив,точно так же,как он и записан в файле
            Axes[0] = int.Parse(ArrayInstring[0]);//записывает колическтво строк
            Axes[1] = int.Parse(ArrayInstring[1]);//записывает количество  столбов

            string[] stroka = new string [1];//создает массив,который будет принимать значения в файле и будет конвертировать их  в int
            int[,] SeconsdArray2 = new int[Axes[0], Axes[1]];//задается массив,который будет делить на строки 
            for (int i = 0; i < Axes[0]; i++)
            {
                stroka = LenghtArray[i + 1].Split(' ');
                for (int j = 0; j < stroka.Length; j++)
                    SeconsdArray2[i, j] = Convert.ToInt32(stroka[j]);

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

        }





    }
}



