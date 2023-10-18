using System;
using System.Collections.Generic;
using System.Text;
namespace WorkInUniverseti

{
    public class Sportman
    {
        
         public string Name { get; set; }
        public string Surname { get; set; }
        public string Sport { get; set; }
        public  List<double> Score { get; set; }

        public Sportman(string name,string surname,string sport,List<int> score)
        {

        }

        public Sportman()
        {
        }
        public double AvgScore()
            {
            return (Score[0] + Score[2] + Score[3]) / 3.0;


        }
        public double SumScore()
        {
            return (Score[0] + Score[2] + Score[3]);

        }

        public override string ToString()
        {
            return new ToString(Name +'\n'+ Surname +'\n'+Sport+'\n'+ScoreToString());
        }
        private string ScoreToString()
        {
            string res = "";
            foreach(var i in res)
            {
                res += i + ' ';

            }
            return res;
        }




        /*Console.WriteLine("введение параметров первого массива:");
        Console.Write("спортсмен: ");
        string x = Console.ReadLine();
        Console.Write("вид спорта: ");
        string y = Console.ReadLine();


        //ввод первого массива
        string[,] SeconsdArray = new string[y, x];
        {
            for (int i = 0; i < y.Length ; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    Console.WriteLine("X " + j + "Y " + i);

                    SeconsdArray[i, j] = Console.ReadLine());


                }
                Console.WriteLine();
          }

             for (int i = 0; i<y.Length ; i++)
            {
                for (int j = 0; j<x.Length; j++)
                {
                    Console.WriteLine("X " + j + "Y " + i);

                    SeconsdArray[i, j] = Console.ReadLine());


                }*/

    }
}
