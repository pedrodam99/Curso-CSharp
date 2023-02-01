using System;
using System.IO;

using Exercicio_r_conjuntos.Entities;

namespace Exercicio_r_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> setRecords = new HashSet<LogRecords>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine(); // \temp\int.txt

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        setRecords.Add(new LogRecords(name, instant));
                    }
                    Console.WriteLine($"Total users: {setRecords.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}