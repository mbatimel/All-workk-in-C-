using System;
using System.Collections.Generic;

namespace WorkInUniverseti
{
    class Menu
    {
        
            private string command;
        public List<Sportman> Sportsmans { get; set; }
            
        public Menu()
        {

        }
        void Fill()

        {
            Console.WriteLine("виды спорта");
            Sports = new List<string>();
            for(int i=0;i<3;i++)
            {
                string type = Console.ReadLine();
            }
            do {
                List<int> score = new List<int>();
                Console.WriteLine("вводим спортсмена");
                string Name = Console.ReadLine();
                string Surname = Console.ReadLine();
                String Sport = Console.ReadLine();
                if (!Helper.CompareSorts(Sport))
                {
                    Console.WriteLine("Неккоректно ввиден вид спорта,вводите спортсмена заново");
                    continue;//узнать шо це таки
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"введите балл {i + 1}-го судьие:");
                    bool trp32 = Int32.TryParse(Console.ReadLine(), out int el);
                    score.Add(el);
                }
                Sportman sp = new Sportman(Name, Surname, Sport, score);
                Sportman.Add(sp);
                

            } while (Helper.Abort);
        }

        public void Main()
        {
            bool correct = false;
            while(!correct )
            {
                Console.WriteLine(" команды:+" +
                    " \n1-выбрать спортсмена с наибольшим средним баллом" +
                    "\n2-выбрать спортсмена с минимальным суммарным баллом" +
                    "\n3-вывести спортсменов по виду спорта" +
                    "\n4-анализ данных");
                Console.WriteLine("Введите команду");
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        {
                            Command1();
                            correct = true;

                            break;
                        }
                    case "2":
                        {
                            Command2();
                            correct = true;
                            break;
                        }
                    case "3":
                        {
                            Command3();
                            correct = true;
                            break;
                        }
                    case "4":
                        {
                            Command4();
                            correct = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите нормально опцию!");
                            break;
                        }
                }
            }
        }
        private void Command1()
        {
            foreach(var i in Sportsmans )
            {

            }

        }
        private void Command2()
        {

        }
        private void Command3()
        {

        }
        private void Command4()
        {

        }
    }
}
