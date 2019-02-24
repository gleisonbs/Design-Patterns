using System;

namespace Factory
{
    public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}