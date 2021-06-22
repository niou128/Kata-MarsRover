using FluentAssertions;
using Xunit;

namespace MarsRoverKata.Tests.XUnit
{
    public class RoverTests
    {
        [Fact]
        public void ThisTestShouldPass()
        {
            var instance = new Rover();

            instance.ToString().Should().NotBeNull();
        }
    }
}
