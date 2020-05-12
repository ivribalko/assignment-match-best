using System;
using System.Linq;

namespace Game
{
    internal static class Predict
    {
        private static readonly MoveDirection[] Directions = Enum
            .GetValues(typeof(MoveDirection))
            .Cast<MoveDirection>()
            .ToArray();

        internal static Move? BestMove(JewelKind[,] jewels)
        {
            var maxx = jewels.GetLength(0);
            var maxy = jewels.GetLength(1);

            for (int x = 0; x < maxx; x++)
            {
                for (int y = 0; y < maxy; y++)
                {
                    foreach (var direction in Directions)
                    {
                        var location = Move(x, y, direction);

                        if (Valid(location, maxx, maxy))
                        {

                        }
                    }
                }
            }

            return null;
        }

        private static bool Valid((int x, int y) coordinates, int maxx, int maxy) =>
            coordinates.x >= 0 &&
            coordinates.y >= 0 &&
            coordinates.x < maxx &&
            coordinates.y < maxy;

        private static (int x, int y) Move(int x, int y, MoveDirection direction) =>
            direction switch
            {
                MoveDirection.Up    => (x, y + 1),
                MoveDirection.Down  => (x, y - 1),
                MoveDirection.Left  => (x - 1, y),
                MoveDirection.Right => (x + 1, y),
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
    }
}