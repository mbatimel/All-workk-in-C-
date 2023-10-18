using System;
using System.Collections.Generic;

namespace Задние_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var person = new Dictionary<string, string>();
            Console.WriteLine("Добавьте пользователей с их номерами телефонов");
            AddPersone(person);
            Console.WriteLine("Введите номер телефона пользователя для его поиска");
            LockedPerson(person);
        }
        /// <summary>
        /// Добавление пользователя
        /// </summary>
        static void AddPersone(Dictionary<string, string> person)
        { bool add = false;
            while(add!=true){
                Console.WriteLine("Введите номер телефона пользователя");
                string dt = Console.ReadLine();
                Console.WriteLine("Введите его Ф.И.О");
                string dt2 = Console.ReadLine();
                if (dt == "" && dt2 == "")
                {
                    break;
                }
                person.Add(dt, dt2);
                dt = "";
                dt2 = "";
            }
        }
        /// <summary>
        /// Поиск человека
        /// </summary>
        static void LockedPerson(Dictionary<string, string> person)
        {
            string V;
            while (true)
            {
                string dt2 = Console.ReadLine();
                var phoneExists1 = person.ContainsKey(dt2);
                if (phoneExists1 == true)
                { person.TryGetValue(dt2, out V);
                    Console.WriteLine(V);
                    break;
                }
                else { Console.WriteLine("Введите номер телефона заново"); }
            }

        }
    }


}
