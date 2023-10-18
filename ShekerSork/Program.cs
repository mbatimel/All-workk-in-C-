using System;
using System.Collections.Generic;

namespace ShekerSort;
class Program// сортировка шейкером
{
    static void Main(string[] args)
    {
        List<int> bubble = new List<int>() { 2, 1, 8, 9, 3, 7 };

        foreach (var nums in CocktailSort(bubble))
        {
            Console.WriteLine(nums);
        }

        Console.ReadKey();
    }


    static void Swap(List<int> array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    static List<int> CocktailSort(List<int> inArray)
    {
        int left = 0,
             right = inArray.Count - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (inArray[i] > inArray[i + 1])
                    Swap(inArray, i, i + 1);
            }
            right--;
            for (int i = right; i > left; i--)
            {
                if (inArray[i - 1] > inArray[i])
                    Swap(inArray, i - 1, i);
            }
            left++;
        }
        return inArray;
    }
}

