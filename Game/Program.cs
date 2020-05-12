using System.Diagnostics;

namespace Game
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AssertCorrectMoveOne();
            AssertCorrectMoveTwo();
        }

        private static void AssertCorrectMoveOne()
        {
            var color1 = JewelKind.Blue;
            var color2 = JewelKind.Green;
            var color3 = JewelKind.Violet;
            var color4 = JewelKind.Indigo;

            var array = new [,]
            {
                { color1, color2, color3 },
                { color1, color2, color3 },
                { color2, color1, color4 },
            };

            var board = new Board(array);

            var move = board.CalculateBestMoveForBoard();

            Debug.Assert(move.X == 2);
            Debug.Assert(move.Y == 0);
            Debug.Assert(move.Direction == MoveDirection.Up);
        }

        private static void AssertCorrectMoveTwo()
        {
            var color1 = JewelKind.Blue;
            var color2 = JewelKind.Green;
            var color3 = JewelKind.Violet;
            var color4 = JewelKind.Indigo;

            var array = new [,]
            {
                { color3, color4, color4, color2, },
                { color4, color3, color3, color1, },
                { color4, color1, color4, color4, },
                { color1, color4, color1, color1, },
            };

            var board = new Board(array);

            var move = board.CalculateBestMoveForBoard();

            Debug.Assert(move.X == 2);
            Debug.Assert(move.Y == 1);
            Debug.Assert(move.Direction == MoveDirection.Right);
        }
    }
}