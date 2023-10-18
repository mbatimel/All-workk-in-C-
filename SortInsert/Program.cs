namespace SortInsert;
class Program
{
    static void Main(string[] args)
    {//с мысл метода сортировки вставок: мы создаем цикл внутри for, который будет брать одно число из списка
     //и перетаскивать
        //его назад до тех пор пока выполняется условие цикла, после сортироки цикл останавливается
        //и выбирается следующие число
        //массива
        List<int> a = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            a.Add(Convert.ToInt32(num[i]));
        }

        for (int i = 1; i < a.Count; i++)
        {
            int k = a[i];
            int j = i - 1;

            while (j >= 0 && a[j] > k)
            {
                a[j + 1] = a[j];
                a[j] = k;
                j--;
            }
        }

        // Распечатываем массив.
        Console.WriteLine("Сортировка вставками");
        for (int i = 0; i < a.Count; i++)
        {
            Console.WriteLine(a[i]);
        }

    }
}

