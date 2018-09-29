using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Lambda5
    {
        delegate string Delegate5(int i, string j);
        static void Main(string[] args)
        {
            Delegate5 dg1 = (i, j) => {
                Console.WriteLine("from Lambda values is ::{0}:{1}", i, j);
                return "SVCE";
            };
            Delegate5 dg2 = (i, j) => {
                Console.WriteLine("From Lambda i and j values is :" + i + "::" + j);
                return "SVDC";
            };
            string s1=dg1(101, "Mahesh");
            string s2=dg2(102, "Mahi");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
