namespace Singleton
{
    public class Logger
    {
        private Logger() {}

        private static Logger instance = null;
        public static Logger Instance
        {
            get {
                if (instance == null)
                    instance = new Logger();
                return instance;
            }
        }
    }
}