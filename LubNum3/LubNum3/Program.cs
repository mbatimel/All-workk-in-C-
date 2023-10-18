using System;
using System.Collections.Generic;

namespace LubNum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("лощ", 1000);
            client.Put(500);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(5000);
            Console.WriteLine(client.CurrentSum);


        }
    }
    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }
    interface IClient
    {
        string Name { get; set; }
    }
    interface IClientAccount:IAccount,IClient
    {
        void GetIncime();
    }
    class Client : IClient, IAccount
    {

        int _sum;
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }

        public string Name { get; set; }
        public void Put(int sum)
        {
        _sum+=sum;
            }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
                _sum -= sum;
            else Console.Write("недостаточно денег, на счету:");
        }
    }
    class VipClient : IClientAccount//пример что можно в один интерфейс пихнуть несколько
    {
        public int CurrentSum => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetIncime()
        {
            throw new NotImplementedException();
        }

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }
    }

}
