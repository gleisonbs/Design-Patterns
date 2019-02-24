using System;

namespace TemplateMethod
{
    public class TextFile : DataProcessor
    {
        public override void Read()
        {
            Console.WriteLine("Reading text file...");
        }

        public override void Process()
        {
            Console.WriteLine("processing text file...");
        }
    }
}