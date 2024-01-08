using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jan8Reflections
{
    internal class Program
    {
        public static void Fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" fun1"); Thread.Sleep(5000);
            }
        }
        public static void Fun2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" fun2"); Thread.Sleep(5000);
            }
        }
        static void Main(string[] args)//parent thread 
        {
            Program p = new Program();
            //   Thread childTh1 = new Thread(new ThreadStart(p.Fun1));
            Thread t1 = new Thread(Fun1);
            t1.Start();
            Thread t2 = new Thread(Fun2);
            t2.Start();

        }
    }
}

