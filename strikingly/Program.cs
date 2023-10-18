using System.Drawing;


namespace strikingly;
class Program
{
    static void Main(string[] args)
    {//сортировка radix nlog(n)
     //https://code-maze.com/csharp-radix-sort/

        List<int> Sort = new List<int>() { 2, 423, 5456, 36, 85, 67, 423, 431 };

        //Console.Write("Введите через пробел числа для сортировки ");
        //string numbers = Console.ReadLine();
        //string[] num = numbers.Split(' ');
        //for (int i = 0; i < num.Length; i++)
        //{
        //    Sort.Add(Convert.ToInt32(num[i]));
        //}
        foreach (var nums in strikinglySort(Sort))
        {
            Console.WriteLine(nums);
        }
        Console.ReadKey();
    }

    static List<int> strikinglySort(List<int> sort)
    {
        int max = Maxsort(sort);
        for(int i=1;max/i>0;i*=10)
        {
            RadizxSort(sort, sort.Count, i);
        }
        return sort;
    }

    private static void RadizxSort(List<int> sort, int size, int exp)
    {
        var outputArr = new int[size];
        var occurences = new int[10];
        for (int i = 0; i < size; i++)
        { occurences[(sort[i] / exp) % 10]++; }//количество вхожденией каждого элемента в 
        for (int i = 1; i < 10; i++)
        { occurences[i] += occurences[i - 1]; }//подсчитываем места в которых должен стоять элемент массива
        for (int i = size - 1; i >= 0; i--)
        {
            outputArr[occurences[(sort[i] / exp) % 10] - 1] = sort[i];//расставляем эелементы массива
            occurences[(sort[i] / exp) % 10]--;
        }
        for (int i = 0; i < size; i++)
            sort[i] = outputArr[i];//сохраняем изменения
    }

    //поиск максимального элемента
    static int Maxsort(List<int> sort)
    {
        int max = sort[0];
        for(int i=0;i<sort.Count;i++)
        {
            if (max < sort[i])
            { max = sort[i]; }
        }
        return max+1;
    }


}

