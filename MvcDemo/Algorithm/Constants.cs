using System.Collections.Generic;

/// <summary>
/// 常量类
///     放置各种计算所需的固定常量
/// </summary>
public class FortuneConstants
{
    /// <summary>
    ///  天干
    /// </summary>
    public static string[] Tiangan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };

    /// <summary>
    ///  地支
    /// </summary>
    public static string[] Dizhi = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };

    /// <summary>
    /// 农历月份汉字与数字对应关系集合
    /// </summary>
    public static Dictionary<string, int> DicLunarMonth = new Dictionary<string, int>
    {
         {"一", 1}, {"二", 2}, {"三", 3}, {"四", 4}, {"五", 5}, {"六", 6}, {"七", 7}, {"八", 8}, {"九", 9}, {"十", 10}, {"十一", 11}, {"十二", 12},
         {"正", 1}, {"冬",11}, {"腊",12}, 
         {"闰一", 1},{"闰二", 2},{"闰三", 3},{"闰四", 4},{"闰五", 5},{"闰六", 6},{"闰七", 7},{"闰八", 8},{"闰九", 9},{"闰十", 10},{"闰十一", 11},{"闰十二", 12},
         {"闰正", 1},{"闰冬", 11},{"闰腊", 12},
    };

    /// <summary>
    ///  节气对应的月份下标关系集（只限用于中间计算）
    /// </summary>
    public static Dictionary<string, int> DicSolarTermMonth = new Dictionary<string, int>
    {
        {"立春",1},{"雨水",1},{"惊蛰",2},{"春分",2},{"清明",3},{"谷雨",3},{"立夏",4},{"小满",4},{"芒种",5},{"夏至",5},{"小暑",6},{"大暑",6},
        {"立秋",7},{"处暑",7},{"白露",8},{"秋分",8},{"寒露",9},{"霜降",9},{"立冬",10},{"小雪",10},{"大雪",11},{"冬至",11},{"小寒",12},{"大寒",12}
    };

    /// <summary>
    ///  地支藏干字典
    /// </summary>
    public static Dictionary<string, string[]> DicCangGan = new Dictionary<string, string[]>
    {
        {"子", new []{"癸"}},
        {"丑", new []{"己癸辛"}},
        {"寅", new []{"甲丙戊"}},
        {"卯", new []{"乙"}},
        {"辰", new []{"戊乙癸"}},
        {"巳", new []{"丙戊庚"}},
        {"午", new []{"丁己"}},
        {"未", new []{"己丁乙"}},
        {"申", new []{"庚壬戊"}},
        {"酉", new []{"辛"}},
        {"戌", new []{"戊辛丁"}},
        {"亥", new []{"壬甲"}},
    };

    /// <summary>
    ///  天干阴阳关系集合
    /// </summary>
    public static Dictionary<string, string> DicGanYinyang = new Dictionary<string, string>
    {
        { "甲", "阳" }, { "丙", "阳" }, { "戊", "阳" }, { "庚", "阳" }, { "壬", "阳" }, { "乙", "阴" }, { "丁", "阴" }, { "己", "阴" }, { "辛", "阴" }, { "癸", "阴" },
    };

    /// <summary>
    ///  天干五行关系集合
    /// </summary>
    public static Dictionary<string, string> DicGanWuxing = new Dictionary<string, string>
    {
        {"甲","木"},{"乙","木"},{"丙","火"},{"丁","火"},{"戊","土"},{"己","土"},{"庚","金"},{"辛","金"},{"壬","水"},{"癸","水"},
    };

    /// <summary>
    ///  地支五行关系集合
    /// </summary>
    public static Dictionary<string, string> DicZhiWuxing = new Dictionary<string, string>
    {
        {"子","水"},{"丑","土"},{"寅","木"},{"卯","木"},{"辰","土"},{"巳","火"},{"午","火"},{"未","土"},{"申","金"},{"酉","金"},{"戌","土"},{"亥","水"},
    };

    /// <summary>
    ///  五行方位字典
    /// </summary>
    public static Dictionary<string, string> DicWuxingDirection = new Dictionary<string, string>
    {
        {"木","东"},{"火","南"},{"土","中"},{"金","西"},{"水","北"},
    };

}