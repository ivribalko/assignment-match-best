namespace Game
{
    internal class Board
    {
        private readonly JewelKind[,] jewels;

        internal Board(JewelKind[,] jewels)
        {
            this.jewels = jewels;
        }

        internal int GetWidth() => this.jewels.GetLength(0);

        internal int GetHeight() => this.jewels.GetLength(1);

        internal JewelKind GetJewel(int x, int y) => this.jewels[x, y];

        internal void SetJewel(int x, int y, JewelKind kind) => this.jewels[x, y] = kind;

        internal Move CalculateBestMoveForBoard()
        {
            return default;
        }
    }
}