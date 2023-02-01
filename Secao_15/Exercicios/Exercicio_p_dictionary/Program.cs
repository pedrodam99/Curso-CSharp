namespace Exercicio_p_dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            Console.Write("Enter file full path: "); // \temp\in.txt
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (dict.ContainsKey(name))
                        {
                            dict[name] += votes;
                        }
                        else
                        {
                            dict[name] = votes;
                        }
                    }

                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}