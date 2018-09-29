using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Thread3
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(() => 
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            });
            Thread th1 = new Thread(() =>
            {
                for (int i = 100; i <= 200; i++)
                {
                    Console.WriteLine(i);
                }
            });
            th.Start();
            th1.Start();
        }
    }
}
