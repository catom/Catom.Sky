using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catom.Sky.Component.Util;

namespace Catom.Sky
{
    public class A
    {
        public A()
        {
            System.Console.WriteLine("This is A.");
        }
    }

    public class B : P
    {
        int i = 11;

        public A a = new A();

        public B()
        {
            System.Console.WriteLine("This is B." + i);
        }
    }

    public class P
    {
        public P()
        {
            System.Console.WriteLine("This is P.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            a = (decimal)123/123;
            Console.WriteLine(a.ToString("f2"));


        }
    }




}
