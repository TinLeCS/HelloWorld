using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace API.Tests
{
    [TestClass]
    public class HelloWorldAPITests
    {
        [TestMethod]
        public void WriteOutTest()
        {
            // arrange  
            var writer = new Mock<IWriter>().Object;


            // act  
            writer.WriteOut();

            // assert  
            Assert
        }
    }
}