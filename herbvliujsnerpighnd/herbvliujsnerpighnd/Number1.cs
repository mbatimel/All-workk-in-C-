using System;
using System.Globalization;
using System.IO;


namespace herbvliujsnerpighnd
{
    class Program
    {
        struct BD
        {
            public BD(int Id,
        string FullName,
        DateTime BirthdayDate,
        string Institute,
        string Group,
        string Course,
        float AvgMark)
            {
                this.Id = Id;//первый параметр соответсвует классу второй конструктору 
                this.FullName = FullName;
                this.BirthdayDate = BirthdayDate;
                this.Institute = Institute;
                this.Group = Group;
                this.Course = Course;
                this.AvgMark = AvgMark;
            }


            public int Id;
            public string FullName;
            public DateTime BirthdayDate;
            public string Institute;
            public string Group;
            public string Course;
            public float AvgMark;

        }





        static void Main(string[] args)
        {///Users/macbook/Projects/herbvliujsnerpighnd/herbvliujsnerpighnd/Number1.txt
            //инициализация текстового файла в массив
            //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
            string line;
            BD[] bd = new BD[100];
            StreamReader sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/herbvliujsnerpighnd/Laboratory_Work2 — копия1.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                string[] file = line.Split(' ');
                try
                {
                    bd[int.Parse(file[0])] = new BD(int.Parse(file[0]), (file[1] + " " + file[2] + " " + file[3]), DateTime.ParseExact(file[4],"dd.MM.yyyy", CultureInfo.InvariantCulture), file[5], file[6], file[7], float.Parse(file[8]));
                }
                catch
                {
                    Console.WriteLine("Ошибка в базе данных. Возможно,что данные одного из пользователей не верны. Проверте!!! ");

                }
                line = sr.ReadLine();


            }
            //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
            //вывод баззы данных
            for (int i = 0; i < bd.Length; i++)
            {
                if (bd[i].Id != 0)
                {
                    ToString(bd[i]);
                }

            }
            Console.WriteLine();


            //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
            ///типо меню
            bool mood = false;
            while (mood != true)
            {
                
                Console.Write("Выберете действие:" +
                                           "\n 1)Найти пользоватея в базе данных(Нажмите 1)" +
                                           "\n 2) Завешить работу программы (Нажмите 0)");
                                           
                Console.WriteLine();


                try
                {
                    string MoodString = Console.ReadLine();
                    int Mood = Convert.ToInt32(MoodString);

                    switch (Mood)
                    {
                        case 1:
                            {
                                Poisc(bd);

                                break;
                            }
                        case 0:
                            {
                                
                                mood = true;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Режим выбран не правильно,попробуйте заново");
                                break;
                            }



                    }
                }
                catch
                {
                    Console.WriteLine("Некоректный ввод данных ");
                }

                

            }
            {
                Console.WriteLine("Программа завершила работу!");
            }
            Console.ReadKey();
        }
        //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
        ///поиск пользователя
        static void Poisc(BD[] bd)
        {


            bool problem = false;
           
           
           string  delite = "";

            while (problem != true)
            {

                try
                {





                    Console.WriteLine("Введите дату рождения пользователя");
                    string text = Console.ReadLine();
                    DateTime x = DateTime.ParseExact(text, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                    for (int i = 0; i < bd.Length; i++)
                    {
                        if (bd[i].Id != 0)
                        {
                            if (bd[i].BirthdayDate == x)
                            {
                                ToString(bd[i]);
                                delite = bd[i].FullName;
                            }
                        }

                    }

                    if (delite == "")
                    {
                        Console.WriteLine("Данного пользователя не существует в базе данных.");
                              

                    }

                    Console.WriteLine("\nЧтобы завершить поиск пользователя нажмите Esc,чтобы продолжить поиск нажмите на любую клавишу");
                       
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("\n " +
                            "1Завершаю поиск");
                        problem = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Некоректный ввод даты рождения пользователя.Попробуйте еще раз. ");
                }

            }




        }
        //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
        static void ToString(BD bd)//метод,который выписывает все элементы из файла
        {
            Console.WriteLine($"- id: { bd.Id}\n" +
                                                $"-FullName: {bd.FullName  }\n" +
                                                $"-BirthdayDate: {bd.BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) }\n" +
                                                $"-Institute: {bd.Institute}\n" +
                                                $"-Group: {bd.Group }\n" +
                                                $"-Course: {bd.Course }\n" +
                                                $"-AvgMark: {bd.AvgMark }\n\n");



        }


    }

}

