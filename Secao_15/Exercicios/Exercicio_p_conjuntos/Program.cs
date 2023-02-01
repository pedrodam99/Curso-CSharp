namespace Exercicio_p_conjuntos
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students in the course A? ");
            int numberStundetsA = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberStundetsA; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseA.Add(id);
            }

            Console.Write("How many students in the course B? ");
            int numberStundetsB = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberStundetsB; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseB.Add(id);
            }

            Console.Write("How many students in the course C? ");
            int numberStundetsC = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberStundetsC; i++)
            {
                int id = int.Parse(Console.ReadLine());
                courseC.Add(id);
            }

            HashSet<int> total = new HashSet<int>(courseA);
            total.UnionWith(courseB); 
            total.UnionWith(courseC); 

            Console.WriteLine();
            Console.WriteLine($"Total students: {total.Count}");
        }
    }
}