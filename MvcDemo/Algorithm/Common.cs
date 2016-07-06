using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Common 的摘要说明
/// </summary>

public class CommonClass
{
    /// <summary>
    /// 地支藏干算法。
    /// 子藏癸 卯藏乙 午藏丁己  酉藏辛
    /// 寅藏 甲丙戊  巳藏 丙庚戊  申藏 庚壬戊  亥藏 甲壬
    /// 丑藏 辛癸己 辰藏 癸乙戊  未藏 乙丁己  戌藏 丁辛戊
    /// </summary>
    /// <param name="dizhi"></param>
    /// <returns></returns>
    public static string[] dizang(string dizhi)
    {
        string[] returnstring = new string[3];
        if (dizhi.Equals("子"))
        {
            returnstring[0] = "癸";
        }
        if (dizhi.Equals("丑"))
        {

            returnstring[0] = "己";
            returnstring[1] = "癸";
            returnstring[2] = "辛";

        }
        if (dizhi.Equals("寅"))
        {
            returnstring[0] = "甲";
            returnstring[1] = "丙";
            returnstring[2] = "戊";
        }
        if (dizhi.Equals("卯"))
        {
            returnstring[0] = "乙";
        }

        if (dizhi.Equals("辰"))
        {

            returnstring[0] = "戊";
            returnstring[1] = "乙";
            returnstring[2] = "癸";

        }

        if (dizhi.Equals("巳"))
        {

            returnstring[0] = "丙";
            returnstring[1] = "戊";
            returnstring[2] = "庚";
        }

        if (dizhi.Equals("午"))
        {
            returnstring[0] = "丁";
            returnstring[1] = "己";
        }

        if (dizhi.Equals("未"))
        {

            returnstring[0] = "己";
            returnstring[1] = "丁";
            returnstring[2] = "乙";

        }

        if (dizhi.Equals("申"))
        {

            returnstring[0] = "庚";
            returnstring[1] = "壬";
            returnstring[2] = "戊";
        }

        if (dizhi.Equals("酉"))
        {
            returnstring[0] = "辛";

        }

        if (dizhi.Equals("戌"))
        {
            returnstring[0] = "戊";
            returnstring[1] = "辛";
            returnstring[2] = "丁";

        }

        if (dizhi.Equals("亥"))
        {

            returnstring[0] = "壬";
            returnstring[1] = "甲";

        }

        return returnstring;

    }


    public static string yinyang(string paramString)
    {
        if (!string.IsNullOrEmpty(paramString))
        {
            if ((paramString.Equals("甲")) || (paramString.Equals("丙")) || (paramString.Equals("戊")) || (paramString.Equals("庚")) || (paramString.Equals("壬")))
            {
                return "阳";
            }
            if ((paramString.Equals("乙")) || (paramString.Equals("丁")) || (paramString.Equals("己")) || (paramString.Equals("辛")) || (paramString.Equals("癸")))
            {
                return "阴";
            }
        }
        return "";
    }

