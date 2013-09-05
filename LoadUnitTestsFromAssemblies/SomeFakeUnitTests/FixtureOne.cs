using System;
using NUnit.Framework;

namespace SomeFakeUnitTests
{
    [TestFixture]
    public class FixtureOne
    {
        [Test]
        public void One_Passing()
        {
            Assert.True(true);
        }

        [Test]
        public void One_Failing()
        {
            Assert.True(false);
        }

        [Test]
        public void One_Throwing()
        {
            throw new Exception("geppo");
        }
    }
}
