using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Algorithm;

/// <summary>
/// Wuxing 的摘要说明
/// </summary>

public class WX
{
    public static string wx;
    public static string wxyuqi;
    public static string wxbq;
    public static string wxyq;
    public static string jin;
    public static string mu;

    public void GetWX()
    {
        string j, m, s, h, t, jin, mu, shui, huo, tu, r;
        string ganzhu = BaZi.nTianGan + BaZi.nDiZhi + BaZi.yTianGan + BaZi.yDiZhi + BaZi.rTianGan + BaZi.rDiZhi + BaZi.sTianGan + BaZi.sDiZhi;
        string tiangan = BaZi.nTianGan + "  " + BaZi.yTianGan + "  " + BaZi.rTianGan + "  " + BaZi.sTianGan;
        string zanggan = ZangGan.nz + "  " + ZangGan.yz + "  " + ZangGan.rz + "  " + ZangGan.sz;
        wx = CommonClass.Get_wx(ganzhu);
        string wxstr = wx.Length.ToString();
        j = wx.Replace("金", "").Length.ToString();
        m = wx.Replace("木", "").Length.ToString();
        s = wx.Replace("水", "").Length.ToString();
        h = wx.Replace("火", "").Length.ToString();
        t = wx.Replace("土", "").Length.ToString();
        jin = (Convert.ToInt32(wxstr) - Convert.ToInt32(j)).ToString();
        mu = (Convert.ToInt32(wxstr) - Convert.ToInt32(m)).ToString();
        shui = (Convert.ToInt32(wxstr) - Convert.ToInt32(s)).ToString();
        huo = (Convert.ToInt32(wxstr) - Convert.ToInt32(h)).ToString();
        tu = (Convert.ToInt32(wxstr) - Convert.ToInt32(t)).ToString();
        wxbq = jin + "个金" + "，" + mu + "个木" + "，" + shui + "个水" + "，" + huo + "个火" + "，" + tu + "个土";

        wxyuqi = CommonClass.Get_wx(tiangan) + CommonClass.Get_wx(zanggan);
        string wxyuqistr = wxyuqi.Length.ToString();
        j = wxyuqi.Replace("金", "").Length.ToString();
        m = wxyuqi.Replace("木", "").Length.ToString();
        s = wxyuqi.Replace("水", "").Length.ToString();
        h = wxyuqi.Replace("火", "").Length.ToString();
        t = wxyuqi.Replace("土", "").Length.ToString();
        jin = (Convert.ToInt32(wxyuqistr) - Convert.ToInt32(j)).ToString();
        mu = (Convert.ToInt32(wxyuqistr) - Convert.ToInt32(m)).ToString();
        shui = (Convert.ToInt32(wxyuqistr) - Convert.ToInt32(s)).ToString();
        huo = (Convert.ToInt32(wxyuqistr) - Convert.ToInt32(h)).ToString();
        tu = (Convert.ToInt32(wxyuqistr) - Convert.ToInt32(t)).ToString();
        wxyq = jin + "个金" + "，" + mu + "个木" + "，" + shui + "个水" + "，" + huo + "个火" + "，" + tu + "个土";


    }
}