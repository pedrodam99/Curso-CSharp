using Exercicio_p.Entities;

using System.Globalization;

namespace Exercicio_p
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();


            Console.Write("Enter full file path: "); // \temp\in.txt
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double max = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] employee = sr.ReadLine().Split(',');
                        string name = employee[0];
                        string email = employee[1];
                        double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                var emails = employees.Where(e => e.Salary > max).OrderBy(e => e.Email).Select(e => e.Email);
                
                var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                
                
                // Exibindo email em ordem alfabetica quem tem salario maior que o digitado
                Console.WriteLine($"Email of people whose salary is more than {max.ToString("F2", CultureInfo.InvariantCulture)}");
                foreach (var emp in emails)
                {
                    System.Console.WriteLine(emp);
                }

                // Soma de salarios dos funcionarios que comecam com a letra "M"
                Console.WriteLine("Sum salary of peoples whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
