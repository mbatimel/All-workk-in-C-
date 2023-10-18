using System;

namespace перечисление
{
    class Program
    {//если не присваивать тип перечислению, то он по определению будет int 
        enum Opiration//вызывается перечисление,чтобы задать значение констант
        {
            Add,//если мы не задаем значение константам ,то они принимают значение от 0 до последней константы(0)
            Subtrack,//(1)если мы зададим выражение константе к примеру 100 то каждая последующая константа будет задаваться значением на 1 больше
            Myltiplym,//(2) 101
            Divide,//(3)102
        }//на данный момент каждая константа будет соответствовать определенной операции 
        static void ApplayOpiration(double x,double y,Opiration op)
        {
            double  result = 0.0;
            switch(op)
            {
                case Opiration.Add:
                    result = x + y;
                    break;
                case Opiration.Subtrack:
                    result = x - y;
                    break;
                case Opiration.Myltiplym:
                    result = x * y;
                    break;
                case Opiration.Divide:
                    result = x / y;
                    break;



            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            double c = 9.8;
            double v = 11.11;
            ApplayOpiration(c, v, Opiration.Add);
            ApplayOpiration(c, v, Opiration.Subtrack);
            ApplayOpiration(c, v, Opiration.Myltiplym );
            ApplayOpiration(c, v, Opiration.Divide );
            Console.WriteLine();
        }
    }
}
