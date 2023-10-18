﻿using System;
using System.Globalization;
using System.IO;

namespace Number
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
        {
            bool mood = false;
            while (mood != true)
            {
                Console.Write("База данных:\n");
                //инициализация текстового файла в массив
                //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// //////// ////////
                string line;
                BD[] bd = new BD[100];
                StreamReader sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] file = line.Split(' ');
                    try
                    {
                        bd[int.Parse(file[0])] = new BD(int.Parse(file[0]), (file[1] + " " + file[2] + " " + file[3]), DateTime.ParseExact(file[4], "dd.MM.yyyy", CultureInfo.InvariantCulture), file[5], file[6], file[7], float.Parse(file[8]));
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
                ////////////////////////////////////////////////////////////////////
                //типо меню



               
                Console.Write("Выберете действие:" +
                                           "\n 1)Найти пользоватея в базе данных по дате рождения(нажмите 1)" +
                                           "\n 2)Поиск пользователя по одной из частей ФИО( нажмите 2)" +
                                           "\n 3)Добавить пользователя(нажмите 3)" +
                                           "\n 4)Удалить пользователя(нажмите 4)" +
                                           "\n 5)Сортировка по среднему баллу(нажмите 5)" +
                                           "\n 6)Нахождение пользователей по максимальному баллу или минимальному" +
                                           "\n 7)Поиск одинаковых пользователей " +
                                           "\n 8)Поиск пользователей с одинаковыми средними баллами " +
                                           "\n 0)Завершить работу программы(нажмите 0)");

                Console.WriteLine();


                try
                {
                    string MoodString = Console.ReadLine();
                    int Mood = Convert.ToInt32(MoodString);

                    switch (Mood)
                    {
                        case 1:
                            {
                                PoiscPoDate(bd);

                                break;
                            }
                        case 2:
                            {
                                NamePoisk(bd);


                                break;
                            }
                        case 3:
                            {
                                NewUser(bd);
                                Savebd(bd);

                                break;

                            }
                        case 4:
                            {
                                DeleteUser(bd);
                                Savebd(bd);
                                break;
                            }
                        case 5:

                            {
                                SortingPoint(bd);

                                break;
                            }
                        case 6:
                            {
                                MaxOrMin(bd);
                                break;
                            }
                        case 7:
                            {
                                PoickUsers(bd);
                                Savebd(bd);
                                break;
                            }
                        case 8:
                            {
                                PoickAvg(bd);
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
                    Console.WriteLine("Некоретный ввод данных .Попробуйте заново");
                }

                Console.WriteLine("Хотите завершить работу программы?" +
                    "\n (Чтобы завершить работу нажмите Esc)" +
                    "\n (Чтобы продолжить работу нажмите любую другую клавишу)");
               

            }
            {
                Console.WriteLine("Программа завершила работу!");
            }
            Console.ReadKey();
        }
        //////////////////////////////////////////////////////////////////////////////
        //поиск пользователя по дате рождения
        static void PoiscPoDate(BD[] bd)
        {


            bool problem = false;


            string delite = "";

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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //добавление нового пользователя
        static void NewUser(BD[] bd)
        {
            bool problem = false;
            int Id;
            string FullName;
            DateTime BirthdayDate;
            string Institute;
            string Group;
            string Course;
            float AvgMark;
            while (problem != true)
            {
                try
                {
                    Console.WriteLine("\nВведите данные пользователя:");
                    Console.WriteLine("-id:");
                    Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-FullName:");
                    FullName = Console.ReadLine();

                    Console.WriteLine("-BirthdayDate:");
                    BirthdayDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

                    Console.WriteLine("-Institute:");
                    Institute = Console.ReadLine();

                    Console.WriteLine("-Group:");
                    Group = Console.ReadLine();

                    Console.WriteLine("-Course:");
                    Course = Console.ReadLine();

                    Console.WriteLine("-AvgMark:");
                    AvgMark = Convert.ToSingle(Console.ReadLine());

                    using StreamWriter stream = new StreamWriter(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt", true);//метод,который открывает файл и вписывает в него то что хочет пользователь
                    stream.WriteLine($"{ Id} {FullName} {BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)} {Institute} {Group} {Course} {AvgMark}");
                    stream.Close();
                    Console.Write("Пользователь сохранен\n");
                    problem = true;
                }
                catch
                {
                    Console.WriteLine("Некоретный ввод данных .Попробуйте заново(нажмите любую клавишу)");
                }


            }



        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //удаление пользователя
        static void DeleteUser(BD[] bd)
        {
            Console.WriteLine("Введите айди пользователя,которого хотите удалить");
            int x = int.Parse(Console.ReadLine());
            string text = "";
            for(int i=0;i<bd.Length;i++)
            {
                if(bd[i].Id!=0 & bd[i].Id==x)
                {
                    string id = Convert.ToString(bd[i].Id);
                    string fullname = Convert.ToString(bd[i].FullName);
                    string BirthdayDate = Convert.ToString(bd[i].BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
                    string inst = Convert.ToString(bd[i].Institute);
                    string group = Convert.ToString(bd[i].Group);
                    string course = Convert.ToString(bd[i].Course);
                    string avg = Convert.ToString(bd[i].AvgMark);


                    text = id + " " + fullname + " " + BirthdayDate + " " + inst + " " + group + " " + course + " " + avg;
                }
            }

           
           

            string tempFile = Path.GetTempFileName();//Создает на диске временный пустой файл с уникальным именем и возвращает полный путь этого файла.

            using (var sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt"))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != text)
                        {
                            sw.WriteLine(line);


                        }


                    }

                    sw.Close();
                }
                sr.Close();
            }
            Console.WriteLine("Данные пользователя удалены");

            File.Delete(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");
            File.Move(tempFile, @"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");

            Console.WriteLine("Чтобы продолжить,нажмите на любую клавишу");
            Console.ReadKey();

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static void SortingPoint(BD[] bd)//сортировка по среднему баллу
        {

            for (int j = 0; j < bd.Length; j++)
            {
                for (int i = 0; i < bd.Length; i++)
                {
                    if (bd[i].Id != 0)
                    {

                        if (bd[i].AvgMark < bd[j].AvgMark)// сравнение между средними баллами
                        {
                            BD point = bd[i];//меняем пользователей местами
                            bd[i] = bd[j];

                            bd[j] = point;
                        }


                    }


                }

            }

            for (int i = 0; i < bd.Length; i++)
            {
                if (bd[i].Id != 0)
                {
                    ToString(bd[i]);//ввывод пользователей
                }
            }

            Console.WriteLine("Чтобы продолжить,нажмите на любую клавишу");
            Console.ReadKey();

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //поиск по имени
        static void NamePoisk(BD[] bd)
        {

            bool problem = false;

            string delite = "";

            while (problem != true)
            {






                Console.WriteLine("Напишите одну из частей ФИО пользователя");
                string text = Console.ReadLine();


                for (int i = 0; i < bd.Length; i++)
                {
                    if (bd[i].Id != 0)
                    {
                        string[] name = bd[i].FullName.Split(" ");
                        for (int j = 0; j < name.Length; j++)
                            if (name[j] == text)
                            {
                                ToString(bd[i]);
                                delite = bd[i].Institute;
                            }
                    }


                }


                if (delite == "")
                {
                    Console.WriteLine("Данного пользователя не существует в базе данных либо он был удален" +
                           "попробуйте еще раз");

                }


                Console.Write("\nЧтобы завершить поиск пользователя нажмите Esc,чтобы продолжить поиск пользователей,нажмите любую другйю клавишу\n");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Write("\n Заввершается поиск пользователей!");

                    problem = true;
                }


            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //поис пользователей с минимальным и максимальным среднем баллом
        static void MaxOrMin(BD[] bd)
        {
            float minavg = bd[1].AvgMark;

            int min = 1;

            float maxavg = bd[1].AvgMark;
            int max = 1;

            Console.Write("Пользователи с минимальным среднем баллом\n");
            for (int i = 1; i < bd.Length; i++)
            {

                if ((minavg > bd[i].AvgMark) & (bd[i].Id != 0))
                {
                    minavg = bd[i].AvgMark;


                }


            }
            for (int i = 1; i < bd.Length; i++)
            {

                if ((minavg == bd[i].AvgMark) & (bd[i].Id != 0))
                {
                    min = i;
                    ToString(bd[min]);


                }


            }

            Console.Write("Пользователи с максимальным среднем баллом\n");
            for (int i = 0; i < bd.Length; i++)
            {
                if ((maxavg < bd[i].AvgMark) & (bd[i].Id != 0))
                {
                    maxavg = bd[i].AvgMark;
                }
            }
            for (int i = 0; i < bd.Length; i++)
            {
                if ((maxavg == bd[i].AvgMark) & (bd[i].Id != 0))
                {
                    max = i;
                    ToString(bd[max]);
                }
            }
            Console.WriteLine("Чтобы продолжить,нажмите на любую клавишу");
            Console.ReadKey();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void Savebd(BD[] bd)//после каждого дополнения,мы сохраняем файл

        {
            string line;

            StreamReader sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                string[] file = line.Split(' ');
                try
                {
                    bd[int.Parse(file[0])] = new BD(int.Parse(file[0]), (file[1] + " " + file[2] + " " + file[3]), DateTime.ParseExact(file[4], "dd.MM.yyyy", CultureInfo.InvariantCulture), file[5], file[6], file[7], float.Parse(file[8]));
                }
                catch
                {
                    Console.WriteLine("Ошибка в базе данных. Возможно,что данные одного из пользователей не верны. Проверте!!! ");

                }
                line = sr.ReadLine();


            }

        }
        static void PoickAvg(BD[] bd)//поиск пользователей с одинаковыми средними баллами
        {

            int q = 0;
            int f = 0;
            int a = 0;
            for (int i = 1; i < bd.Length; i++)
            {

                for (int j = 1; j < bd.Length; j++)
                {
                    if ((bd[j].Id != 0) & (bd[i].Id != 0))
                    {
                        if ((bd[i].AvgMark == bd[j].AvgMark) & (i != j) & (i > j))
                        {
                            q = 1;
                            f = i;
                            a = j;
                            Console.WriteLine("Пользователи с одинаковыми средними баллами:");
                            ToString(bd[f]);
                            ToString(bd[a]);

                        }
                    }
                }

            }
            if (q == 0)
            {
                Console.Write("Пользователей с одинаковоми средними баллами нет\n");
            }

        }
        static void PoickUsers(BD[] bd)
        {
          
            int count = 0;
          
            for (int i = 0; i <  bd.Length  ; i++)
            {
                for (int j = 0; j < bd.Length; j++)
                {
                    if (bd[i].FullName == bd[j].FullName & bd[i].Id != bd[j].Id & i<j)
                    {
                        count++;
                        Console.WriteLine("Найдены совпадения по именам:");
                        ToString(bd[i]);
                        ToString(bd[j]);
                        Console.WriteLine("1)Удаление 1-й записи, 2)Удаление 2-й записи.3)Отмена");

                        bool flag = false;
                        while (flag == false)
                        {
                            Console.Write("Ввод: ");
                            string answer = Console.ReadLine();
                            if (answer == "1")
                            {
                                Delete(bd, i);
                                Savebd(bd);
                                flag = true;
                            }
                            else if (answer == "2")
                            {
                                Delete(bd, j);
                                Savebd(bd);
                                flag = true;
                            }
                            else if (answer == "3")
                            {

                                flag = true;
                            }

                            else if (answer != "2" & answer != "1")
                            {
                                Console.WriteLine("Неверный ввод");
                                Console.WriteLine("Повторите попытку:");
                            }

                        }
                    }

                    
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Совпадения не найдены");
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();


        }

        static void  Delete(BD[] bd, int n)//удаляет выбранного пользователя 
        {

            Console.WriteLine("Введите все данные пользователя,которого хотите удалить");
            string id =Convert.ToString(bd[n].Id);
            string fullname = Convert.ToString(bd[n].FullName );
            string BirthdayDate =Convert.ToString (bd[n].BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
            string inst = Convert.ToString(bd[n].Institute );
            string group = Convert.ToString(bd[n].Group );
            string course = Convert.ToString(bd[n].Course );
            string avg = Convert.ToString(bd[n].AvgMark);
           

            string text =id+" "+fullname+" "+BirthdayDate+" "+inst+" "+group+" "+course+" "+avg;
            Console.Write(text);
            string tempFile = Path.GetTempFileName();//Создает на диске временный пустой файл с уникальным именем и возвращает полный путь этого файла.

            using (var sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt"))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != text)
                        {
                            sw.WriteLine(line);


                        }


                    }

                    sw.Close();
                }
                sr.Close();
            }
            Console.WriteLine("\nДанные пользователя удалены");

            File.Delete(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");
            File.Move(tempFile, @"/Users/macbook/Projects/herbvliujsnerpighnd/Number4/Laboratory_Work2 — копия4.txt");


        }

    

    }
}