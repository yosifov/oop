namespace OOP.SOLID.Logger.Loggers
{
    using System.Linq;
    using System.Text;

    public class LogFile : ILogFile
    {
        private StringBuilder log;

        public LogFile()
        {
            this.log = new StringBuilder();
        }

        public long Size
        {
            get
            {
                int size = 0;
                foreach (char character in from char character in this.log.ToString()
                                           where char.IsLetter(character)
                                           select character)
                {
                    size += character;
                }

                return size;
            }
        }

        public void Write(string message)
        {
            this.log.AppendLine(message);
        }
    }
}
