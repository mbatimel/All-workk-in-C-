using System;
using main;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    class Program
                
    {
       

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            bool result;
            Console.WriteLine("Добро пожаловать в меню");
            do
               {


                  do
                {
                        int i;
                    
                        Console.WriteLine("Введите номер задания от 1 до 3");
                        string text = Console.ReadLine();
                    result = int.TryParse(text, out i);


                    if (result)
                        {




                            switch (i)
                            {
                                case 1:
                                    {
                                    result = false;
                                    Console.WriteLine("Запуск первого номера:");
                                        Number1 nums = new Number1();
                                        nums.Number_1();
                                        break;
                                    }
                                case 2:
                                    {
                                    result = false;
                                    Console.WriteLine("Запуск второго номера:");
                                        Number2 nums = new Number2();
                                        nums.Number_2();
                                        break;
                                    }
                                case 3:
                                    {
                                    result = false;
                                    Console.WriteLine("Запуск третьего номераЖ:");
                                        Number3 nums = new Number3();
                                        nums.Number_3();
                                        break;
                                    }
                              default:
                                    {
                                        Console.WriteLine("Задиния с таким номером не существует.попробуйте ввесити номер заново");
                                    result = false;
                                    break;
                                    }
                            }
                       
                        }
                       else
                        {
                            Console.WriteLine("Ошибка при вводе параметра ,попробуйте заново. ");
                          result = false;
                        }

                    } while (result !=false );
                   Console.WriteLine($"\nНажмите на любую клавишу,чтобы продолжить работу или нажмите ESC,чтобы завершить работу программы");
                    cki = Console.ReadKey();
                } while (cki.Key != ConsoleKey.Escape);
                {

                Console.WriteLine("Программа завершила свою работу");
                Console.WriteLine("Досвидание!");
                result = false;
                }

            Console.ReadKey();
          
        }
    }
}