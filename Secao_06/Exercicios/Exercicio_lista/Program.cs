using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employer> employees_list = new List<Employer>();

            Console.Write("How many employees will be registered? ");
            int num_employees = int.Parse(Console.ReadLine());

            // DATA INPUT
            for (int i = 0; i < num_employees; i++)
            {
                System.Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1}");
                
                Console.Write("ID: ");
                int num_id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employer new_emp = new Employer(num_id, name, salary);
                employees_list.Add(new_emp);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id_desired = int.Parse(Console.ReadLine());
            Employer emp = employees_list.Find(x => x.Id == id_desired);
            
            //VALIDATION ID EXISTS.
            if (emp != null) {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);

            }
            else {
                System.Console.WriteLine("This id does not exist!");
            }

            //DATA OUTPUT
            System.Console.WriteLine();
            System.Console.WriteLine("Update list of employees");
            foreach (Employer employer in employees_list)
            {
                System.Console.WriteLine($"{employer.Id}, {employer.Name}, {employer.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
