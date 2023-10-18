using System;
namespace OOP
{
    public class InspectorOfTheMechanic
    {

        private int power = 4325;
        private int WorkerMoney = 15000;
        
        private int PistonsNumbers;
        private int tinteIManifoid;
        private string PistonsErrors;
       private  string Altemator;
       private int SparkPlug;

        

        public InspectorOfTheMechanic(int PistonsNumbers, int tinteIManifoid, string PistonsErrors , string Altemator, int SparkPlug)
{
           
            this.PistonsNumbers = PistonsNumbers;
            this.tinteIManifoid = tinteIManifoid;
            this.PistonsErrors = PistonsErrors;
            this.Altemator = Altemator;
            this.SparkPlug = SparkPlug;

        }





        public void result()
        {
            Engine Result = new Engine(PistonsNumbers, PistonsErrors, Altemator);
            Console.WriteLine(" |__________________________________________________________________________________________________|");
            Console.WriteLine(" |Подведем итог по вашиму заказу, выставим счет и распишем что и сколько стоит                      |");
            Console.WriteLine(" |--------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"|Стойместь осмотра всех поршней в автомобиле(2200 за 1 поршень):{Result.setNumberOfPistons()}      |");
            Console.WriteLine(" |--------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"|Стоимость за проверку лишних шумов:{Result.setNumbersOfPistonsErrors()}                           |");
            Console.WriteLine(" |--------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"|Стоймость за проверку и принадобности исправление в работе генератора:{Result.SetAltemator()}     |");
            Console.WriteLine(" |--------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"|Количество лошадиных сил в вашем двигателе:{PistonsNumbers * SparkPlug * tinteIManifoid * power}  |");
            Console.WriteLine(" |__________________________________________________________________________________________________|");
            Console.WriteLine($"ОБЩАЯ ЦЕНА:{Result.Pay() + WorkerMoney}");


           
        }

    }
}
