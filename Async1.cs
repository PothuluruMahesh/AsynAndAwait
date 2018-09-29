using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Async1
    {
        static void Main(string[] args)
        {
            TestAsyncAwaitMethods();
            Thread.Sleep(5000);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        public async static void TestAsyncAwaitMethods()
        {
            await LongRunningMethod();
        }

        public static async Task<int> LongRunningMethod()
        {
            Console.WriteLine("Starting Long Running method...");
            
            Console.WriteLine("End Long Running method...");
            return 1;
        }
    }
}
