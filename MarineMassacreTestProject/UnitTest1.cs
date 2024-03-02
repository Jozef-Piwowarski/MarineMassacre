using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarineMassacreTestProject
{
    [TestClass]
    [TestCategory("TargetUnitTests")]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("TargetArmorUnitTest")]
        [Description("Check if armor values are read properly")]
        public void TestMethod1()
        {
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = 3;
            Assert.IsTrue(a == 3);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
}
