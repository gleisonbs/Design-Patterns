using System;

namespace PPLib
{
    public class BookParser : IBookParser
    {
        public int PageCount { get; } = 120;
        public BookParser()
        {
            Console.WriteLine("BookParser() called");
            // expensive computation here
        }
    }
}
