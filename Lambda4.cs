using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Lambda4
    {
        delegate void MyDelegate(int i);
        static void Main(string[] args)
        {
            MyDelegate md =(i) =>
            {
                Console.WriteLine("Hello from first delegate annon i value is :" + i);
            };
            MyDelegate md1 =(int i) => 
            {
                Console.WriteLine("Hello from first delegate annon i value is :" + i);
            };
            md(12);
            md1(20);
        }
    }
}
