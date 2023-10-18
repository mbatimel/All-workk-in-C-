using System.Xml.Linq;

namespace SortCouting;
class Program
{

    static void Main(string[] args)
    {//сортировка подсчетом. наилучшее обьяснение https://yandex.ru/video/preview/16885752279891567987 <--тут

        List<int> Sort = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            Sort.Add(Convert.ToInt32(num[i]));
        }
        foreach (var nums in CoutingSort(Sort))
        {
            Console.WriteLine(nums);
        }
        Console.ReadKey();
    }
    static List<int> CoutingSort(List<int> sort)
    {
        int max = sort.Max();
        int[] array = new int[max + 1];
        for(int i=0;i<sort.Count;i++)
        {
            array[sort[i]]++;
        }
        for (int i = 0, j = 0; i <= max; i++)
        {
            while (array[i] > 0)
            {
                sort[j] = i;
                j++;
                array[i]--;
            }
        }

        return sort;
    }
}


    

