using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberSystemConverter;

namespace NumberSystemConverter_unittest
{
    [TestClass]
    public class NumberSystemConverter_Unit
    {
        [TestMethod]
        public void ThrowIndexOutofRange()
        {
            var converter = new NumberSystemConverter_();
            Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertNumber(3001));
        }
        [TestMethod]
        public void CheckForEquality()
        {
            var converter = new NumberSystemConverter_();
            Assert.ThrowsException<IndexOutOfRangeException>(() => converter.ConvertNumber(3001));
        }

    
    }
}
