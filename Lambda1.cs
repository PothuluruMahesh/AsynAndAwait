using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Lambda1
    {
        public void Test1()
        {
            Console.WriteLine("From Test1()");
        }
        public void Test2(int i)
        {
            Console.WriteLine("From Test2(int)");
        }
        static void Main(string[] args)
        {
            Lambda1 lb = new Lambda1();
            Console.WriteLine("From Main Start........");
            lb.Test1();
            lb.Test2(20);
            Console.WriteLine("From Main End..........");
        }
    }
}
