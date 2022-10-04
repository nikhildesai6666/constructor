using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    internal class EmployeeClass1
    {
        static void Main(string[] args)
        {
            Employee C1 = new Employee();
            C1.Calculate();
            Console.WriteLine(C1.Print());

            Employee C2 = new Employee(12, "Akash", 30000);
            C2.Calculate();
            Console.WriteLine(C2.Print());
        }
    }
}