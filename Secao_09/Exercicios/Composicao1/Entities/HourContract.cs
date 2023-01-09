namespace Composicao1.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        //construtor padrão
        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public double TotalValue(){
            return Hour * ValuePerHour;
        }
    }
}