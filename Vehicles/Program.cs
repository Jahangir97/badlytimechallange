using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Passat", "AxsInfinity", "Blue",123 ,41 );

            Console.WriteLine(bus.Info());
        }
    }
}
