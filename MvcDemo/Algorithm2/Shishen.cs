using System.Collections.Generic;

namespace Algorithm
{
    /// <summary>
    /// Shishen 的摘要说明
    /// </summary>

    public class Shishen
    {
        #region
        //五行
        public static string rywx = "";//天干月五行
        public static string rnwx = "";//天干年五行
        public static string rswx = "";//天干时五行
        public static string dnwx1 = "";//地支年五行
        public static string dnwx2 = "";//地支年五行
        public static string dnwx3 = "";//地支年五行
        public static string dywx1 = "";
        public static string dywx2 = "";
        public static string dywx3 = "";
        public static string dswx1 = "";
        public static string dswx2 = "";
        public static string dswx3 = "";
        public static string drwx1 = "";
        public static string drwx2 = "";
        public static string drwx3 = "";

        //阴阳
        public static string ryyy = "";//天干月阴阳
        public static string rnyy = "";
        public static string rsyy = "";
        public static string drnyy1 = "";
        public static string drnyy2 = "";
        public static string drnyy3 = "";
        public static string dryyy1 = "";
        public static string dryyy2 = "";
        public static string dryyy3 = "";
        public static string drsyy1 = "";
        public static string drsyy2 = "";
        public static string drsyy3 = "";
        public static string drryy1 = "";
        public static string drryy2 = "";
        public static string drryy3 = "";

        static string rywxresult = "";//五行结果
        static string rnwxresult = "";
        static string rswxresult = "";
        static string drywxresult1 = "";
        static string drywxresult2 = "";
        static string drywxresult3 = "";
        static string drnwxresult1 = "";
        static string drnwxresult2 = "";
        static string drnwxresult3 = "";
        static string drswxresult1 = "";
        static string drswxresult2 = "";
        static string drswxresult3 = "";
        static string drrwxresult1 = "";
        static string drrwxresult2 = "";
        static string drrwxresult3 = "";

        static string ryyyresult = "";//阴阳结果
        static string rnyyresult = "";
        static string rsyyresult = "";
        static string dryyyresult1 = "";
        static string dryyyresult2 = "";
        static string dryyyresult3 = "";
        static string drnyyresult1 = "";
        static string drnyyresult2 = "";
        static string drnyyresult3 = "";
        static string drsyyresult1 = "";
        static string drsyyresult2 = "";
        static string drsyyresult3 = "";
        static string drryyresult1 = "";
        static string drryyresult2 = "";
        static string drryyresult3 = "";

        static string result1 = "";//阴阳五行结果
        static string result2 = "";
        static string result3 = "";
        static string result4 = "";
        static string result5 = "";
        static string result6 = "";
        static string result7 = "";
        static string result8 = "";
        static string result9 = "";
        static string result10 = "";
        static string result11 = "";
        static string result12 = "";
        static string result13 = "";
        static string result14 = "";
        static string result15 = "";

        public static string re1 = "";//十神结果
        public static string re2 = "";
        public static string re3 = "";
        public static string re4 = "";
        public static string re5 = "";
        public static string re6 = "";
        public static string re7 = "";
        public static string re8 = "";
        public static string re9 = "";
        public static string re10 = "";
        public static string re11 = "";
        public static string re12 = "";
        public static string re13 = "";
        public static string re14 = "";
        public static string re15 = "";
        #endregion

