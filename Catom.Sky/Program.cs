using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catom.Sky.Component.Util;

namespace Catom.Sky
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = "aaaaa";
                Console.WriteLine(a[6]);
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(e);
            }
        }
    }
}
