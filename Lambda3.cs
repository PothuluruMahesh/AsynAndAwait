using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Lambda3
    {
        delegate void MyDelegate(int i);
        static void Main(string[] args)
        {
            MyDelegate md=delegate(int i)
            {
                Console.WriteLine("Hello from first delegate annon i value is :"+i);
            };
            MyDelegate md1 = delegate (int i) { Console.WriteLine("Hello from first delegate annon i value is :" + i); };
            md(12);
            md1(20);
        }
    }
}
