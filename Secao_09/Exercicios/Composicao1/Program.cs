using System;
using System.Globalization;

using Composicao1.Entities;
using Composicao1.Entities.Enums;

namespace Composicao1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/Midlevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(workerName, workerLevel, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int contractNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractNumber; i++)
            {
                // Dados do contrato
                Console.WriteLine($"Enter #{i + 1} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine());

                //Instanciando o contrato
                HourContract contract = new HourContract(contractDate, valuePerHour, duration);
                // adicionando o contrato na lista de contratos do trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enther month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            
            //Saida de dados
            Console.WriteLine($"Worker: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: R$ {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");  
        }
    }
}