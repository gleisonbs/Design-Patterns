using Singleton.Extensions;

namespace Singleton
{
    public class Logger
    {
        private static Logger logger = null;
        private Logger() {}
        
        public static Logger Get()
        {
            if (logger == null)
                logger = new Logger();

            return logger;
        }
    }
}