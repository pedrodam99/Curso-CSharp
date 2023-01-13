using System.Collections.Generic;
using System.Globalization;

using HerancaPolimorfismo2.Entities;

namespace HerancaPolimorfismo2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the numbers of employees: ");
            int numEmpl = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEmpl; i++)
            {
                Console.Write($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (isOutsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additional);
                    employees.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}