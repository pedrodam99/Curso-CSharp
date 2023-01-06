using Secao_09.Entities;
using Secao_09.Entities.Enums;

namespace Secao_09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1090,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            //transformando propriedade do enum em string e colocando dentro de variavel.
            string txt = OrderStatus.PendingPayment.ToString();
            //transformando string e passando para propriedade do enum.
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //texto tem que estar identico a propriedade.

            System.Console.WriteLine(txt);
            System.Console.WriteLine(os);
        }
    }
}