using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World;

namespace Hello_World_NUnit_Test
{
    [TestClass]
    public class HelloWorldViewModelTests
    {
        HelloWorldViewModel hw;

        [TestInitialize]
        public void initializeTest()
        {
            hw = new HelloWorldViewModel();
        }

        [TestMethod]
        public void TestHelloWorldMessageProperty()
        {
            Assert.AreEqual(hw.helloWorldViewModel, string.Empty);
            const string msg = "Test String";
            hw.helloWorldViewModel = msg;
            Assert.AreEqual(hw.helloWorldViewModel, msg);
            Assert.AreNotEqual(hw.helloWorldViewModel, null);
        }
    }
}
