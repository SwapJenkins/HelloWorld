using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckHelloWorldTest()
        {
            Assert.AreEqual("Hello world", Program.CheckHelloWorld());

        }
    }
}