using System.IO;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"\temp\file1.txt";
            string targetPath = @"\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                // Usando a classe File
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                } 
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}