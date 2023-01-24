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
              string[] lines = File.ReadAllLines(sourcePath);

              using (StreamWriter sw = File.AppendText(targetPath)) 
              {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
              }
              Console.WriteLine("Success file generation");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}