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
            var b = JewelKind.Blue;
            var g = JewelKind.Green;
            var v = JewelKind.Violet;
            var i = JewelKind.Indigo;

            var array = new [,]
            {
                { b, g, v, },
                { b, g, v, },
                { g, b, i, },
            };

            var board = new Board(array);

            var move = board.CalculateBestMoveForBoard();

            Debug.Assert(move.X == 2);
            Debug.Assert(move.Y == 0);
            Debug.Assert(move.Direction == MoveDirection.Up);
        }

        private static void AssertCorrectMoveTwo()
        {
            var b = JewelKind.Blue;
            var g = JewelKind.Green;
            var v = JewelKind.Violet;
            var i = JewelKind.Indigo;

            var array = new [,]
            {
                { v, i, i, g, },
                { i, v, v, b, },
                { i, b, i, i, },
                { b, i, b, b, },
            };

            var board = new Board(array);

            var move = board.CalculateBestMoveForBoard();

            Debug.Assert(move.X == 2);
            Debug.Assert(move.Y == 1);
            Debug.Assert(move.Direction == MoveDirection.Right);
        }
    }
}