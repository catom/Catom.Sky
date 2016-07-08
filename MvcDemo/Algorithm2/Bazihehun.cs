using System;
using System.Collections.Generic;

namespace Algorithm
{
    /// <summary>
    /// Bazihehun 的摘要说明
    /// </summary>

    public class BaZiHeHun
    {
        public static string wxResult;
        public int zf1;
        public int zf2;
        public void GetBaZiHeHun()
        {

        }

        //婚后幸福指数
        public void GetHunHouXinFuZhiShu()
        {
            string fenshu = WuxingEnergy.wxnlzf;
            string rtianganwx = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan);
            //Dictionary<string, string> dic = CommonClass.GetShengRiGan();
            var dic = FortuneConstants.DicWuxingRelationSource;
            if (dic.ContainsKey("生" + rtianganwx))
            {
                wxResult = dic["生" + rtianganwx];
            }
            if (rtianganwx == "火" && wxResult == "木")
            {
                zf1 = Convert.ToInt32(WuxingEnergy.t + WuxingEnergy.h);
                zf2 = Convert.ToInt32(WuxingEnergy.j + WuxingEnergy.m + WuxingEnergy.sh);
            }
            else if (rtianganwx == "金" && wxResult == "土")
            {
                zf1 = Convert.ToInt32(WuxingEnergy.j + WuxingEnergy.t);
                zf2 = Convert.ToInt32(WuxingEnergy.m + WuxingEnergy.sh + WuxingEnergy.h);
            }
            else if (rtianganwx == "木" && wxResult == "水")
            {
                zf1 = Convert.ToInt32(WuxingEnergy.m + WuxingEnergy.sh);
                zf2 = Convert.ToInt32(WuxingEnergy.j + WuxingEnergy.h + WuxingEnergy.t);
            }
            else if (rtianganwx == "水" && wxResult == "金")
            {
                zf1 = Convert.ToInt32(WuxingEnergy.sh + WuxingEnergy.j);
                zf2 = Convert.ToInt32(WuxingEnergy.m + WuxingEnergy.h + WuxingEnergy.t);
            }
            else if (rtianganwx == "土" && wxResult == "火")
            {
                zf1 = Convert.ToInt32(WuxingEnergy.t + WuxingEnergy.h);
                zf2 = Convert.ToInt32(WuxingEnergy.j + WuxingEnergy.m + WuxingEnergy.sh);
            }
        }
    }
}