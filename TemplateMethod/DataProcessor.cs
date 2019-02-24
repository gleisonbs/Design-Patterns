using System;

namespace TemplateMethod
{
    public abstract class DataProcessor
    {
        public void ReadProcessAndSave()
        {
            Read();
            Process();
            Save();
        }

        public abstract void  Read();
        public abstract void Process();

        public void Save()
        {
            Console.WriteLine("Saving data to db...");
        }
    }
}