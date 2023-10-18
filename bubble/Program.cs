namespace bubble;
class Program
{
   //суть метода заключается в том что мы делаем проверку между двумя соседними элементами
   //если первый элемент больше последующего то мы меняем мы местами
   //такая проверка будет проходить росвно столько раз ксолько элементов в массиве в квадрате 
    static void Main(string[] args)
    {
        List<int> bubble = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            bubble.Add(Convert.ToInt32(num[i]));
        }
        foreach (var nums in BubbleSort(bubble))
            {
            Console.WriteLine(nums);
        }
        Console.ReadKey();
    }
    static List<int> BubbleSort(List<int> mas)
    {
        int item = 0;
        //for (int i = 0; i < mas.Count; i++)
        //{
        //    for (int j = i + 1; j < mas.Count; j++)
        //    {
        //        if (mas[i] < mas[j])
        //        {
        //            item = mas[i];
        //            mas[i] = mas[j];
        //            mas[j] = item;
        //        }
        //    }
        //}
        for(int i=1;i<mas.Count;i++)
        {
            if (mas[i - 1] < mas[i])
            {
                item = mas[i-1];
                mas[i-1] = mas[i];
                mas[i] = item;
            }
        }

        return mas;
    }
}

