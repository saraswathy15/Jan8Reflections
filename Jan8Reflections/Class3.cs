using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Reflections
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string empName = "John";
            Type tEmpinfo = empName.GetType();
            //  Console.WriteLine(tEmpinfo);
            Type t1 = typeof(Class3);
            // Console.WriteLine(t1.Assembly);
            //lets see with IEnumerable
            Type t2 = typeof(Enumerable);
            //   Console.WriteLine(" Name is "+t2.Name);
            //  Console.WriteLine("name space "+t2.Namespace);
            //  Console.WriteLine(  " base class of "+t2.BaseType);
            Type t3 = typeof(int);
            Console.WriteLine("name " + t3.Name);
            Console.WriteLine(" full name " + t3.BaseType);

        }
    }//interface, class, child class lets fetch all info
}
