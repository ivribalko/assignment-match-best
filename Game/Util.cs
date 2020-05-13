using System;

namespace Game
{
    internal static class Util
    {
        internal static MoveDirection Reverse(this MoveDirection direction) =>
            direction switch
            {
                MoveDirection.Up => MoveDirection.Down,
                MoveDirection.Down => MoveDirection.Up,
                MoveDirection.Left => MoveDirection.Right,
                MoveDirection.Right => MoveDirection.Left,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
    }
}