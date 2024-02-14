using System;
using System.Collections.Generic;
using System.Threading.Channels;
using CourseEx.Entities;
using System.Globalization;
namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee number: {i}, data: ");
                Console.Write("Outsourced (y/n)?");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}