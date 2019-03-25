using System;

namespace PPLib
{
    public class BookParserProxy : IBookParser
    {
        private BookParser bookParser = null;
        public int PageCount
        {
            get
            {
                if (bookParser is null)
                    bookParser = new BookParser();
                return bookParser.PageCount;
            }
        }

        public BookParserProxy() {}
    }
}
