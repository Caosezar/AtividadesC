using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEx.Entities
{
    public class Employee
    {
        public string? Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; private set; }

        public Employee() { }


        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
    }



}
