using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productclass
{
    public class Employee
    {
        private int id;
        private string name;
        private double BS, NPS, HRA, DA, PF, total;
        public Employee()
        {
            id = 55;
            name = "Arjun";
            BS = 20000;

        }

        public Employee(int id, string name, double BS)
        {

            this.id = id;
            this.name = name;
            this.BS = BS;
        }
        public void Calculate()
        {
            HRA = BS * 40 / 100;
            DA = BS * 20 / 100;
            PF = BS * 12 / 100;
            total = BS + HRA + DA;
            NPS = total - PF;
        }
        public string Print()
        {
            return $"ID {id} NAME {name} Basic Salary {BS} Total salary {total} Net paid salary {NPS}";
        }
    }
}