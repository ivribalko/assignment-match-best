namespace Game
{
    internal static class Predict
    {
        internal static Move? BestMove(JewelKind[,] jewels)
        {
            for (int x = 0; x < jewels.GetLength(0); x++)
            {
                for (int y = 0; y < jewels.GetLength(1); y++)
                {
                    return new Move();
                }
            }

            return null;
        }
    }
}