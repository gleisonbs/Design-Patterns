﻿using System;
using PPLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookParser bookParser = new BookParserProxy();
            Console.WriteLine(bookParser.PageCount);
        }
    }
}
