
namespace API
{
    public class HelloWorldController
    {
        private readonly IWriter _writer;

        public HelloWorldController(IWriter writer)
        {
            _writer = writer;
        }

        public void WriteOut()
        {
            _writer.WriteOut();
        }
    }
}
