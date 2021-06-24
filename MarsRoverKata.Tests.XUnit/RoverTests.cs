using FluentAssertions;
using System.Drawing;
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

        [Fact(DisplayName = "Constructor should not be null")]
        [Trait("Rover", "Constructor")]
        public void ShouldCreateRoverWithArgumentGiven()
        {
            Rover rover = new Rover(new Point(0, 0), Direction.N);

            rover.Should().NotBeNull();
        }

        [Fact(DisplayName = "Initial posisition should be 0,0")]
        [Trait("Rover", "Constructor")]
        public void InitialPositionShouldBe00()
        {
            Point expectedPosition = new Point(0, 0);

            Rover rover = new Rover(new Point(0, 0), Direction.N);

            Assert.Equal(expectedPosition, rover.Position);
        }

        [Fact(DisplayName = "Initial direction should be North")]
        [Trait("Rover", "Constructor")]
        public void InitialDirectionShouldBeN()
        {
            Direction expectedDirection = Direction.N;

            Rover rover = new Rover(new Point(0, 0), Direction.N);

            Assert.Equal(expectedDirection, rover.Direction);
        }

        [Fact(DisplayName = "If no argument passed to the constructor, intial position should be 0, 0")]
        [Trait("Rover", "Constructor")]
        public void WithoutArgumentPositionShouldBe00()
        {
            Point expectedPosition = new Point(0, 0);

            Rover rover = new Rover();

            Assert.Equal(expectedPosition, rover.Position);
        }

        [Fact(DisplayName = "Without argmuent, initial direction should be north")]
        [Trait("Rover", "Constructor")]
        public void WithoutArgumentDirectionShouldBeN()
        {
            Direction expectedDirection = Direction.N;

            Rover rover = new Rover();

            Assert.Equal(expectedDirection, rover.Direction);
        }

        [Theory(DisplayName = "")]
        [Trait("Rover", "Move")]
        [InlineData("F", "o")]
        public void Test(string move, string a)
        {
            //Todo: Si direction N y+1
            // si direction W x+1
            // direction S y-1
            // direction E x-1

            // penser au borne 10 -> 0
        }
    }
}
