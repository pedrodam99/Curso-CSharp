using System.IO;
using System.Collections.Generic;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"\temp\folder";

            try
            {
                // Listar todas as subpastas dentro do path
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                // Listar arquivos de uma a partir de uma pasta
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                // Criar uma pasta
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine("Message" + e);
            }

        }
    }
}