using System;

namespace SPLib
{
    public class CarefulFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "Flying carefully";
        }
    }
}
