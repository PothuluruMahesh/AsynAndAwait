using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Lambda6
    {
        delegate void Delegate6();
        static void Main(string[] args)
        {
            int i = 120;//it doesn't allow jump statements
            Delegate6 dg = () => { Console.WriteLine("The vales of I is :" + i); };
            dg();
        }
    }
}
