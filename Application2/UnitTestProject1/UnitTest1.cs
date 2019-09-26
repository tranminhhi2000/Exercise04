using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void TestIsOdd()
        //{
        //    bool result3 = Program.IsOdd(3);
        //    Assert.AreEqual(true, result3);

        //    bool result4 = Program.IsOdd(4);
        //    Assert.AreEqual(false, result4);
        //}

        public void TestIsEven()
        {
            bool result5 = Program.IsEven(5);
            Assert.AreEqual(false, result5);

            bool result6 = Program.IsEven(6);
            Assert.AreEqual(true, result6);
        }
    }
}
