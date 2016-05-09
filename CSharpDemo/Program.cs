using System;

namespace CSharpDemo
{
    class Program
    {
        enum PType
        {
            湖北 = 1,
            浙江 = 2
        }

        static void Main(string[] args)
        {
            PType p = PType.湖北;
            Console.WriteLine((int)PType.浙江);
        }
    }
}
