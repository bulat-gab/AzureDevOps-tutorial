using System;
using NUnit.Framework;

namespace AzureDevOpsSample
{
    class Program
    {
        [Test]
        public void SuccessfulTest()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void FailingTest()
        {
            Assert.Fail();
        }
    }
}
