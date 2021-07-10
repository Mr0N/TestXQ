using System;

namespace TestXQ
{
    class BaseX
    {
        public void Start()
        {
            if (this is GoodY)
            {
                var result = this as IGoodInterface;
                result.StartGoodWorking();
            }
        }
    }
    class GoodY : BaseX, IGoodInterface
    {
        public void StartGoodWorking() {
            Console.WriteLine("GoodY StartGoodWorking");
        }
    }
    interface IWork
    {
        public void StartWorkingWork();
    }
    interface IGoodInterface
    {
        public void StartGoodWorking();
    }
    class Program
    {
        static void Main(string[] args)
        {
            new GoodY().Start();
            Console.ReadKey();
        }
    }
}
