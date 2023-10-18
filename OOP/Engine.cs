using System;
namespace OOP
{
   public class Engine
    {
    private int  NumbersOfPistons;
        private string Altemator;
        private int Altematorerrors;
       
        private  int Error;
        private string NumbersOfPistonsErrors;
        private int pay;

        public Engine(int NumbersOfPistons, string NumbersOfPistonsErrors, string Altemator)
        {

            this.NumbersOfPistons = NumbersOfPistons;
           
            this.NumbersOfPistonsErrors = NumbersOfPistonsErrors;
            this.Altemator = Altemator;
         

        }




       
        public int setNumberOfPistons()
        {
            pay = pay + 2200;
             return NumbersOfPistons* 2200; 
                 
        }
       
        public int setNumbersOfPistonsErrors()
        {
            if(NumbersOfPistonsErrors=="нет")
            { Error = 0; }
            else { Error =30000;
                pay = pay+30000;
            }
            return Error;
        }
        
        

        public int SetAltemator()
        {
            if (this.Altemator == "с перебоями")
            {
                this.Altematorerrors = 2000;
                pay = pay + 2000;

            }
            if (this.Altemator == "С перебоями")
            {
                this.Altematorerrors = 2000;
                pay = pay + 2000;

            }
            if (this.Altemator == "Без перебоев")
            {
                this.Altematorerrors = 0;

            }
            if (this.Altemator == "без перебоев")
            {
                this.Altematorerrors = 0;

            }

            return Altematorerrors;
        }
       

        public int Pay()
        {
            return pay;
        }
       
        }
    }

