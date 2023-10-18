using System;
using Lib;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            string x=Console.ReadLine();
            string c =Console.ReadLine();
            int v = 1;
            Stack1 i = new Stack1();
            string result = i.Movestack(x, c, v);


            Console.WriteLine(result );
            
        }
    }
}
