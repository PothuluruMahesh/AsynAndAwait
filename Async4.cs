using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Async4
    {
        static void Main(string[] args)
        {
            TestLoops();
            Console.Read();
        }

        private static async void TestLoops()
        {
            for (int i = 0; i < 100; i++)
            {
                await TestAsync(i);
            }
        }

        private static Task TestAsync(int i)
        {
            return Task.Run(() => TaskToDo(i));
        }

        private  static void TaskToDo(int i)
        {
            
            Console.WriteLine(i);
        }
    }
}
