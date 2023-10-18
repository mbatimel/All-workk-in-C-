using System.Xml.Linq;

namespace choicingSort;
class Program
{

    static void Main(string[] args)
    {//сортировка подсчетом.
     //наилучшее обьяснение https://vscode.ru/prog-lessons/sortirovka-metodom-vyibora-c-sharp.html <--тут

        List<int> Sort = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            Sort.Add(Convert.ToInt32(num[i]));
        }
        foreach (var nums in Choice(Sort))
        {
            Console.WriteLine(nums);
        }
        Console.ReadKey();
    }
    static List<int> Choice(List<int> sort)
    {
        for (int i = 0; i < sort.Count - 1; i++)
        {

            int min = i;
            for (int j = i + 1; j < sort.Count; j++)
            {
                if (sort[j] > sort[min])
                {
                    min = j;                }
            }
            int temp = sort[min];
            sort[min] = sort[i];
            sort[i] = temp;
        }
        return sort;
    }
    
}