namespace Game
{
    internal class Board
    {
        internal int GetWidth() => 3;
        internal int GetHeight() => 3;

        internal JewelKind GetJewel(int x, int y)
        {
            return default;
        }

        internal void SetJewel(int x, int y, JewelKind kind)
        {
        }

        internal Move CalculateBestMoveForBoard()
        {
            return default;
        }
    }
}