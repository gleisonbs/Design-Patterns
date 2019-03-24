using System;

namespace SPLib
{
    public class Duck : IFlyStrategy, IWalkStrategy
    {
        IWalkStrategy WalkStrategy = null;
        IFlyStrategy FlyStrategy = null;
        public Duck(IWalkStrategy ws, IFlyStrategy fs)
        {
            this.WalkStrategy = ws;
            this.FlyStrategy = fs;
        }

        public string Fly()
        {
            return FlyStrategy.Fly();
        }

        public string Walk()
        {
            return WalkStrategy.Walk();
        }
    }
}
