using API;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new HelloWorldAPI();

            api.WriteOut();

            Console.ReadLine();
        }
    }
}
