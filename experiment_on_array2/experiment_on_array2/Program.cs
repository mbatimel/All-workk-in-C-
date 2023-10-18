using System;
using System.Linq;

namespace experiment_on_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5, n = 4;
            int[,] arr = new int[m, n];
            Console.WriteLine("Вводите построчно, затем энтер");
            for (int i = 0; i < m; i++)
            {
                Console.Write("->");
                int[] row = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < n; j++)
                    arr[i, j] = row[j];
            }
        }
    }
}
