using Secao_09.Entities.Enums;

namespace Secao_09.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
       public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}