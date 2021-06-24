using System.Drawing;

namespace MarsRoverKata
{
    public class Rover
    {
        private static readonly Point DefaultInitialPosition = new Point(0, 0);
        private const Direction DefaultInitialDirection = Direction.N;

        public Point Position { get; set; }
        public Direction Direction { get; set; }

        public Rover() : this(DefaultInitialPosition, DefaultInitialDirection)
        {
        }

        public Rover(Point point, Direction direction)
        {
            Position = point;
            Direction = direction;
        }
    }
}
