using System;

namespace PPLib
{
    public class LazyBookParserProxy : IBookParser
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

        public LazyBookParserProxy() {}
    }
}
