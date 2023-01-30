namespace Exercicio.Services
{
    class PayPal: ITaxService
    {

        public int Mounth { get; set; }

        public PayPal(){}

        public double TaxService(double amount)
        {
            return 10.0;    
        }
    }
}