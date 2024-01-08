using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Reflections
{

    internal class Class4
    {
        static void Fun1(int nuValuetype) { nuValuetype = nuValuetype + 10; }//one direction
        static void Fun2(ref int nuRefType) { nuRefType = nuRefType + 10; }//bi directional
        static void Fun3(out int nuOuttype)
        {//bi-directional
            nuOuttype = 0;//assign value
            nuOuttype = nuOuttype + 10;
        }
        public static void AcceptRegi(string fName, string lName, string mName, string address, string city, string gender, string qualification) { }
        public static void Regi(string name, string city = "hyd", double marks = 50)
        {// default parameters are city and marks
            Console.WriteLine($"name is {0} and from city {1} got mrks {2}  ", name, city, marks);
        }
        static void Main(string[] args)
        {
            AcceptRegi(fName: "", lName: "", mName: "", "", "", "", qualification: "");//named parameters
            Regi(name: "Arun");
            Regi(name: "Lokesh", city: "Vellore");
            Regi(name: "Pughazh", city: "Bangalore", marks: 100);// named parameters for more readable
            int n1 = 20;
            int n2 = 20;
            int n3 = 20;
            Fun1(n1); Console.WriteLine("value type function called  " + n1);
            Fun2(ref n2); Console.WriteLine("refrence type function called " + n2);
            Fun3(out n3); Console.WriteLine("out parameter function called  " + n3);


        }
    }
}
