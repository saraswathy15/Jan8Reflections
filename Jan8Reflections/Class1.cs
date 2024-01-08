using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Reflections
{
    internal class Class1
    {
        public static async Task Fun1()
        {
            await Task.Run(() => {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(" Fun1 is running");
                    Task.Delay(1000).Wait();
                }
            });
        }
        public static void Fun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fun2 is running"); Task.Delay(2000).Wait();
            }
        }
        static void Main(string[] args)
        {
            Fun1();
            Fun2();
            Console.ReadLine();
        }
    }
}
