using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile =  new ExcelFile();
            excelFile.ReadProcessAndSave();

            TextFile textFile =  new TextFile();
            textFile.ReadProcessAndSave();
        }
    }
}
