using System;

namespace работа_в_универе
{
    class Program
    {
        static void Main(string[] args)
        {
            bomz Seva = new bomz();
            Seva.Name = "мужик сева";
            Seva.Age = 50;
            Seva.sex = "на стеройдах";
            //Seva.sayhellow();
           // Seva.nasat();


            goodmean man = Seva;//upcast - это метод  по типу privat  в классе,то есть код не будет наследоваться
            bool isbomz = man is goodmean ;
            if (isbomz)
            {
                goodmean bomz = (goodmean )man;
            }

            // или  так name.sayhellow ();
            Console.ReadKey();
            
          
            
            
        }
    }
}
