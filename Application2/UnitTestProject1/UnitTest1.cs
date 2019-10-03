using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result1 = Program.IsOdd(1);
            Assert.AreEqual(true, result1);

            bool result2 = Program.IsOdd(2);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result5 = Program.IsEven(5);
            Assert.AreEqual(false, result5);

            bool result6 = Program.IsEven(6);
            Assert.AreEqual(true, result6);
        }

        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result2);

            int result3 = Program.Ceil(3f);
            Assert.AreEqual(-2, result2);
        }

        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor(-2.3f);
            Assert.AreEqual(-3, result2);

            int result3 = Program.Floor(5);
            Assert.AreEqual(5, result3);
        }

        [TestMethod]
        public void TestIsPrime()
        {
            bool rs = Program.IsPrime(7);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestPow()
        {
            int rs = Program.Pow(2, 3);
            Assert.AreEqual(8, rs);
        }
        [TestMethod]
        public void TestSquare()
        {
            int rs = Program.Square(4);
            Assert.AreEqual(16, rs);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long rs = Program.Factorial(20L);
            Assert.AreEqual(109641728, rs);
        }
        
    }
}
