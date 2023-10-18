using System;

namespace структуры

{//структуры у нас определяются в пространстве manespace и они хранят данные и могут определять действия методов
    // и при надобности структура будет обозначать тип переменной
    //после того как мы задали в типе Main имя переменной с типом структуры,мы можем обращаться к самой структуре
    //чтобы иметь доступ к переменным и методам в структуре,нам нужно им присвоить тип public
    struct User
    {
        public string name;
        public int age;
        //для сокращения кода мы можем использовать параметры
        public User(string n, int a)
        {
            name = n; age = a;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"name={name}   age={age}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                //мы можем задавать значение переменной в структуре,можем запрашивать значение выражениея из структуры
                User user;
                /*присвоение */
                user.name = "Tom";
                user.age = 25;
                /*запрос */
                int d = user.age;
                /*вывод работы метода с веденными в него значениями*/
                user.DisplayInfo();
                Console.WriteLine(d);
                User[] users = new User[2];
                users[0].name = "Bob";
                users[0].age = 5;
                users[1].name = "misha";
                users[1].age = 18;
                foreach (User userus in users)
                {
                    userus.DisplayInfo();
                }//вот упращенное действие со структурой

                User Pasha = new User("Pasha", 17);
                Pasha.DisplayInfo();

                Console.ReadKey();
            }
        }
    }
}
