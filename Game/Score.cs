namespace Game
{
    internal static class Score
    {
        private const int Need = 3;

        /// <summary>
        /// Count matched jewels.
        /// </summary>
        internal static int GetScore(this JewelKind[,] jewels)
        {
            var maxx = jewels.GetLength(0);
            var maxy = jewels.GetLength(1);

            var previous = (JewelKind?)null;
            var matched = 0;
            var all = 0;

            for (var x = 0; x < maxx; x++)
            {
                for (var y = 0; y < maxy; y++)
                {
                    GetMatched(jewels[x, y], ref previous, ref matched, ref all);
                }

                previous = null;
            }

            for (var y = 0; y < maxy; y++)
            {
                for (var x = 0; x < maxx; x++)
                {
                    GetMatched(jewels[x, y], ref previous, ref matched, ref all);
                }

                previous = null;
            }

            return all;
        }

        private static void GetMatched(
            JewelKind kind,
            ref JewelKind? previous,
            ref int matched,
            ref int all)
        {
            if (previous == kind)
            {
                matched++;

                var add =
                    matched == Need ? Need :
                    matched > Need ? 1 :
                    0;

                all += add;
            }
            else
            {
                previous = kind;

                matched = 1;
            }
        }
    }
}