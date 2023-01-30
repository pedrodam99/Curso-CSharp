using System.Collections.Generic;

namespace Exercicio.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractData { get; set; }
        public double Total { get; set; }
        
        public List<Installment> Installments {get; set;} = new List<Installment>();

        public Contract(int contractNumber, DateTime contractData, double total)
        {
            ContractNumber = contractNumber;
            ContractData = contractData;
            Total = total;
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }

        public void RemoveInstallMents(Installment installment)
        {
            Installments.Remove(installment);
        }

        public void GenerateInstallments()
        {

        }
    }
}