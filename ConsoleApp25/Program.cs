using System;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A7");
            audi.Start();
            Console.WriteLine(audi.GetInfoCar());
            audi.IncreaseRpm(2000);
            Console.WriteLine(audi.GetInfoCar());
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            audi.IncreaseRpm(2000);
            Console.WriteLine(audi.GetInfoCar());


            Car tesla = new Car("Tesla Model X");
            Console.WriteLine(tesla.GetInfoCar());


            Console.WriteLine("Hello World!");
        }
    }
}
