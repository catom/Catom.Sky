namespace Algorithm
{
    /// <summary>
    /// 获取八字的地支藏干
    /// **注：此类废弃！方法迁移至CommonClass类
    /// </summary>
    public class Canggan
    {
        #region

        public static string[] nzhanggan;//年臧干
        public static string[] yzhanggan;//月臧干
        public static string[] rzhanggan;//日臧干
        public static string[] szhanggan;//时臧干
        public static string nz = "";
        public static string yz = "";
        public static string rz = "";
        public static string sz = "";
        
        #endregion

        /// <summary>
        /// 根据地支获取臧干
        /// </summary>
        public void GetCanggan()
        {
            //nzhanggan = CommonClass.dizang(Bazi.nDiZhi);
            //foreach (string t in nzhanggan)
            //{
            //    if (t == null)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        nz = nzhanggan[0] + nzhanggan[1] + nzhanggan[2];
            //    }
            //}

            //yzhanggan = CommonClass.dizang(Bazi.yDiZhi);
            //foreach (string t in yzhanggan)
            //{
            //    if (t == null)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        yz = yzhanggan[0] + yzhanggan[1] + yzhanggan[2];
            //    }
            //}

            //rzhanggan = CommonClass.dizang(Bazi.rDiZhi);
            //foreach (string t in rzhanggan)
            //{
            //    if (t == null)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        rz = rzhanggan[0] + rzhanggan[1] + rzhanggan[2];
            //    }
            //}

            //szhanggan = CommonClass.dizang(Bazi.sDiZhi);
            //for (int i = 0; i < szhanggan.Length; i++)
            //{
            //    if (szhanggan[i] == null)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sz = szhanggan[0] + szhanggan[1] + szhanggan[2];
            //    }
            //}
        }

    }
}