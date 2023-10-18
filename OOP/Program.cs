using System;

namespace OOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool Result = false;
            Console.WriteLine("Добро пожаловать в автосервис");
            
            Console.WriteLine(" Давайте проверим какие проблемы у него с двигателем");
            Console.WriteLine("Начнем проверку:");
            Console.WriteLine("укажите количество поршней");
            int PistonsNumbers = int.Parse(Console.ReadLine());
            while (Result == false)
            {
                if(PistonsNumbers<9)
                {
                    Result = true;
                }
                if(PistonsNumbers>8)
                {
                    Console.WriteLine("Двигателя с таким количество поршней не существует. Попробуйте еще раз");
                    PistonsNumbers = int.Parse(Console.ReadLine());
                    Result = false;
                }
            }
            Console.WriteLine("Вы слышите посторонние стуки в автомобиле при заведенном двигателе?");
            string PistonsErrors=Console.ReadLine();
            Console.WriteLine("Машина заводится без перебоев или с перебоями?");
            string Altemator = Console.ReadLine();
            Console.WriteLine("Укажите радиус колес(Данные нужны для рассчета мощности автомобиля");
            int SparkPlug=int.Parse(Console.ReadLine());
            Console.WriteLine("Проверим обьем воздуха впускаемого машиной,заверенного на заводе" +
                " укажите эти данные(куб.см)");
            int tinteIManifoid = int.Parse(Console.ReadLine());
            InspectorOfTheMechanic indexer = new InspectorOfTheMechanic( PistonsNumbers, tinteIManifoid, PistonsErrors, Altemator, SparkPlug);
            indexer.result();



        }
       
        

    }
 
    
}
