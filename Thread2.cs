using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Thread2
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t1.Start();
            t2.Start();
            
           
        }
    }
}
