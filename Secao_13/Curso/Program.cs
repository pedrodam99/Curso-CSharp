using System.IO;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"\temp\file1.txt";
            try
            {
                StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}