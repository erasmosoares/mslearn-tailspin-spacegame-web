using NUnit.Framework;

namespace Tailspin.SpaceGame.Web.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Milky Way")]
        [TestCase("Andromeda")]
        [TestCase("Pinwheel")]
        [TestCase("NGC 1300")]
        [TestCase("Messier 82")]
        public void Test1(string gameRegion)
        {
            Assert.Pass();
        }
    }
}