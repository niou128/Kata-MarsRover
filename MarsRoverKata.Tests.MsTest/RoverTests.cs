using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverKata.Tests.MsTest
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ThisTestShouldPass()
        {
            var instance = new Rover();

            instance.ToString().Should().NotBeNull();
        }
    }
}
