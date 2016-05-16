using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using System.Text.RegularExpressions;
using System.Threading;

namespace CSharpDemo.ReflectionTest
{
    // 工具对象
    class Book
    {
        public long Id;

        public string Name { get; set; }

        public string Author { get; set; }

        public Book()
        {
        }

        public bool SetBookName(string bookName)
        {
            this.Name = bookName;
            return true;
        }

    }

    public static class DataHelper
    {
        //public static IEnumerable<T> Get<T>(this IEnumerable<T> source, Expression<Func<T, bool>> expression)
        //{
        //    return source.Where(expression);
        //}
    }

    class ReflectionContext
    {
        public void Init()
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
            // 反射获取对象的赋过值的属性
            var user = new Book { Id = 2, Name = "" };
            var tp = user.GetType();
            var prps = tp.GetProperties();

            var dic = new Dictionary<string, object>();
            foreach (var p in prps)
            {
                var value = p.GetValue(user);
                if (value != null)
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

    // 测试体类
    public class DynObj : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return base.TryGetMember(binder, out result);
        }
    }

    public class Entry
    {
        public static void Main1()
        {
            new ReflectionContext().Init();
        }
    }

}
