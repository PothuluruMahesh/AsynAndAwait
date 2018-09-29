using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Async3
    {
        private static void Method1()
        {
             for (int i = 21; i <= 40; i++)
                {
                    Console.WriteLine("Method1 :" + i);
                }
           
        }
        private static void Method2()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Method2 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Task t1 = new Task(Method1);
            Task t2 = new Task(Method2);
            t1.RunSynchronously();
            t1.RunSynchronously();
        }
    }
}
