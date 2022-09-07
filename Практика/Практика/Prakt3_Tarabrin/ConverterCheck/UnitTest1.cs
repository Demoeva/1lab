using Prakt3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterCheck
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CountSysConverter test1 = new CountSysConverter(15);
            long result = test1.Convertnum(3);
            Assert.IsTrue(result == 120);
        }

        [TestMethod]
        public void TestMethod2()
        {
            CountSysConverter test2 = new CountSysConverter(900);
            long result = test2.Convertnum(5);
            Assert.IsTrue(result == 12100);
        }

        [TestMethod]
        public void TestMethod3()
        {
            CountSysConverter test3 = new CountSysConverter(345);
            long result = test3.Convertnum(7);
            Assert.IsTrue(result == 1002);
        }
    }
}
