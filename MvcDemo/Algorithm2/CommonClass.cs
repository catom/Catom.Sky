using System.Collections.Generic;

namespace Algorithm
{
    /// <summary>
    ///  工具方法类，提供计算的中间工具方法
    /// </summary>
    public class CommonClass
    {

        #region 静态方法集

        /// <summary>
        ///  求地支所藏的天干
        /// </summary>
        /// <param name="dizhi">地支</param>
        /// <returns></returns>
        public static string GetHiddenTianganByZhi(string dizhi)
        {
            string result;
            FortuneConstants.DicHiddenTiangan.TryGetValue(dizhi, out result);
            return result;
        }

        /// <summary>
        ///  求天干所对应的阴阳
        /// </summary>
        /// <param name="gan">天干</param>
        /// <returns></returns>
        public static string GetYinyangByTiangan(string gan)
        {
            string result;
            FortuneConstants.DicTianganYinyang.TryGetValue(gan, out result);
            return result;
        }

        /// <summary>
        ///  取年干或地支的五行
        /// </summary>
        /// <param name="ganzhi">年干或地支</param>
        /// <returns></returns>
        public static string GetWuxingByGanOrZhi(string ganzhi)
        {
            string result;
            FortuneConstants.DicTianganWuxing.TryGetValue(ganzhi, out result);
            if (string.IsNullOrEmpty(result))
            {
                FortuneConstants.DicDizhiWuxing.TryGetValue(ganzhi, out result);
            }
            return result;
        }

        #endregion
        
    }
}
