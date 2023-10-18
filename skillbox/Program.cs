using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace skillbox
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Key2;
            Console.WriteLine("Выберете режим работы:" +
                "\n1)Чтение файла" +
                "\n2)Запись данных в файл");
           bool close=false;
            while (close!=true)
            {
                Key2=Console.ReadKey();

                if (Key2.Key== ConsoleKey.D1)
                {
                    CheckLifeFile();
                    Console.WriteLine("Активирован режим чтения данных из файла");
                    ReadBDFile();
                    Console.WriteLine("Чтобы завершить работу программы, нажмите Esc или выберете режим, для продолжения работы");

                }
                if (Key2.Key == ConsoleKey.D2)
                {
                    CheckLifeFile();
                    Console.WriteLine("Активирован режим записи данных в файл");
                    WriteBDFile();
                    Console.WriteLine("Чтобы завершить работу программы, нажмите Esc или выберете режим, для продолжения работы");

                }
                if (Key2.Key == ConsoleKey.Escape)
                {
                    close = true;
                }

            }
            Console.WriteLine("Программа завершила работу");
            Console.ReadKey();
        }
        static void ReadBDFile()
        {
            using (StreamReader sr = new StreamReader("BD.txt"))
            {
                string[] bdline = sr.ReadToEnd().Split('#');
                for (int i = 0; i < bdline.Length;i++)
                {
                    Console.WriteLine(bdline[i]);

                }
                sr.Close();
            }
        
        

        }
        static void WriteBDFile()
        {
            ConsoleKeyInfo Key2;


            using (StreamWriter write = new StreamWriter("BD.txt", true))
            {

                bool close = false;
                while (close != true)
                {
                    string bd = "";
                    Console.WriteLine("ID:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("Date write new persone:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("FullName:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("Age:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("Height:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("Birthday:");
                    bd += $"{Console.ReadLine()}#";
                    Console.WriteLine("Place of birth:");
                    bd += $"{Console.ReadLine()}";
                    write.WriteLine(bd);
                    Console.WriteLine("Чтобы продолжить,нажмите любую клавишу." +
                        "Чтобы завершить запись,нажмите ESC");
                    Key2 = Console.ReadKey();
                    if (Key2.Key == ConsoleKey.Escape)
                    {
                        close = true;
                    }
                };
                write.Close();
            }
        }
        static void CheckLifeFile()
        { 
            if(File.Exists("BD.txt")==false)
                {
                File.Create("BD.txt");
            }
            
        }
    }
}
