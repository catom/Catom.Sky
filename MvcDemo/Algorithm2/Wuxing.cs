using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    /// <summary>
    ///  五行的相关算法。包括五行个数、五行能量分数等。
    /// </summary>
    public class Wuxing
    {
        #region Fields & Properties

        //private static Dictionary<string, int> _wuxingBenqi;
        //private static Dictionary<string, int> _wuxingYuqi;
        //private static Dictionary<string, int> _wuxingEnergy;

        private readonly Bazi _bazi;

        #endregion

        #region Constructors

        public Wuxing(Bazi bazi)
        {
            _bazi = bazi;
        }

        #endregion

        #region 算法

        /// <summary>
        ///  八字五行个数（本气）
        /// </summary>
        /// <returns></returns>;
        public Dictionary<string, int> GetWuxingBenqi()
        {
            if (string.IsNullOrEmpty(_bazi.YearTiangan))
                throw new Exception("生辰八字为不能为空！");

            var dic = new Dictionary<string, int> { { "木", 0 }, { "火", 0 }, { "土", 0 }, { "金", 0 }, { "水", 0 } };
            var totolNum = 0;

            //var bzArr = _bazi.ToBaziString().Split(' ');
            var bzArr = "丙 申 癸 巳 庚 子 癸 未".Split(' ');

            foreach (var key in bzArr)
            {
                string wx;
                FortuneConstants.DicTianganWuxing.TryGetValue(key, out wx);
                if (string.IsNullOrEmpty(wx))
                {
                    FortuneConstants.DicDizhiWuxing.TryGetValue(key, out wx);
                }
                if (wx != null)
                {
                    dic[wx]++;
                    totolNum++;
                }
            }

            dic.Add("总数", totolNum);
            return dic;
        }

        /// <summary>
        ///  八字五行个数（含余气）
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetWuxingYuqi()
        {
            if (string.IsNullOrEmpty(_bazi.YearTiangan))
                throw new Exception("生辰八字为不能为空！");

            var dic = new Dictionary<string, int> { { "木", 0 }, { "火", 0 }, { "土", 0 }, { "金", 0 }, { "水", 0 } };
            var totolNum = 0;

            //var bzArr = _bazi.ToBaziString().Split(' ');
            var bzArr = "丙 申 癸 巳 庚 子 癸 未".Split(' ');

            // 1. 八字天干气
            foreach (var key in bzArr.Where(gz => FortuneConstants.DicTianganWuxing.ContainsKey(gz)))
            {
                var wx = FortuneConstants.DicTianganWuxing[key];
                dic[wx]++;
                totolNum++;
            }

            // 2. 地支藏干气
            foreach (var dizhi in bzArr.Where(gz => FortuneConstants.DicDizhiWuxing.ContainsKey(gz)))
            {
                var tiangans = CommonClass.GetHiddenTianganByZhi(dizhi);
                foreach (var tiangan in tiangans.Split(','))
                {
                    var wx = FortuneConstants.DicTianganWuxing[tiangan];
                    dic[wx]++;
                    totolNum++;
                }
            }

            dic.Add("总数", totolNum);
            return dic;
        }

        /// <summary>
        ///  五行分值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetWuxingScore()
        {
            if (string.IsNullOrEmpty(_bazi.YearTiangan))
                throw new Exception("生辰八字为不能为空！");

            var dicScore = new Dictionary<string, int> { { "木", 0 }, { "火", 0 }, { "土", 0 }, { "金", 0 }, { "水", 0 } };
            var totolScore = 0;
            //var bzArr = _bazi.ToBaziString().Split(' ');
            var bzArr = "戊 子 庚 申 庚 辰 戊 寅".Split(' ');

            // 1. 八字天干分数
            foreach (var key in bzArr.Where(gz => FortuneConstants.DicTianganWuxing.ContainsKey(gz)))
            {
                var wx = FortuneConstants.DicTianganWuxing[key];
                dicScore[wx] += 100;
                totolScore += 100;
            }

            // 2. 地支藏干分数
            foreach (var dizhi in bzArr.Where(gz => FortuneConstants.DicDizhiWuxing.ContainsKey(gz)))
            {
                var tiangans = CommonClass.GetHiddenTianganByZhi(dizhi);
                foreach (var tiangan in tiangans.Split(','))
                {
                    var wx = FortuneConstants.DicTianganWuxing[tiangan];
                    dicScore[wx] += FortuneConstants.DicWuxingHiddenTianganScore[dizhi + tiangan];
                    totolScore += dicScore[wx];
                }
            }

            dicScore.Add("总分", totolScore);
            return dicScore;
        }

        /// <summary>
        ///  五行同类分值，条件：日干生
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetWuxingScoreFromSameKind()
        {
            // 日天干
            var dayTiangan = _bazi.DayTiangan;
            // 日天干五行
            var dayTianganWuxing = FortuneConstants.DicTianganWuxing[dayTiangan];
            // 找出日生干关系的键
            var key = FortuneConstants.DicWuxingRelationSource.Keys.First(k => FortuneConstants.DicWuxingRelationSource[k].Equals(dayTianganWuxing));
            // 日干所生五行
            var shengWuxing = key.Replace("生", "");
            // 五行
            var dic = GetWuxingScore();

            return new Dictionary<string, int>
            {
                {dayTianganWuxing, dic[dayTianganWuxing] },
                {shengWuxing, dic[shengWuxing] },
                {"总分", dic[dayTianganWuxing] + dic[shengWuxing] }
            };

        }

        /// <summary>
        ///  五行异类分值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetWuxingScoreFromDiffKind()
        {
            // 日天干
            var dayTiangan = _bazi.DayTiangan;
            // 日天干五行
            var dayTianganWuxing = FortuneConstants.DicTianganWuxing[dayTiangan];
            // 找出日生干关系的键
            var key = FortuneConstants.DicWuxingRelationSource.Keys.First(k => FortuneConstants.DicWuxingRelationSource[k].Equals(dayTianganWuxing));
            // 日干所生五行
            var shengWuxing = key.Replace("生", "");
            // 五行
            var dic = GetWuxingScore();
            var keys = dic.Keys.Where(k => !k.Contains("总") && !k.Equals(dayTianganWuxing) && !k.Equals(shengWuxing));

            var dicReturn = keys.ToDictionary(k => k, k => dic[k]);
            // 求总分
            dicReturn.Add("总分", dicReturn.Aggregate(0, (total, pair) => total + pair.Value));

            return dicReturn;
        }

        /// <summary>
        ///  五行能量值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, double> GetWuxingEnergy()
        {
            var dicReturn = new Dictionary<string, double>();
            var totalEnergy = 0.0;

            var dicScore = GetWuxingScore();
            var month = _bazi.MonthDizhi;

            foreach (var key in dicScore.Keys)
            {
                var energy = dicScore[key] * FortuneConstants.DicWuxingCoefficient[month + key];
                totalEnergy += energy;
                dicReturn.Add(key, energy);
            }

            dicReturn.Add("总分", totalEnergy);
            return dicReturn;
        }

        #endregion

    }
}