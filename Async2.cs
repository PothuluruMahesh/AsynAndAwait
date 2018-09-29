using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Async2
    {
        private static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 21; i <= 40; i++)
                {
                    Console.WriteLine("Method1 :" + i);
                }
            });
        }
        private static void Method2()
        {
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine("Method2 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Method1();
            Method2();
        }
    }
}
