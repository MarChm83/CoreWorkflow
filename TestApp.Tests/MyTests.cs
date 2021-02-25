using NUnit.Framework;

namespace TestApp.Tests
{
    public class MyTests
    {
    

        [Test]
        public void PassingTest()
        {
            Assert.AreEqual(2, 2);
        }

        [Test]
        public void AnotherTest()
        {
            Assert.Pass();
        }
    }
}