using Composicao3.Entities;
using Composicao3.Entities.Enums;

using System.Globalization;

namespace Composicao3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Dados do CLiente.
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birthday (DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            
            // Intanciando cliente com variaveis temporarias.
            Client client = new Client(name, email, birthday);

            // Entrando com dados do pedido (order)
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // Instaciando Order
            Order order = new Order(DateTime.Now, status, client);

            //
            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(quantity, prodPrice, product);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}

