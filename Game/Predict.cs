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

            var result = (score: 0, move: default(Move));

            // TODO no dupe checks

            for (var x = 0; x < maxx; x++)
            {
                for (var y = 0; y < maxy; y++)
                {
                    foreach (var direction in Directions)
                    {
                        var move = new Move(x, y, direction);

                        if (Valid(move, maxx, maxy))
                        {
                            Apply(move, jewels);

                            var score = jewels.GetScore();

                            if (result.score < score)
                            {
                                result.score = score;
                                result.move = move;
                            }

                            Apply(Reverse(move), jewels);
                        }
                    }
                }
            }

            return result.score > 0
                ? result.move
                : (Move?)null;
        }

        /// <summary>
        /// Update jewels array according to move.
        /// </summary>
        private static void Apply(Move move, JewelKind[,] jewels)
        {
            var (x, y) = GetApplied(move);

            var save = jewels[x, y];

            jewels[x, y] = jewels[move.X, move.Y];

            jewels[move.X, move.Y] = save;
        }

        private static bool Valid(Move move, int maxx, int maxy)
        {
            var (x, y) = GetApplied(move);

            return x >= 0 &&
                   y >= 0 &&
                   x < maxx &&
                   y < maxy;
        }

        private static Move Reverse(Move move)
        {
            var (x, y) = GetApplied(move);

            var direction = move.Direction.Reverse();

            return new Move(x, y, direction);
        }

        private static (int x, int y) GetApplied(Move move)
        {
            var x = move.X;
            var y = move.Y;
            var direction = move.Direction;

            return direction switch
            {
                MoveDirection.Up    => (x, y + 1),
                MoveDirection.Down  => (x, y - 1),
                MoveDirection.Left  => (x - 1, y),
                MoveDirection.Right => (x + 1, y),
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
            };
        }
    }
}