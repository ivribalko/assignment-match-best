namespace Game
{
    internal struct Move
    {
        internal readonly int X;
        internal readonly int Y;
        internal readonly MoveDirection Direction;

        internal Move(int x, int y, MoveDirection direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
    };
}