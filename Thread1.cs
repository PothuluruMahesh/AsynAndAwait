using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Thread1
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 :"+i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine( "Test2 :"+i);
            }
        }
        static void Main(string[] args)
        {
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine("Main :"+i);
            }
            Test1();
            Test2();
        }
    }
}
