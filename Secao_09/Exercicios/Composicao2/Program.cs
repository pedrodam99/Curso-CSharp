using Composicao2.Entities;

namespace Composicao2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a Nice Trip");
            Comment c2 = new Comment("WOW, thats awesome");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "Im going to visit to wonderful contry",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
        }
    }
}

