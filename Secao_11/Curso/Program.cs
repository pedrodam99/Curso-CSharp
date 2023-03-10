using Curso.Entities;

namespace Curso
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
           
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);

            Console.WriteLine("Reservation: " +  reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data update to reservation:");
            
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime newCheckIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime newCheckOut = DateTime.Parse(Console.ReadLine());
        }
    }
}
