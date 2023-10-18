namespace ShellSort;
class Program
{/*Идея сортировки методом Шелла состоит в том, чтобы сортировать элементы отстоящие 
  * друг от друга на некотором расстоянии step. Затем сортировка повторяется при 
  * меньших значениях step, и в конце процесс сортировки Шелла завершается при step = 1 
  * (а именно обычной сортировкой вставками).
До сих пор продолжает обсуждаться вопрос выбора шага сортировки step.
    Шелл предложил такую последовательность: N/2, N/4, N/8 …,
    где N — количество элементов в сортируемом массиве.*/
    static void Main(string[] args)
    {
        List<int> shell = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            shell.Add(Convert.ToInt32(num[i]));
        }
        foreach (var nums in ShellSort(shell.Count, shell))
        {
            Console.WriteLine(nums);
        }
    }
    static List<int> ShellSort(int n, List<int> mass)
    {
        int i, j, step;
        int tmp;
        for (step = n / 2; step > 0; step /= 2)
            for (i = step; i < n; i++)
            {
                tmp = mass[i];
                for (j = i; j >= step; j -= step)
                {
                    if (tmp < mass[j - step])
                        mass[j] = mass[j - step];
                    else
                        break;
                }
                mass[j] = tmp;
            }
        return mass;
    }
}

