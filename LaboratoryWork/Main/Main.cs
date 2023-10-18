using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите номер задания,который хотите открыть");
                string text = Console.ReadLine();
                int i = Convert.ToInt32(text);
                switch (i)
                {
                    case 1:
                        {
                            
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("time");
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("time");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Задиния с таким номером не существует");
                            break;
                        }

                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Неккоретный ввод данных.попробуйте заново");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неккоретный ввод данных.попробуйте заново");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Неккоретный ввод данных.попробуйте заново");
            }



        }
    }
}
