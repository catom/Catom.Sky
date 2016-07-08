using System;
using System.Collections.Generic;
using Algorithm;

namespace Algorithm1
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
            string fenshu = WXNL.wxnlzf;
            string rtianganwx = CommonClass.Get_wx(BaZi.rTianGan);
            Dictionary<string, string> dic = CommonClass.GetShengRiGan();
            if (dic.ContainsKey("生" + rtianganwx))
            {
                wxResult = dic["生" + rtianganwx];
            }
            if (rtianganwx == "火" && wxResult == "木")
            {
                zf1 = Convert.ToInt32(WXNL.t + WXNL.h);
                zf2 = Convert.ToInt32(WXNL.j + WXNL.m + WXNL.sh);
            }
            else if (rtianganwx == "金" && wxResult == "土")
            {
                zf1 = Convert.ToInt32(WXNL.j + WXNL.t);
                zf2 = Convert.ToInt32(WXNL.m + WXNL.sh + WXNL.h);
            }
            else if (rtianganwx == "木" && wxResult == "水")
            {
                zf1 = Convert.ToInt32(WXNL.m + WXNL.sh);
                zf2 = Convert.ToInt32(WXNL.j + WXNL.h + WXNL.t);
            }
            else if (rtianganwx == "水" && wxResult == "金")
            {
                zf1 = Convert.ToInt32(WXNL.sh + WXNL.j);
                zf2 = Convert.ToInt32(WXNL.m + WXNL.h + WXNL.t);
            }
            else if (rtianganwx == "土" && wxResult == "火")
            {
                zf1 = Convert.ToInt32(WXNL.t + WXNL.h);
                zf2 = Convert.ToInt32(WXNL.j + WXNL.m + WXNL.sh);
            }
        }
    }
}