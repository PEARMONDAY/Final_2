using System;

namespace final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  : ");
            int num = int.Parse(Console.ReadLine());
            int[] a = new int[num];
            Console.WriteLine("This your {0}", num);
            for (int i = 0; i < num; i++)
            {
                Console.Write("amount - {0} ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    if (a[j] < a[i])
                    {
                        int tem = a[i];
                        a[i] = a[j];
                        a[j] = tem;

                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("");
        }
    }    
}