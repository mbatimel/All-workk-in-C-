using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            List<Person> person = new List<Person>();
            Console.WriteLine("Введите данные объекта");

            while(true)
            {
                Console.WriteLine("Ф.И.О");
                string dt=Console.ReadLine();
                Console.WriteLine("Название улицы");
                string dt2 = Console.ReadLine();
                Console.WriteLine("Номер дома");
                string dt3 = Console.ReadLine();
                Console.WriteLine("Номер квартиры");
                string dt4 = Console.ReadLine();
                Console.WriteLine("Номер телефона");
                string dt5 = Console.ReadLine();
                Console.WriteLine("Номер домашнего телефона");
                string dt6 = Console.ReadLine();
                person.Add(new Person(dt, dt2, dt3, dt4, dt5, dt6));
                
                Console.WriteLine("Если хотите продолжить ввод новых персонажей,то нажмите enter");
                key = Console.ReadKey();

                if(key.Key!=ConsoleKey.Enter)
                {
                    Console.WriteLine("Ввод пользователей завершон, проверте файл");
                    break;
                }
            }
            XmlFileCreate(person);
        }
        static void XmlFileCreate(List<Person> person)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            Stream fl = new FileStream("xmfl.xml", FileMode.Create, FileAccess.Write);
            xml.Serialize(fl, person);
            fl.Close();
        }

    }
   public class Person
    {
        public string FullName;
        public string Street;
        public string NumberHome;
        public string ApartmentNumber;
        public string TelefonNumber;
        public string HouseTelefonNumber;
        Person() { }
         public Person(string FullName, string Street, string NumberHome, string ApartmentNumber, string TelefonNumber, string HouseTelefonNumber)
        {
            this.FullName = FullName;
            this.Street = Street;
            this.NumberHome = NumberHome;
            this.ApartmentNumber = ApartmentNumber;
            this.TelefonNumber = TelefonNumber;
            this.HouseTelefonNumber = HouseTelefonNumber;
        }

    }
}
