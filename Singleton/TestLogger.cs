using System;

namespace Singleton
{
    class TestLogger
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Get();
            Logger logger2 = Logger.Get();
        }
    }
}
