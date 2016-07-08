namespace Algorithm
{
    /// <summary>
    /// TwelveGod 算法
    /// </summary>
    public static class TwelveGod
    {
        /// <summary>
        ///  计算长生十二神
        /// </summary>
        /// <param name="tiangan">天干</param>
        /// <param name="dizhi">地支</param>
        /// <returns>所对应的十二神</returns>
        public static string GetTwelveGod(string tiangan, string dizhi)
        {
            string result;
            FortuneConstants.DicTwelveGodsTable.TryGetValue(tiangan + dizhi, out result);
            return result;
        }
    }
}