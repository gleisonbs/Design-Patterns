using System;

namespace Singleton
{
    class TestLogger
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            Console.WriteLine($"logger 1: {logger1.GetHashCode()}");
            Console.WriteLine($"logger 2: {logger2.GetHashCode()}");
        }
    }
}
