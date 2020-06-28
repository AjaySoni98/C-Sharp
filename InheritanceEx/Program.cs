using System;

namespace InheritanceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var clsA = new A();
            var clsB = new B();
            var clsC = new C();
            clsC.msg();
        }
    }
}
