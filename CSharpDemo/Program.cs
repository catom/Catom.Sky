using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    class Program
    {
        class User
        {

            public int Id { get; set; }

            public string Name { get; set; }

            // 测试int默认值
            public int? Index { get; set; }

            // 测试 DateTime 默认值
            public DateTime? CreateTime { get; set; }
        }


        static void Main(string[] args)
        {
            // Anonymous Object
            var obj = new { Id = 1 };
            var type = obj.GetType();
            var props = type.GetProperties();

            //Console.WriteLine(type.Name.ToLower().Contains("anonymous"));
            //foreach (var p in props)
            //{
            //    //Console.WriteLine(p.Name);
            //    var attr = p.GetCustomAttributes(typeof(User), false);
            //    Console.WriteLine(attr.Count());
            //    foreach (var a in attr)
            //    {
            //        Console.WriteLine(a);
            //    }
            //}


            // Named Class
            // 反射获取对象的属性值
            var user = new User { Id = 2, Name = "name" };
            var tp = user.GetType();
            var prps = tp.GetProperties();

            var dic = new Dictionary<string, object>();
            foreach (var p in prps)
            {
                var value = p.GetValue(user, null);
                if (p.GetValue(user, null) != null)
                {
                    dic.Add(p.Name, value);
                }
            }

            foreach (var pair in dic)
            {
                Console.WriteLine(@"属性{0}={1}", pair.Key, pair.Value);
            }

        }
    }
}
