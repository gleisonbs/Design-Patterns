using System;
using SPLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck cityDuck = new Duck(new CarefulWalkStrategy(), new CarefulFlyStrategy());
            Duck wildDuck = new Duck(new WildWalkStrategy(), new WildFlyStrategy());
            Console.WriteLine("CityDuck:");
            Console.WriteLine(cityDuck.Walk());
            Console.WriteLine(cityDuck.Fly());
            Console.WriteLine("WildDuck:");
            Console.WriteLine(wildDuck.Fly());
            Console.WriteLine(wildDuck.Walk());
        }
    }
}
