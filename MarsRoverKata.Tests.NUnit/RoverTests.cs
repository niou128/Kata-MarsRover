using FluentAssertions;
using NUnit.Framework;

namespace MarsRoverKata.Tests.NUnit
{
    public class RoverTests
    {
        [Test]
        public void ThisTestShouldPass()
        {
            var instance = new Rover();

            instance.ToString().Should().NotBeNull();
        }
    }
}
