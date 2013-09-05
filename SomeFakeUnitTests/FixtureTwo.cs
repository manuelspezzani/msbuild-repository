using System;
using NUnit.Framework;

namespace SomeFakeUnitTests
{
    [TestFixture]
    public class FixtureTwo
    {
        [Test]
        public void Two_Passing()
        {
            Assert.True(true);
        }

        [Test]
        public void Two_Failing()
        {
            Assert.True(false);
        }

        [Test]
        public void Two_Throwing()
        {
            throw new Exception("geppo");
        }
    }
}