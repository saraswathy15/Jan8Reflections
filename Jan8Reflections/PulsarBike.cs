using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Reflections
{
    public interface IBike { bool IsRunning(); }
    public class Bike : IBike// implements
    {
        public string color;
        private int speed; public int JetSpeed { get { return speed; } }
        public void Acceclate(int milage) { speed += milage; }
        public bool IsRunning()
        {
            if (JetSpeed == 0) return false; return true;
        }
        public Bike() { color = "Red"; speed = 0; }
        public Bike(string c, int capacity) { color = c; speed = capacity; }
        public double CalCulateMilage(int startMiles, int endMiles, double oil)
        {
            return (endMiles - startMiles) / oil;
        }
    }// end of bike class
    public class SportBike : Bike // inheritence 
    {
        public SportBike() { color = "Green"; }
    }
    class test
    {
        static void Main(string[] args)
        {
            IBike b = new Bike();
            Type t1 = b.GetType();
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Assembly);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t1.Name);

        }
        public static void GetTypeInfo(Type t)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(t.Name);
            sb.AppendLine(t.FullName);
            sb.AppendLine(t.Namespace);
            sb.AppendLine(t.BaseType.ToString());
            Type tb = t.BaseType;
            if (tb != null) sb.AppendLine(tb.Name);
            Type tls = t.UnderlyingSystemType;
            if (tls != null) sb.AppendLine(" is it an abstrct class" + tls.IsAbstract);
            sb.AppendLine("is it a class " + tls.IsAnsiClass);
            sb.AppendLine("  is it an array  " + tls.IsArray);
            sb.AppendLine("\n For More Info");
            MemberInfo[] mi = t.GetMembers();
            foreach (var v1 in mi)
            {
                sb.AppendLine("declare type  " + v1.DeclaringType.ToString());
                sb.AppendLine(" module name  " + v1.Module.ToString());
            }

        }
    }
}
