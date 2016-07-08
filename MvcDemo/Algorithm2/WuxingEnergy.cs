using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algorithm
{
    /// <summary>
    /// WuxingEnergy 的摘要说明
    /// </summary>
    public class WuxingEnergy
    {
        public static string result1;
        public static string result2;
        public static string result3;
        public static string result4;
        public static string result5;
        public static string result6;
        public static string result7;
        public static string result8;
        public static string result9;
        public static string result10;
        public static string result11;
        public static string result12;
        public static string result;
        public static string strResult;
        public static List<string> list = new List<string>();
        public static List<string> strJList = new List<string>();
        public static List<string> strMList = new List<string>();
        public static List<string> strSList = new List<string>();
        public static List<string> strHList = new List<string>();
        public static List<string> strTList = new List<string>();
        public static string strs;
        public static List<string> strList = new List<string>();
        public static List<int> JFenshu = new List<int>();
        public static List<int> MFenshu = new List<int>();
        public static List<int> SFenshu = new List<int>();
        public static List<int> HFenshu = new List<int>();
        public static List<int> TFenshu = new List<int>();
        public static string wxnlzf;
        public static int j = 0, m = 0, sh = 0, h = 0, t = 0;

        //五行能量
        public string GetWXNL()
        {
            string r1, r2, r3;

            #region  子：癸
            if (Bazi.nDiZhi == "子" && (Canggan.nzhanggan.Contains("癸")))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nz);
                result1 = Bazi.nDiZhi + "中藏：" + Canggan.nz + r1 + 100;
            }
            else if (Bazi.yDiZhi == "子" && Canggan.yzhanggan.Contains("癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yz);
                result1 = Bazi.yDiZhi + "中藏：" + Canggan.yz + r1 + 100;
            }
            else if (Bazi.rDiZhi == "子" && Canggan.rzhanggan.Contains("癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rz);
                result1 = Bazi.rDiZhi + "中藏：" + Canggan.rz + r1 + 100;
            }
            else if (Bazi.sDiZhi == "子" && Canggan.szhanggan.Contains("癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.sz);
                result1 = Bazi.sDiZhi + "中藏：" + Canggan.sz + r1 + 100;
            }
            #endregion

            #region 丑：己癸辛
            if (Bazi.nDiZhi == "丑" && (Canggan.nzhanggan[0] == "己" && Canggan.nzhanggan[1] == "癸" && Canggan.nzhanggan[2] == "辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result2 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }

            if (Bazi.yDiZhi == "丑" && (Canggan.yzhanggan[0] == "己" && Canggan.yzhanggan[1] == "癸" && Canggan.yzhanggan[2] == "辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result2 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }

            if (Bazi.rDiZhi == "丑" && (Canggan.rzhanggan[0] == "己" && Canggan.rzhanggan[1] == "癸" && Canggan.rzhanggan[2] == "辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result2 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }

            if (Bazi.sDiZhi == "丑" && (Canggan.szhanggan[0] == "己" && Canggan.szhanggan[1] == "癸" && Canggan.szhanggan[2] == "辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result2 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 寅：甲丙戊

            if (Bazi.nDiZhi == "寅" && (Canggan.nzhanggan[0] == "甲" && Canggan.nzhanggan[1] == "丙" && Canggan.nzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result3 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }
            if (Bazi.yDiZhi == "寅" && (Canggan.yzhanggan[0] == "甲" && Canggan.yzhanggan[1] == "丙" && Canggan.yzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result3 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }
            if (Bazi.rDiZhi == "寅" && (Canggan.rzhanggan[0] == "甲" && Canggan.rzhanggan[1] == "丙" && Canggan.rzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result3 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }
            if (Bazi.sDiZhi == "寅" && (Canggan.szhanggan[0] == "甲" && Canggan.szhanggan[1] == "丙" && Canggan.szhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result3 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 卯：乙

            if (Bazi.nDiZhi == "卯" && Canggan.nzhanggan.Contains("乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nz);
                result4 = Bazi.nDiZhi + "中藏：" + Canggan.nz + r1 + 100;
            }
            else if (Bazi.yDiZhi == "卯" && Canggan.yzhanggan.Contains("乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yz);
                result4 = Bazi.yDiZhi + "中藏：" + Canggan.yz + r1 + 100;
            }
            else if (Bazi.rDiZhi == "卯" && Canggan.rzhanggan.Contains("乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rz);
                result4 = Bazi.rDiZhi + "中藏：" + Canggan.rz + r1 + 100;
            }
            else if (Bazi.sDiZhi == "卯" && Canggan.szhanggan.Contains("乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.sz);
                result4 = Bazi.sDiZhi + "中藏：" + Canggan.sz + r1 + 100;
            }


            #endregion

            #region 辰：戊乙癸

            if (Bazi.nDiZhi == "辰" && (Canggan.nzhanggan[0] == "戊" && Canggan.nzhanggan[1] == "乙" && Canggan.nzhanggan[2] == "癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result5 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }

            if (Bazi.yDiZhi == "辰" && (Canggan.yzhanggan[0] == "戊" && Canggan.yzhanggan[1] == "乙" && Canggan.yzhanggan[2] == "癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result5 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }

            if (Bazi.rDiZhi == "辰" && (Canggan.rzhanggan[0] == "戊" && Canggan.rzhanggan[1] == "乙" && Canggan.rzhanggan[2] == "癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result5 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }

            if (Bazi.sDiZhi == "辰" && (Canggan.szhanggan[0] == "戊" && Canggan.szhanggan[1] == "乙" && Canggan.szhanggan[2] == "癸"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result5 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 巳：丙戊庚
            if (Bazi.nDiZhi == "巳" && (Canggan.nzhanggan[0] == "丙" && Canggan.nzhanggan[1] == "戊" && Canggan.nzhanggan[2] == "庚"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result6 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }
            if (Bazi.yDiZhi == "巳" && (Canggan.yzhanggan[0] == "丙" && Canggan.yzhanggan[1] == "戊" && Canggan.yzhanggan[2] == "庚"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result6 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }
            if (Bazi.rDiZhi == "巳" && (Canggan.rzhanggan[0] == "丙" && Canggan.rzhanggan[1] == "戊" && Canggan.rzhanggan[2] == "庚"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result6 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }
            if (Bazi.sDiZhi == "巳" && (Canggan.szhanggan[0] == "丙" && Canggan.szhanggan[1] == "戊" && Canggan.szhanggan[2] == "庚"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result6 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 午：丁己
            if (Bazi.nDiZhi == "午" && (Canggan.nzhanggan[0] == "丁" && Canggan.nzhanggan[1] == "己"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                result7 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 70 + " " + Canggan.nzhanggan[1] + r2 + 30;
            }

            if (Bazi.yDiZhi == "午" && (Canggan.yzhanggan[0] == "丁" && Canggan.yzhanggan[1] == "己"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                result7 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 70 + " " + Canggan.yzhanggan[1] + r2 + 30;
            }

            if (Bazi.rDiZhi == "午" && (Canggan.rzhanggan[0] == "丁" && Canggan.rzhanggan[1] == "己"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                result7 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 70 + " " + Canggan.rzhanggan[1] + r2 + 30;
            }
            if (Bazi.sDiZhi == "午" && (Canggan.szhanggan[0] == "丁" && Canggan.szhanggan[1] == "己"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                result7 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 70 + " " + Canggan.szhanggan[1] + r2 + 30;
            }

            #endregion

            #region 未：己丁乙

            if (Bazi.nDiZhi == "未" && (Canggan.nzhanggan[0] == "己" && Canggan.nzhanggan[1] == "丁" && Canggan.nzhanggan[2] == "乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result8 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }
            if (Bazi.yDiZhi == "未" && (Canggan.yzhanggan[0] == "己" && Canggan.yzhanggan[1] == "丁" && Canggan.yzhanggan[2] == "乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result8 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }
            if (Bazi.rDiZhi == "未" && (Canggan.rzhanggan[0] == "己" && Canggan.rzhanggan[1] == "丁" && Canggan.rzhanggan[2] == "乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result8 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }

            if (Bazi.sDiZhi == "未" && (Canggan.szhanggan[0] == "己" && Canggan.szhanggan[1] == "丁" && Canggan.szhanggan[2] == "乙"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result8 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 申：庚壬戊

            if (Bazi.nDiZhi == "申" && (Canggan.nzhanggan[0] == "庚" && Canggan.nzhanggan[1] == "壬" && Canggan.nzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result9 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }
            if (Bazi.yDiZhi == "申" && (Canggan.yzhanggan[0] == "庚" && Canggan.yzhanggan[1] == "壬" && Canggan.yzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result9 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }
            if (Bazi.rDiZhi == "申" && (Canggan.rzhanggan[0] == "庚" && Canggan.rzhanggan[1] == "壬" && Canggan.rzhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result9 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }
            if (Bazi.sDiZhi == "申" && (Canggan.szhanggan[0] == "庚" && Canggan.szhanggan[1] == "壬" && Canggan.szhanggan[2] == "戊"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result9 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 酉：辛

            if (Bazi.nDiZhi == "酉" && Canggan.nzhanggan.Contains("辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nz);
                result10 = Bazi.nDiZhi + "中藏：" + Canggan.nz + r1 + 100;
            }

            if (Bazi.yDiZhi == "酉" && Canggan.yzhanggan.Contains("辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yz);
                result10 = Bazi.yDiZhi + "中藏：" + Canggan.yz + r1 + 100;
            }

            if (Bazi.rDiZhi == "酉" && Canggan.rzhanggan.Contains("辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rz);
                result10 = Bazi.rDiZhi + "中藏：" + Canggan.rz + r1 + 100;
            }

            if (Bazi.sDiZhi == "酉" && Canggan.szhanggan.Contains("辛"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.sz);
                result10 = Bazi.sDiZhi + "中藏：" + Canggan.sz + r1 + 100;
            }

            #endregion

            #region 戌：戊辛丁

            if (Bazi.nDiZhi == "戌" && (Canggan.nzhanggan[0] == "戊" && Canggan.nzhanggan[1] == "辛" && Canggan.nzhanggan[2] == "丁"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[2]);
                result11 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 60 + " " + Canggan.nzhanggan[1] + r2 + 30 + " " + Canggan.nzhanggan[2] + r3 + 10;
            }

            if (Bazi.yDiZhi == "戌" && (Canggan.yzhanggan[0] == "戊" && Canggan.yzhanggan[1] == "辛" && Canggan.yzhanggan[2] == "丁"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[2]);
                result11 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 60 + " " + Canggan.yzhanggan[1] + r2 + 30 + " " + Canggan.yzhanggan[2] + r3 + 10;
            }
            if (Bazi.rDiZhi == "戌" && (Canggan.rzhanggan[0] == "戊" && Canggan.rzhanggan[1] == "辛" && Canggan.rzhanggan[2] == "丁"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[2]);
                result11 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 60 + " " + Canggan.rzhanggan[1] + r2 + 30 + " " + Canggan.rzhanggan[2] + r3 + 10;
            }
            if (Bazi.sDiZhi == "戌" && (Canggan.szhanggan[0] == "戊" && Canggan.szhanggan[1] == "辛" && Canggan.szhanggan[2] == "丁"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                r3 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[2]);
                result11 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 60 + " " + Canggan.szhanggan[1] + r2 + 30 + " " + Canggan.szhanggan[2] + r3 + 10;
            }

            #endregion

            #region 亥：壬甲

            if (Bazi.nDiZhi == "亥" && (Canggan.nzhanggan[0] == "壬" && Canggan.nzhanggan[1] == "甲"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.nzhanggan[1]);
                result12 = Bazi.nDiZhi + "中藏：" + Canggan.nzhanggan[0] + r1 + 70 + " " + Canggan.nzhanggan[1] + r2 + 30;
            }
            if (Bazi.yDiZhi == "亥" && (Canggan.yzhanggan[0] == "壬" && Canggan.yzhanggan[1] == "甲"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.yzhanggan[1]);
                result12 = Bazi.yDiZhi + "中藏：" + Canggan.yzhanggan[0] + r1 + 70 + " " + Canggan.yzhanggan[1] + r2 + 30;
            }
            if (Bazi.rDiZhi == "亥" && (Canggan.rzhanggan[0] == "壬" && Canggan.rzhanggan[1] == "甲"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.rzhanggan[1]);
                result12 = Bazi.rDiZhi + "中藏：" + Canggan.rzhanggan[0] + r1 + 70 + " " + Canggan.rzhanggan[1] + r2 + 30;
            }

            if (Bazi.sDiZhi == "亥" && (Canggan.szhanggan[0] == "壬" && Canggan.szhanggan[1] == "甲"))
            {
                r1 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[0]);
                r2 = CommonClass.GetWuxingByGanOrZhi(Canggan.szhanggan[1]);
                result12 = Bazi.sDiZhi + "中藏：" + Canggan.szhanggan[0] + r1 + 70 + " " + Canggan.szhanggan[1] + r2 + 30;
            }

            #endregion

            result = result1 + "， " + result2 + "， " + result3 + "， " + result4 + "， " + result5 + "， " + result6 + "， " + result7 + "， " + result8 + "， " + result9 + "， " + result10 + "， " + result11 + "， " + result12;
            return result;
        }

        //五行总分
        public string GetWXZF()
        {
            #region

            string r = GetWXNL();
            string[] str = Regex.Split(r, "，");
            for (int i = 0; i < str.Length; i++)
            {
                string value = str[i].ToString().Trim();
                if (!string.IsNullOrEmpty(value))
                {
                    string[] s = value.Split('：');
                    string v = s[1].ToString().Trim();
                    if (!string.IsNullOrEmpty(v))
                    {
                        string[] a = v.Split(' ');
                        foreach (string item in a)
                        {
                            if (!string.IsNullOrEmpty(item))
                            {
                                list.Add(item.Trim());
                            }
                        }
                    }
                }
            }
            #endregion

            string ngwxzf = Bazi.nTianGan + CommonClass.GetWuxingByGanOrZhi(Bazi.nTianGan) + 100;
            string ygwxzf = Bazi.yTianGan + CommonClass.GetWuxingByGanOrZhi(Bazi.yTianGan) + 100;
            string rgwxzf = Bazi.rTianGan + CommonClass.GetWuxingByGanOrZhi(Bazi.rTianGan) + 100;
            string sgwxzf = Bazi.sTianGan + CommonClass.GetWuxingByGanOrZhi(Bazi.sTianGan) + 100;

            strJList = list.Where(x => x.Contains("金")).ToList();
            for (int i = 0; i < strJList.Count; i++)
            {
                strs = System.Text.RegularExpressions.Regex.Replace(strJList[i], "[\u4e00-\u9fa5]", "");
                JFenshu.Add(Convert.ToInt32(strs));
            }
            foreach (int a in JFenshu)
            {
                j = j + a;
            }
            if (ngwxzf.Contains("金"))
            {
                j = j + 100;
            }
            else if (ygwxzf.Contains("金"))
            {
                j = j + 100;
            }
            else if (rgwxzf.Contains("金"))
            {
                j = j + 100;
            }
            else if (sgwxzf.Contains("金"))
            {
                j = j + 100;
            }
            string jin = "八字中含金总分：" + j;

            strMList = list.Where(x => x.Contains("木")).ToList();
            for (int i = 0; i < strMList.Count; i++)
            {
                strs = System.Text.RegularExpressions.Regex.Replace(strMList[i], "[\u4e00-\u9fa5]", "");
                MFenshu.Add(Convert.ToInt32(strs));
            }
            foreach (var b in MFenshu)
            {
                m = m + b;
            }
            if (ngwxzf.Contains("木"))
            {
                m = m + 100;
            }
            if (ygwxzf.Contains("木"))
            {
                m = m + 100;
            }
            if (rgwxzf.Contains("木"))
            {
                m = m + 100;
            }
            if (sgwxzf.Contains("木"))
            {
                m = m + 100;
            }
            string mu = "八字中含木总分：" + m;

            strSList = list.Where(x => x.Contains("水")).ToList();
            for (int i = 0; i < strSList.Count; i++)
            {
                strs = System.Text.RegularExpressions.Regex.Replace(strSList[i], "[\u4e00-\u9fa5]", "");
                SFenshu.Add(Convert.ToInt32(strs));
            }
            foreach (var c in SFenshu)
            {
                sh = sh + c;
            }
            if (ngwxzf.Contains("水"))
            {
                sh = sh + 100;
            }
            if (ygwxzf.Contains("水"))
            {
                sh = sh + 100;
            }
            if (rgwxzf.Contains("水"))
            {
                sh = sh + 100;
            }
            if (sgwxzf.Contains("水"))
            {
                sh = sh + 100;
            }
            string shui = "八字中含水总分：" + sh;

            strHList = list.Where(x => x.Contains("火")).ToList();
            for (int i = 0; i < strHList.Count; i++)
            {
                strs = System.Text.RegularExpressions.Regex.Replace(strHList[i], "[\u4e00-\u9fa5]", "");
                HFenshu.Add(Convert.ToInt32(strs));
            }
            foreach (var d in HFenshu)
            {
                h = h + d;
            }
            if (ngwxzf.Contains("火"))
            {
                h = h + 100;
            }
            if (ygwxzf.Contains("火"))
            {
                h = h + 100;
            }
            if (rgwxzf.Contains("火"))
            {
                h = h + 100;
            }
            if (sgwxzf.Contains("火"))
            {
                h = h + 100;
            }
            string huo = "八字中含火总分：" + h;

            strTList = list.Where(x => x.Contains("土")).ToList();
            for (int i = 0; i < strTList.Count; i++)
            {
                strs = System.Text.RegularExpressions.Regex.Replace(strTList[i], "[\u4e00-\u9fa5]", "");
                TFenshu.Add(Convert.ToInt32(strs));
            }
            foreach (var e in TFenshu)
            {
                t = t + e;
            }
            if (ngwxzf.Contains("土"))
            {
                t = t + 100;
            }
            if (ygwxzf.Contains("土"))
            {
                t = t + 100;
            }
            if (rgwxzf.Contains("土"))
            {
                t = t + 100;
            }
            if (sgwxzf.Contains("土"))
            {
                t = t + 100;
            }
            string tu = "八字中含土总分：" + t;

            wxnlzf = jin + " " + mu + " " + shui + " " + huo + " " + tu;
            return wxnlzf;

            #region
            //foreach (var temp in list)
            //{
            //    if (temp.Contains("金"))
            //    {
            //        strJList.Add(temp.Trim());
            //    }
            //    else if (temp.Contains("木"))
            //    {
            //        strMList.Add(temp.Trim());
            //    }
            //    else if (temp.Contains("水"))
            //    {
            //        strSList.Add(temp.Trim());
            //    }
            //    else if (temp.Contains("火"))
            //    {
            //        strHList.Add(temp.Trim());
            //    }
            //    else
            //    {
            //        strTList.Add(temp.Trim());
            //    }
            //}
            //for (int i = 0; i < strJList.Count;i++ )
            //{
            //    strs = System.Text.RegularExpressions.Regex.Replace(strJList[i], "[\u4e00-\u9fa5]", "");
            //    strList.Add(strs);
            //}
            #endregion
        }
    }
}