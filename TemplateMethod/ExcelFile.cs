using System;

namespace TemplateMethod
{
    public class ExcelFile : DataProcessor
    {
        public override void Read()
        {
            Console.WriteLine("Reading excel file...");
        }

        public override void Process()
        {
            Console.WriteLine("processing excel file...");
        }
    }
}