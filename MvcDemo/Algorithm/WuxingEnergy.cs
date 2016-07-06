using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Algorithm;

/// <summary>
/// WuxingEnergy 的摘要说明
/// </summary>
public class WXNL
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
        if (BaZi.nDiZhi == "子" && (ZangGan.nzhanggan.Contains("癸")))
        {
            r1 = CommonClass.Get_wx(ZangGan.nz);
            result1 = BaZi.nDiZhi + "中藏：" + ZangGan.nz + r1 + 100;
        }
        else if (BaZi.yDiZhi == "子" && ZangGan.yzhanggan.Contains("癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yz);
            result1 = BaZi.yDiZhi + "中藏：" + ZangGan.yz + r1 + 100;
        }
        else if (BaZi.rDiZhi == "子" && ZangGan.rzhanggan.Contains("癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rz);
            result1 = BaZi.rDiZhi + "中藏：" + ZangGan.rz + r1 + 100;
        }
        else if (BaZi.sDiZhi == "子" && ZangGan.szhanggan.Contains("癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.sz);
            result1 = BaZi.sDiZhi + "中藏：" + ZangGan.sz + r1 + 100;
        }
        #endregion

        #region 丑：己癸辛
        if (BaZi.nDiZhi == "丑" && (ZangGan.nzhanggan[0] == "己" && ZangGan.nzhanggan[1] == "癸" && ZangGan.nzhanggan[2] == "辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result2 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }

        if (BaZi.yDiZhi == "丑" && (ZangGan.yzhanggan[0] == "己" && ZangGan.yzhanggan[1] == "癸" && ZangGan.yzhanggan[2] == "辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result2 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }

        if (BaZi.rDiZhi == "丑" && (ZangGan.rzhanggan[0] == "己" && ZangGan.rzhanggan[1] == "癸" && ZangGan.rzhanggan[2] == "辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result2 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }

        if (BaZi.sDiZhi == "丑" && (ZangGan.szhanggan[0] == "己" && ZangGan.szhanggan[1] == "癸" && ZangGan.szhanggan[2] == "辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result2 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 寅：甲丙戊

        if (BaZi.nDiZhi == "寅" && (ZangGan.nzhanggan[0] == "甲" && ZangGan.nzhanggan[1] == "丙" && ZangGan.nzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result3 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }
        if (BaZi.yDiZhi == "寅" && (ZangGan.yzhanggan[0] == "甲" && ZangGan.yzhanggan[1] == "丙" && ZangGan.yzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result3 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }
        if (BaZi.rDiZhi == "寅" && (ZangGan.rzhanggan[0] == "甲" && ZangGan.rzhanggan[1] == "丙" && ZangGan.rzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result3 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }
        if (BaZi.sDiZhi == "寅" && (ZangGan.szhanggan[0] == "甲" && ZangGan.szhanggan[1] == "丙" && ZangGan.szhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result3 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 卯：乙

        if (BaZi.nDiZhi == "卯" && ZangGan.nzhanggan.Contains("乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nz);
            result4 = BaZi.nDiZhi + "中藏：" + ZangGan.nz + r1 + 100;
        }
        else if (BaZi.yDiZhi == "卯" && ZangGan.yzhanggan.Contains("乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yz);
            result4 = BaZi.yDiZhi + "中藏：" + ZangGan.yz + r1 + 100;
        }
        else if (BaZi.rDiZhi == "卯" && ZangGan.rzhanggan.Contains("乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rz);
            result4 = BaZi.rDiZhi + "中藏：" + ZangGan.rz + r1 + 100;
        }
        else if (BaZi.sDiZhi == "卯" && ZangGan.szhanggan.Contains("乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.sz);
            result4 = BaZi.sDiZhi + "中藏：" + ZangGan.sz + r1 + 100;
        }


        #endregion

        #region 辰：戊乙癸

        if (BaZi.nDiZhi == "辰" && (ZangGan.nzhanggan[0] == "戊" && ZangGan.nzhanggan[1] == "乙" && ZangGan.nzhanggan[2] == "癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result5 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }

        if (BaZi.yDiZhi == "辰" && (ZangGan.yzhanggan[0] == "戊" && ZangGan.yzhanggan[1] == "乙" && ZangGan.yzhanggan[2] == "癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result5 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }

        if (BaZi.rDiZhi == "辰" && (ZangGan.rzhanggan[0] == "戊" && ZangGan.rzhanggan[1] == "乙" && ZangGan.rzhanggan[2] == "癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result5 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }

        if (BaZi.sDiZhi == "辰" && (ZangGan.szhanggan[0] == "戊" && ZangGan.szhanggan[1] == "乙" && ZangGan.szhanggan[2] == "癸"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result5 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 巳：丙戊庚
        if (BaZi.nDiZhi == "巳" && (ZangGan.nzhanggan[0] == "丙" && ZangGan.nzhanggan[1] == "戊" && ZangGan.nzhanggan[2] == "庚"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result6 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }
        if (BaZi.yDiZhi == "巳" && (ZangGan.yzhanggan[0] == "丙" && ZangGan.yzhanggan[1] == "戊" && ZangGan.yzhanggan[2] == "庚"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result6 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }
        if (BaZi.rDiZhi == "巳" && (ZangGan.rzhanggan[0] == "丙" && ZangGan.rzhanggan[1] == "戊" && ZangGan.rzhanggan[2] == "庚"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result6 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }
        if (BaZi.sDiZhi == "巳" && (ZangGan.szhanggan[0] == "丙" && ZangGan.szhanggan[1] == "戊" && ZangGan.szhanggan[2] == "庚"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result6 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 午：丁己
        if (BaZi.nDiZhi == "午" && (ZangGan.nzhanggan[0] == "丁" && ZangGan.nzhanggan[1] == "己"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            result7 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 70 + " " + ZangGan.nzhanggan[1] + r2 + 30;
        }

        if (BaZi.yDiZhi == "午" && (ZangGan.yzhanggan[0] == "丁" && ZangGan.yzhanggan[1] == "己"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            result7 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 70 + " " + ZangGan.yzhanggan[1] + r2 + 30;
        }

        if (BaZi.rDiZhi == "午" && (ZangGan.rzhanggan[0] == "丁" && ZangGan.rzhanggan[1] == "己"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            result7 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 70 + " " + ZangGan.rzhanggan[1] + r2 + 30;
        }
        if (BaZi.sDiZhi == "午" && (ZangGan.szhanggan[0] == "丁" && ZangGan.szhanggan[1] == "己"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            result7 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 70 + " " + ZangGan.szhanggan[1] + r2 + 30;
        }

        #endregion

        #region 未：己丁乙

        if (BaZi.nDiZhi == "未" && (ZangGan.nzhanggan[0] == "己" && ZangGan.nzhanggan[1] == "丁" && ZangGan.nzhanggan[2] == "乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result8 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }
        if (BaZi.yDiZhi == "未" && (ZangGan.yzhanggan[0] == "己" && ZangGan.yzhanggan[1] == "丁" && ZangGan.yzhanggan[2] == "乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result8 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }
        if (BaZi.rDiZhi == "未" && (ZangGan.rzhanggan[0] == "己" && ZangGan.rzhanggan[1] == "丁" && ZangGan.rzhanggan[2] == "乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result8 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }

        if (BaZi.sDiZhi == "未" && (ZangGan.szhanggan[0] == "己" && ZangGan.szhanggan[1] == "丁" && ZangGan.szhanggan[2] == "乙"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result8 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 申：庚壬戊

        if (BaZi.nDiZhi == "申" && (ZangGan.nzhanggan[0] == "庚" && ZangGan.nzhanggan[1] == "壬" && ZangGan.nzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result9 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }
        if (BaZi.yDiZhi == "申" && (ZangGan.yzhanggan[0] == "庚" && ZangGan.yzhanggan[1] == "壬" && ZangGan.yzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result9 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }
        if (BaZi.rDiZhi == "申" && (ZangGan.rzhanggan[0] == "庚" && ZangGan.rzhanggan[1] == "壬" && ZangGan.rzhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result9 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }
        if (BaZi.sDiZhi == "申" && (ZangGan.szhanggan[0] == "庚" && ZangGan.szhanggan[1] == "壬" && ZangGan.szhanggan[2] == "戊"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result9 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 酉：辛

        if (BaZi.nDiZhi == "酉" && ZangGan.nzhanggan.Contains("辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nz);
            result10 = BaZi.nDiZhi + "中藏：" + ZangGan.nz + r1 + 100;
        }

        if (BaZi.yDiZhi == "酉" && ZangGan.yzhanggan.Contains("辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yz);
            result10 = BaZi.yDiZhi + "中藏：" + ZangGan.yz + r1 + 100;
        }

        if (BaZi.rDiZhi == "酉" && ZangGan.rzhanggan.Contains("辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rz);
            result10 = BaZi.rDiZhi + "中藏：" + ZangGan.rz + r1 + 100;
        }

        if (BaZi.sDiZhi == "酉" && ZangGan.szhanggan.Contains("辛"))
        {
            r1 = CommonClass.Get_wx(ZangGan.sz);
            result10 = BaZi.sDiZhi + "中藏：" + ZangGan.sz + r1 + 100;
        }

        #endregion

        #region 戌：戊辛丁

        if (BaZi.nDiZhi == "戌" && (ZangGan.nzhanggan[0] == "戊" && ZangGan.nzhanggan[1] == "辛" && ZangGan.nzhanggan[2] == "丁"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.nzhanggan[2]);
            result11 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 60 + " " + ZangGan.nzhanggan[1] + r2 + 30 + " " + ZangGan.nzhanggan[2] + r3 + 10;
        }

        if (BaZi.yDiZhi == "戌" && (ZangGan.yzhanggan[0] == "戊" && ZangGan.yzhanggan[1] == "辛" && ZangGan.yzhanggan[2] == "丁"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.yzhanggan[2]);
            result11 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 60 + " " + ZangGan.yzhanggan[1] + r2 + 30 + " " + ZangGan.yzhanggan[2] + r3 + 10;
        }
        if (BaZi.rDiZhi == "戌" && (ZangGan.rzhanggan[0] == "戊" && ZangGan.rzhanggan[1] == "辛" && ZangGan.rzhanggan[2] == "丁"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.rzhanggan[2]);
            result11 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 60 + " " + ZangGan.rzhanggan[1] + r2 + 30 + " " + ZangGan.rzhanggan[2] + r3 + 10;
        }
        if (BaZi.sDiZhi == "戌" && (ZangGan.szhanggan[0] == "戊" && ZangGan.szhanggan[1] == "辛" && ZangGan.szhanggan[2] == "丁"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            r3 = CommonClass.Get_wx(ZangGan.szhanggan[2]);
            result11 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 60 + " " + ZangGan.szhanggan[1] + r2 + 30 + " " + ZangGan.szhanggan[2] + r3 + 10;
        }

        #endregion

        #region 亥：壬甲

        if (BaZi.nDiZhi == "亥" && (ZangGan.nzhanggan[0] == "壬" && ZangGan.nzhanggan[1] == "甲"))
        {
            r1 = CommonClass.Get_wx(ZangGan.nzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.nzhanggan[1]);
            result12 = BaZi.nDiZhi + "中藏：" + ZangGan.nzhanggan[0] + r1 + 70 + " " + ZangGan.nzhanggan[1] + r2 + 30;
        }
        if (BaZi.yDiZhi == "亥" && (ZangGan.yzhanggan[0] == "壬" && ZangGan.yzhanggan[1] == "甲"))
        {
            r1 = CommonClass.Get_wx(ZangGan.yzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.yzhanggan[1]);
            result12 = BaZi.yDiZhi + "中藏：" + ZangGan.yzhanggan[0] + r1 + 70 + " " + ZangGan.yzhanggan[1] + r2 + 30;
        }
        if (BaZi.rDiZhi == "亥" && (ZangGan.rzhanggan[0] == "壬" && ZangGan.rzhanggan[1] == "甲"))
        {
            r1 = CommonClass.Get_wx(ZangGan.rzhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.rzhanggan[1]);
            result12 = BaZi.rDiZhi + "中藏：" + ZangGan.rzhanggan[0] + r1 + 70 + " " + ZangGan.rzhanggan[1] + r2 + 30;
        }

        if (BaZi.sDiZhi == "亥" && (ZangGan.szhanggan[0] == "壬" && ZangGan.szhanggan[1] == "甲"))
        {
            r1 = CommonClass.Get_wx(ZangGan.szhanggan[0]);
            r2 = CommonClass.Get_wx(ZangGan.szhanggan[1]);
            result12 = BaZi.sDiZhi + "中藏：" + ZangGan.szhanggan[0] + r1 + 70 + " " + ZangGan.szhanggan[1] + r2 + 30;
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

        string ngwxzf = BaZi.nTianGan + CommonClass.Get_wx(BaZi.nTianGan) + 100;
        string ygwxzf = BaZi.yTianGan + CommonClass.Get_wx(BaZi.yTianGan) + 100;
        string rgwxzf = BaZi.rTianGan + CommonClass.Get_wx(BaZi.rTianGan) + 100;
        string sgwxzf = BaZi.sTianGan + CommonClass.Get_wx(BaZi.sTianGan) + 100;

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