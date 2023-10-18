using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json;



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
        float AvgMark,
         string Formoftraining,
         string Leveloftraining,
         int Numberofarrears)
            {
                this.Id = Id;//первый параметр соответсвует классу второй конструктору 
                this.FullName = FullName;
                this.BirthdayDate = BirthdayDate;
                this.Institute = Institute;
                this.Group = Group;
                this.Course = Course;
                this.AvgMark = AvgMark;
                this.Formoftraining = Formoftraining;
                this.Leveloftraining = Leveloftraining;
                this.Numberofarrears = Numberofarrears;
            }


            public int Id;
            public string FullName;
            public DateTime BirthdayDate;
            public string Institute;
            public string Group;
            public string Course;
            public float AvgMark;
            public string Formoftraining;
            public string Leveloftraining;
            public int Numberofarrears;
        }

            public class BD_json
            {
                public int Id { get; set; }
                public string FullName { get; set; }
                public DateTime BirthdayDate { get; set; }
                public string Institute { get; set; }
                public string Group { get; set; }
                public string Course { get; set; }
                public float AvgMark { get; set; }
                public string Formoftraining { get; set; }
                public string Leveloftraining { get; set; }
                public int Numberofarrears { get; set; }
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
                StreamReader sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] file = line.Split(' ');
                    try
                    {
                        bd[int.Parse(file[0])] = new BD(int.Parse(file[0]), (file[1] + " " + file[2] + " " + file[3]), DateTime.ParseExact(file[4], "dd.MM.yyyy", CultureInfo.InvariantCulture), file[5], file[6], file[7], float.Parse(file[8]),file[9],file[10],(int.Parse(file[11])));
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
                                           "\n 6)Нахождение пользователей по максимальному баллу или минимальному(нажмите 6)" +
                                           "\n 7)Поиск одинаковых пользователей(нажмите 7) " +
                                           "\n 8)Поиск пользователей с одинаковыми средними баллами(нажмите 8) " +
                                           "\n 9)JSON(нажмите 9)"+
                                           "\n 0)Завершить работу программы(нажмите 0)") ;

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
                        case 9:
                            {
                                InOutJson(bd);
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
            string Formoftraining;
            string Leveloftraining;
            int Numberofarrears;

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

                    Console.WriteLine("-Formoftraining:");
                    Formoftraining = Console.ReadLine();

                    Console.WriteLine("-Leveloftraining:");
                    Leveloftraining = Console.ReadLine();

                    Console.WriteLine("-Numberofarrears:");
                    Numberofarrears = Convert.ToInt32(Console.ReadLine());


                    using StreamWriter stream = new StreamWriter(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt", true);//метод,который открывает файл и вписывает в него то что хочет пользователь
                    stream.WriteLine($"{ Id} {FullName} {BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)} {Institute} {Group} {Course} {AvgMark} {Formoftraining} {Leveloftraining} {Numberofarrears} ");
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
        static void DeleteUser(BD[] bd)
        {
            Console.WriteLine("Введите айди пользователя,которого хотите удалить");
            int x = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < bd.Length; i++)
            {
                if (bd[i].Id != 0 & bd[i].Id == x)
                {
                    string id = Convert.ToString(bd[i].Id);
                    string fullname = Convert.ToString(bd[i].FullName);
                    string BirthdayDate = Convert.ToString(bd[i].BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
                    string inst = Convert.ToString(bd[i].Institute);
                    string group = Convert.ToString(bd[i].Group);
                    string course = Convert.ToString(bd[i].Course);
                    string avg = Convert.ToString(bd[i].AvgMark);
                    string Formoftraining = Convert.ToString(bd[i].Formoftraining);
                    string Leveloftraining = Convert.ToString(bd[i].Leveloftraining);
                    string Numberofarrears = Convert.ToString(bd[i].Numberofarrears);

                    text = id + " " + fullname + " " + BirthdayDate + " " + inst + " " + group + " " + course + " " + avg + " " + Formoftraining + " " + Leveloftraining + " " + Numberofarrears;
                }
            }


                string tempFile = Path.GetTempFileName();//Создает на диске временный пустой файл с уникальным именем и возвращает полный путь этого файла.

            using (var sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt"))
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

            File.Delete(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");
            File.Move(tempFile, @"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");
            Console.WriteLine("Чтобы продолжить,нажмите на любую клавишу");
            Console.ReadKey();
        }
        static void SortingPoint(BD[] bd)
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
        static void ToString(BD bd)
        {
            Console.WriteLine($"- id: { bd.Id}\n" +
                                                $"-FullName: {bd.FullName  }\n" +
                                                $"-BirthdayDate: {bd.BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture) }\n" +
                                                $"-Institute: {bd.Institute}\n" +
                                                $"-Group: {bd.Group }\n" +
                                                $"-Course: {bd.Course }\n" +
                                                $"-AvgMark: {bd.AvgMark }\n" +
                                                $"-Formoftraining: {bd.Formoftraining}\n" +
                                                $"-Leveloftraining: {bd.Leveloftraining}\n" +
                                                $"- Numberofarrears: {bd.Numberofarrears}\n\n");
          



    }
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
        static void Savebd(BD[] bd)

        {
            string line;
           
            StreamReader sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                string[] file = line.Split(' ');
                try
                {
                    bd[int.Parse(file[0])] = new BD(int.Parse(file[0]), (file[1] + " " + file[2] + " " + file[3]), DateTime.ParseExact(file[4], "dd.MM.yyyy", CultureInfo.InvariantCulture), file[5], file[6], file[7], float.Parse(file[8]), file[9], file[10], (int.Parse(file[11])));
                }
                catch
                {
                    Console.WriteLine("Ошибка в базе данных. Возможно,что данные одного из пользователей не верны. Проверте!!! ");

                }
                line = sr.ReadLine();


            }

        }
        static void PoickAvg(BD[] bd)
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
                            f = j;
                            a = i;
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
            Console.WriteLine("Чтобы продолжить,нажмите на любую клавишу");
            Console.ReadKey();

        }
        static void PoickUsers(BD[] bd)
        {
            int k = 0;
            int count = 0;
            for (int i = 1; i < bd.Length; i++)
            {
                if (bd[i].Id != 0)
                {
                    k++;
                }
            }

            for (int i = 0; i < bd.Length; i++)
            {
                for (int j = 0; j < bd.Length; j++)
                {
                    if (bd[i].FullName == bd[j].FullName & bd[i].Id != bd[j].Id & i < j)
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
        static void Delete(BD[] bd, int n)
        {

            Console.WriteLine("Введите все данные пользователя,которого хотите удалить");
            string id = Convert.ToString(bd[n].Id);
            string fullname = Convert.ToString(bd[n].FullName);
            string BirthdayDate = Convert.ToString(bd[n].BirthdayDate.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));
            string inst = Convert.ToString(bd[n].Institute);
            string group = Convert.ToString(bd[n].Group);
            string course = Convert.ToString(bd[n].Course);
            string avg = Convert.ToString(bd[n].AvgMark);
            string Formoftraining=Convert.ToString(bd[n].Formoftraining);
            string Leveloftraining= Convert.ToString(bd[n].Leveloftraining); 
            string  Numberofarrears=Convert.ToString(bd[n].Numberofarrears);

            string text = id + " " + fullname + " " + BirthdayDate + " " + inst + " " + group + " " + course + " " + avg+" "+Formoftraining+" "+Leveloftraining+" "+Numberofarrears;
           
            string tempFile = Path.GetTempFileName();//Создает на диске временный пустой файл с уникальным именем и возвращает полный путь этого файла.

            using (var sr = new StreamReader(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt"))
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

            File.Delete(@"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");
            File.Move(tempFile, @"/Users/macbook/Projects/herbvliujsnerpighnd/Number5/Laboratory_Work2 — копия5.txt");

        }
        static void InOutJson(BD[] bd)
        {
            Console.WriteLine(" Выбор действий с базой данных:" +
                "\n 1)сериализовать" +
                "\n 2)десериализовать");
            bool mood = false;
            while (mood != true)
            {
                int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            {
                                try
                                {
                                    File.WriteAllText("/Users/macbook/Projects/herbvliujsnerpighnd/Number5/user.json", string.Empty );
                                    StreamWriter sw = new StreamWriter("/Users/macbook/Projects/herbvliujsnerpighnd/Number5/user.json", true,Encoding.UTF8);
                                for (int i = 0; i < bd.Length; i++)
                                {
                                    if (bd[i].Id != 0)
                                    {
                                        BD_json person = new BD_json();
                                        person.Id = bd[i].Id;
                                        person.FullName = bd[i].FullName;
                                        person.BirthdayDate = bd[i].BirthdayDate;
                                        person.Institute = bd[i].Institute;
                                        person.Group = bd[i].Group;
                                        person.Course = bd[i].Course;
                                        person.AvgMark = bd[i].AvgMark;
                                        person.Formoftraining = bd[i].Formoftraining;
                                        person.Leveloftraining = bd[i].Leveloftraining;
                                        person.Numberofarrears = bd[i].Numberofarrears;
                                        string jsonString = JsonSerializer.Serialize(person);
                                        sw.WriteLine(jsonString);
                                        mood = true;
                                    }

                                }

                                      
                                        sw.Close();
                                        Console.WriteLine();
                                        Console.WriteLine("Сериализация завершена");
                                        Console.WriteLine("Для продолжения нажмите любую клавишу");
                                        Console.ReadKey();
                                    
                                }


                                catch
                                {
                                    Console.WriteLine("Ошибка Сериализации");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                                Console.ReadKey();
                                }

                              
                                break;
                            }

                    



                   
                        case 2:
                            {
                                
                                try
                                {
                                    BD_json  person = new BD_json ();
                                    string line;
                                    StreamReader sw = new StreamReader("/Users/macbook/Projects/herbvliujsnerpighnd/Number5/user.json");
                                
                                    line = sw.ReadLine();
                                    for (int j = 1; j < bd.Length; j++)
                                    {

                                        if (bd[j].Id != 0)
                                        {
                                            person = JsonSerializer.Deserialize<BD_json>(line);
                                            bd[person.Id].Id = person.Id;
                                            bd[person.Id].FullName = person.FullName;
                                            bd[person.Id].BirthdayDate = person.BirthdayDate;
                                            bd[person.Id].Institute = person.Institute;
                                            bd[person.Id].Group = person.Group;
                                            bd[person.Id].Course = person.Course;
                                            bd[person.Id].AvgMark = person.AvgMark;
                                            bd[person.Id].Formoftraining = person.Formoftraining;
                                            bd[person.Id].Leveloftraining = person.Leveloftraining;
                                            bd[person.Id].Numberofarrears = person.Numberofarrears;
                                             line = sw.ReadLine();
                                            ToString(bd[j]);
                                        }
                                    }
                                    sw.Close();
                                
                                    Console.WriteLine(person);
                                    Console.WriteLine();
                                    Console.WriteLine("Десериализация завершена");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу...");
                                    Console.ReadKey();
                                
                                }
                                catch
                                {
                                    Console.WriteLine("Ошибка Десериализации");
                                    Console.WriteLine("Для продолжения нажмите любую клавишу...");
                                    Console.ReadKey();
                                }
                                Savebd (bd);
                                mood = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("Выбран неправильный режим работы");
                                break;
                                    
                            }
                    }
              
            }


        }


    }
}