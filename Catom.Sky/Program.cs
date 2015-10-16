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
                var a = new[] { 1, 2, 4, 5 };
                Console.WriteLine(a[7]);
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(e);
            }
        }
    }
}
