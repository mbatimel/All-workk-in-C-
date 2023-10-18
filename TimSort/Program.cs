namespace TimSort;
class Program
{
    static void Main(string[] args)
    {//тим сорт
     // https://www.educative.io/answers/what-is-timsort

        //ввод данных
        List<int> Sort = new List<int>();
        Console.Write("Введите через пробел числа для сортировки ");
        var numbers = Console.ReadLine();
        string[] num = numbers.Split(' ');
        for (int i = 0; i < num.Length; i++)
        {
            Sort.Add(Convert.ToInt32(num[i]));
        }
        //вывод
        foreach (var nums in timsort(Sort, Sort.Count))
        {
            Console.WriteLine(nums);
        }
        Console.ReadKey();
    }
    static List<int> timsort(List<int> sort,int size)
    {
        const int RUN = 64;
        for (int i=0;i<size;i++ )
        {
            insertsort(sort,i,Min((i+RUN-1),(size-1)));

        }
        for (int n = RUN; n < size; n *= 2)
        {
            for (int start_index = 0; start_index < size; start_index += 2 * n)
            {
                int mid = start_index + n - 1;
                int end_index = Min((start_index + 2 * n - 1), (size - 1));

                if (mid < end_index)
                {
                    merge(sort, start_index, mid, end_index);
                }
            }
        }

        return sort;
    }

    private static void merge(List<int> sort, int start_index, int mid, int end_index)
    {
        int k;
        int i;
        int j;
        int left_size=mid - start_index + 1;
        int right_size = end_index - mid;
        int[] left_array = new int[left_size];
        int[]right_array=new int [right_size];

        for ( i = 0; i < left_size; i++)
        {
            left_array[i] = sort[start_index + i];
        }

        for ( j = 0; j < right_size; j++)
        {
            right_array[j] = sort[mid + 1 + j];
        }
        i = 0;
        j = 0;
        k = start_index;

        for (; i < left_size && j < right_size; k++)
        {
            if (left_array[i] <= right_array[j])
            {
                sort[k] = left_array[i];
                i++;
            }
            else
            {
                sort[k] = right_array[j];
                j++;
            }
        }
        for (; i < left_size; i++, k++)
        {
            sort[k] = left_array[i];
        }
        for (; j < right_size; j++, k++)
        {
            sort[k] = right_array[j];
        }
    }

    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
    static void insertsort(List<int>sort,int start_index,int end_index)
    {
        for (int i = start_index + 1, j, temp; i <= end_index; i++)
        {
            temp = sort[i];
            j = i - 1;

            while (j >= 0 && temp <= sort[j])
            {
                sort[j + 1] = sort[j];
                j = j - 1;
            }
            sort[j + 1] = temp;
        }
    }
}

