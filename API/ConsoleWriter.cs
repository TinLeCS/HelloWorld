using System;

namespace API
{
    public class ConsoleWriter : IWriter
    {
        public void WriteOut()
        {
            Console.WriteLine("Hello World");
        }
    }
}
