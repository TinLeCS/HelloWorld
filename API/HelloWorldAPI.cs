using System;
using System.Configuration;

namespace API
{
    public class HelloWorldAPI
    {
        public void WriteOut()
        {
            HelloWorldController writer;

            var source = ConfigurationManager.AppSettings["WritingSource"];
            switch (source.ToLower())
            {
                case "database":
                    writer = new HelloWorldController(new DatabaseWriter());
                    break;
                case "console":
                    writer = new HelloWorldController(new ConsoleWriter());
                    break;
                default:
                    throw new NotImplementedException("Not implemented writing source");
            }
            writer.WriteOut();
        }
    }
}
