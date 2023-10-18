using System;

namespace Lib
{
    /* public class Queue
     {
         public Queue()
         {

         }
     }

     public class Deque
     {
         public Deque()
         {

         } 
     }

     pc
     {
         public Stack()
         {

         }
     }*/
    public  class Stack1
    {
       
        public   string   Movestack(string x,string c,int z)

        {
            string a = " ";
            
            string[] Add = x.Split(' ') ;
           
           

            foreach(string q in Add )
            {
                a = a + q;
            }


            return a;
            
            
        }
        
    }
}
