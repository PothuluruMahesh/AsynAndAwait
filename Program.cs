using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = {1,4,5,8,9,12,22,13,17};
            int[] y = { 2, 4,7, 5, 12, 34, 56, 6, 18 };
            Console.WriteLine("The first Given Array is :");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+" ");
            }
            Console.WriteLine("\nThe Second Given Array is :");
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i]+" ");
            }
            Console.WriteLine();
            int length = x.Length + y.Length;
            int[] z=new int[length];
            int value = 0;
            foreach(int i in x)
            {
                z[value] = i;
                value++;
            }
            foreach (int i in y)
            {
                z[value] = i;
                value++;
            }
            Console.Write("\nThe Combined Array Both is : ");
            for (int i=0;i<z.Length;i++)
            {
                Console.Write(z[i] + " ");
            }
            Console.Write("\n");
            Console.Write(" \n");
            for(int i=0;i<z.Length;i++)
            {
                for(int j=0;j<z.Length;j++)
                {
                    if(z[i] < z[j])
                    {
                        int temp = z[j];
                        z[j] = z[i];
                        z[i] = temp;
                    }  
                }  
            }
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write(z[i] + " ");
            }
            Console.Write("\n ");
        }
    }
}
