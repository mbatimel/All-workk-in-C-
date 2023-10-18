using System;
using System.Collections.Generic;

namespace WorkInUniverseti
{
  public  class Helper
    {
        static List<string> Sports;
        static List<string> Sportsnam { get; set; }

         public static  bool  CompareSorts(string type)
        {
           foreach (var i in Sports)
            {
                if (i.Equals(type)) ;
            }
            return false;
        }
        public static bool Abort()
        {

            Console.WriteLine("хотите продолжить?\n клавиша Escape-выйти,любая другая клавиша-продожить");
                Console.ReadKey(Console.ReadKey().Key == ConsoleKey.Escape);
            else return false;
        }
    }

}