        public void GetShiShen()
        {
            //获取天干和臧干的五行
            rywx = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Bazi.yTianGan);
            rnwx = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Bazi.nTianGan);
            rswx = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Bazi.sTianGan);
            dnwx1 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
            dnwx2 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
            dnwx3 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
            dywx1 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
            dywx2 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
            dywx3 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
            dswx1 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
            dswx2 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
            dswx3 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
            drwx1 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
            drwx2 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
            drwx3 = CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);

            //获取天干和臧干的阴阳
            ryyy = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Bazi.yTianGan);
            rnyy = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Bazi.nTianGan);
            rsyy = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Bazi.sTianGan);
            drnyy1 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.nzhanggan[0]);
            drnyy2 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.nzhanggan[1]);
            drnyy3 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.nzhanggan[2]);
            dryyy1 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.yzhanggan[0]);
            dryyy2 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.yzhanggan[1]);
            dryyy3 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.yzhanggan[2]);
            drsyy1 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.szhanggan[0]);
            drsyy2 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.szhanggan[1]);
            drsyy3 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.szhanggan[2]);
            drryy1 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.rzhanggan[0]);
            drryy2 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.rzhanggan[1]);
            drryy3 = CommonClass.GetYinyangByTiangan(Bazi.rTianGan) + CommonClass.GetYinyangByTiangan(Canggan.rzhanggan[2]);

            #region 五行关系

            //Dictionary<string, string> dic = CommonClass.GetWXGX();
            var dic = FortuneConstants.DicWuxingRelations;
            if (dic.ContainsKey(rywx))
            {
                rywxresult = dic[rywx];
            }
            if (dic.ContainsKey(rnwx))
            {
                rnwxresult = dic[rnwx];
            }
            if (dic.ContainsKey(rswx))
            {
                rswxresult = dic[rswx];
            }

            if (!string.IsNullOrEmpty(dnwx1) && dic.ContainsKey(dnwx1))
            {
                drnwxresult1 = dic[dnwx1];
            }
            if (!string.IsNullOrEmpty(dnwx2) && dic.ContainsKey(dnwx2))
            {
                drnwxresult2 = dic[dnwx2];
            }
            if (!string.IsNullOrEmpty(dnwx3) && dic.ContainsKey(dnwx3))
            {
                drnwxresult3 = dic[dnwx3];
            }
            if (!string.IsNullOrEmpty(dywx1) && dic.ContainsKey(dywx1))
            {
                drywxresult1 = dic[dywx1];
            }
            if (!string.IsNullOrEmpty(dywx2) && dic.ContainsKey(dywx2))
            {
                drywxresult2 = dic[dywx2];
            }
            if (!string.IsNullOrEmpty(dywx3) && dic.ContainsKey(dywx3))
            {
                drywxresult3 = dic[dywx3];
            }
            if (!string.IsNullOrEmpty(dswx1) && dic.ContainsKey(dswx1))
            {
                drswxresult1 = dic[dswx1];
            }
            if (!string.IsNullOrEmpty(dswx2) && dic.ContainsKey(dswx2))
            {
                drswxresult2 = dic[dswx2];
            }
            if (!string.IsNullOrEmpty(dswx3) && dic.ContainsKey(dswx3))
            {
                drswxresult3 = dic[dswx3];
            }
            if (!string.IsNullOrEmpty(drwx1) && dic.ContainsKey(drwx1))
            {
                drrwxresult1 = dic[drwx1];
            }
            if (!string.IsNullOrEmpty(drwx2) && dic.ContainsKey(drwx2))
            {
                drrwxresult2 = dic[drwx2];
            }
            if (!string.IsNullOrEmpty(drwx3) && dic.ContainsKey(drwx3))
            {
                drrwxresult3 = dic[drwx3];
            }

            #endregion

            #region 日干与其他天干及臧干的阴阳关系
            //Dictionary<string, string> d = CommonClass.GetYYGX();
            var d = FortuneConstants.DicYinyangDesc;
            if (d.ContainsKey(ryyy))
            {
                ryyyresult = d[ryyy];
            }
            if (d.ContainsKey(rnyy))
            {
                rnyyresult = d[rnyy];
            }
            if (d.ContainsKey(rsyy))
            {
                rsyyresult = d[rsyy];
            }
            if (!string.IsNullOrEmpty(dryyy1) && d.ContainsKey(dryyy1))
            {
                dryyyresult1 = d[dryyy1];
            }
            if (!string.IsNullOrEmpty(dryyy2) && d.ContainsKey(dryyy2))
            {
                dryyyresult2 = d[dryyy2];
            }
            if (!string.IsNullOrEmpty(dryyy3) && d.ContainsKey(dryyy3))
            {
                dryyyresult3 = d[dryyy3];
            }
            if (!string.IsNullOrEmpty(drnyy1) && d.ContainsKey(drnyy1))
            {
                drnyyresult1 = d[drnyy1];
            }
            if (!string.IsNullOrEmpty(drnyy2) && d.ContainsKey(drnyy2))
            {
                drnyyresult2 = d[drnyy2];
            }
            if (!string.IsNullOrEmpty(drnyy3) && d.ContainsKey(drnyy3))
            {
                drnyyresult3 = d[drnyy3];
            }
            if (!string.IsNullOrEmpty(drsyy1) && d.ContainsKey(drsyy1))
            {
                drsyyresult1 = d[drsyy1];
            }
            if (!string.IsNullOrEmpty(drsyy2) && d.ContainsKey(drsyy2))
            {
                drsyyresult2 = d[drsyy2];
            }
            if (!string.IsNullOrEmpty(drsyy3) && d.ContainsKey(drsyy3))
            {
                drsyyresult3 = d[drsyy3];
            }
            if (!string.IsNullOrEmpty(drryy1) && d.ContainsKey(drryy1))
            {
                drryyresult1 = d[drryy1];
            }
            if (!string.IsNullOrEmpty(drryy2) && d.ContainsKey(drryy2))
            {
                drryyresult2 = d[drryy2];
            }
            if (!string.IsNullOrEmpty(drryy3) && d.ContainsKey(drryy3))
            {
                drryyresult3 = d[drryy3];
            }
            #endregion

            #region 日干与其他天干及臧干的五行关系
            //Dictionary<string, string> dict = CommonClass.GetWX();
            var dict = FortuneConstants.DicWuxingDayTianganRelations;
            if (dict.ContainsKey(rnwxresult))
            {
                result1 = dict[rnwxresult];
            }
            if (dict.ContainsKey(rywxresult))
            {
                result2 = dict[rywxresult];
            }
            if (dict.ContainsKey(rswxresult))
            {
                result3 = dict[rswxresult];
            }
            if (dict.ContainsKey(drywxresult1))
            {
                result4 = dict[drywxresult1];
            }
            if (dict.ContainsKey(drywxresult2))
            {
                result5 = dict[drywxresult2];
            }
            if (dict.ContainsKey(drywxresult3))
            {
                result6 = dict[drywxresult3];
            }
            if (dict.ContainsKey(drnwxresult1))
            {
                result7 = dict[drnwxresult1];
            }
            if (dict.ContainsKey(drnwxresult2))
            {
                result8 = dict[drnwxresult2];
            }
            if (dict.ContainsKey(drnwxresult3))
            {
                result9 = dict[drnwxresult3];
            }
            if (dict.ContainsKey(drswxresult1))
            {
                result10 = dict[drswxresult1];
            }
            if (dict.ContainsKey(drswxresult2))
            {
                result11 = dict[drswxresult2];
            }
            if (dict.ContainsKey(drswxresult3))
            {
                result12 = dict[drswxresult3];
            }
            if (dict.ContainsKey(drrwxresult1))
            {
                result13 = dict[drrwxresult1];
            }
            if (dict.ContainsKey(drrwxresult2))
            {
                result14 = dict[drrwxresult2];
            }
            if (dict.ContainsKey(drrwxresult3))
            {
                result15 = dict[drrwxresult3];
            }
            #endregion

            #region  计算十神

            string r1 = rnyyresult + "，" + result1;
            string r2 = ryyyresult + "，" + result2;
            string r3 = rsyyresult + "，" + result3;
            string r4 = drnyyresult1 + "，" + result7;
            string r5 = drnyyresult2 + "，" + result8;
            string r6 = drnyyresult3 + "，" + result9;
            string r7 = dryyyresult1 + "，" + result4;
            string r8 = dryyyresult2 + "，" + result5;
            string r9 = dryyyresult3 + "，" + result6;
            string r10 = drryyresult1 + "，" + result13;
            string r11 = drryyresult2 + "，" + result14;
            string r12 = drryyresult3 + "，" + result15;
            string r13 = drsyyresult1 + "，" + result10;
            string r14 = drsyyresult2 + "，" + result11;
            string r15 = drsyyresult3 + "，" + result12;

            //Dictionary<string, string> diction = CommonClass.GetShiShen();
            var diction = FortuneConstants.DicShishen;
            if (diction.ContainsKey(r1))
            {
                re1 = diction[r1];
            }
            if (diction.ContainsKey(r2))
            {
                re2 = diction[r2];
            }
            if (diction.ContainsKey(r3))
            {
                re3 = diction[r3];
            }
            if (diction.ContainsKey(r4))
            {
                re4 = diction[r4];
            }
            if (diction.ContainsKey(r5))
            {
                re5 = diction[r5];
            }
            if (diction.ContainsKey(r6))
            {
                re6 = diction[r6];
            }
            if (diction.ContainsKey(r7))
            {
                re7 = diction[r7];
            }
            if (diction.ContainsKey(r8))
            {
                re8 = diction[r8];
            }
            if (diction.ContainsKey(r9))
            {
                re9 = diction[r9];
            }
            if (diction.ContainsKey(r10))
            {
                re10 = diction[r10];
            }
            if (diction.ContainsKey(r11))
            {
                re11 = diction[r11];
            }
            if (diction.ContainsKey(r12))
            {
                re12 = diction[r12];
            }
            if (diction.ContainsKey(r13))
            {
                re13 = diction[r13];
            }
            if (diction.ContainsKey(r14))
            {
                re14 = diction[r14];
            }
            if (diction.ContainsKey(r15))
            {
                re15 = diction[r15];
            }

            #endregion
        }
    }

}