    //获取五行关系
    public static Dictionary<string, string> GetWXGX()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add("金水", "生");
        myDictionary.Add("水金", "被生");
        myDictionary.Add("水木", "生");
        myDictionary.Add("木水", "被生");
        myDictionary.Add("木火", "生");
        myDictionary.Add("火木", "被生");
        myDictionary.Add("火土", "生");
        myDictionary.Add("土火", "被生");
        myDictionary.Add("土金", "生");
        myDictionary.Add("金土", "被生");
        myDictionary.Add("金木", "克");
        myDictionary.Add("木金", "被克");
        myDictionary.Add("木土", "克");
        myDictionary.Add("土木", "被克");
        myDictionary.Add("土水", "克");
        myDictionary.Add("水土", "被克");
        myDictionary.Add("水火", "克");
        myDictionary.Add("火水", "被克");
        myDictionary.Add("火金", "克");
        myDictionary.Add("金火", "被克");
        myDictionary.Add("金金", "");
        myDictionary.Add("木木", "");
        myDictionary.Add("水水", "");
        myDictionary.Add("火火", "");
        myDictionary.Add("土土", "");
        return myDictionary;
    }

    //五行
    public static Dictionary<string, string> GetWX()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add("生", "日干生");
        myDictionary.Add("被生", "生日干");
        myDictionary.Add("克", "日干克");
        myDictionary.Add("被克", "克日干");
        myDictionary.Add("", "同日干");
        return myDictionary;
    }

    //阴阳关系
    public static Dictionary<string, string> GetYYGX()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add("阴阳", "与日干阴阳不同");
        myDictionary.Add("阳阴", "与日干阴阳不同");
        myDictionary.Add("阴阴", "与日干阴阳相同");
        myDictionary.Add("阳阳", "与日干阴阳相同");
        return myDictionary;
    }

    //十神
    public static Dictionary<string, string> GetShiShen()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add("与日干阴阳不同，生日干", "正印");
        myDictionary.Add("与日干阴阳相同，生日干", "枭神");
        myDictionary.Add("与日干阴阳相同，克日干", "七杀");
        myDictionary.Add("与日干阴阳不同，克日干", "正官");
        myDictionary.Add("与日干阴阳不同，同日干", "劫财");
        myDictionary.Add("与日干阴阳相同，同日干", "比肩");
        myDictionary.Add("与日干阴阳不同，日干生", "伤官");
        myDictionary.Add("与日干阴阳相同，日干生", "食神");
        myDictionary.Add("与日干阴阳不同，日干克", "正财");
        myDictionary.Add("与日干阴阳相同，日干克", "偏财");
        return myDictionary;
    }


    //五行
    public static string Get_wx(string horoscope)
    {
        string[] m = new string[] { "甲", "乙", "寅", "卯" };
        string[] h = new string[] { "丙", "丁", "巳", "午" };
        string[] t = new string[] { "戊", "己", "丑", "辰", "未", "戌" };
        string[] j = new string[] { "庚", "辛", "申", "酉" };
        string[] s = new string[] { "壬", "癸", "子", "亥" };
        if (!string.IsNullOrEmpty(horoscope))
        {
            foreach (string element in m)
            {
                horoscope = horoscope.Replace(element, "木");
            }
            foreach (string element in h)
            {
                horoscope = horoscope.Replace(element, "火");
            }
            foreach (string element in t)
            {
                horoscope = horoscope.Replace(element, "土");
            }
            foreach (string element in j)
            {
                horoscope = horoscope.Replace(element, "金");
            }
            foreach (string element in s)
            {
                horoscope = horoscope.Replace(element, "水");
            }
        }
        return horoscope;
    }


    public static Dictionary<string, string> GetShengRiGan()
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        myDictionary.Add("生水", "金");
        myDictionary.Add("生木", "水");
        myDictionary.Add("生火", "木");
        myDictionary.Add("生土", "火");
        myDictionary.Add("生金", "土");
        return myDictionary;
    }

    //string[][] shengwang = new string[][]{  
    //new string []{"天干", "长生", "沐浴", "冠带", "临官", "帝旺", "衰", "病", "死", "墓", "绝", "胎", "养"},  
    //new string []{"甲", "亥", "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌"},  
    //new string []{"丙", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥", "子", "丑"},  
    //new string []{"戊", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥", "子", "丑"},  
    //new string []{"庚", "巳", "午", "未", "申", "酉", "戌", "亥", "子", "丑", "寅", "卯", "辰"},  
    //new string []{"壬", "申", "酉", "戌", "亥", "子", "丑", "寅", "卯", "辰", "巳", "午", "未"},  
    //new string []{"乙", "午", "巳", "辰", "卯", "寅", "丑", "子", "亥", "戌", "酉", "申", "未"},  
    //new string []{"丁", "酉", "申", "未", "午", "巳", "辰", "卯", "寅", "丑", "子", "亥", "戌"},  
    //new string []{"己", "酉", "申", "未", "午", "巳", "辰", "卯", "寅", "丑", "子", "亥", "戌"},  
    //new string []{"辛", "子", "亥", "戌", "酉", "申", "未", "午", "巳", "辰", "卯", "寅", "丑"},  
    //new string []{"癸", "卯", "寅", "丑", "子", "亥", "戌", "酉", "申", "未", "午", "巳", "辰"},};

}
