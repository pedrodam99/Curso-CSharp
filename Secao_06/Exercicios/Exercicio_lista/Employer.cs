namespace Exercicio_lista
{
    class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employer(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void increaseSalary(double percentage) {
            Salary = Salary + (Salary * percentage / 100);
        }

        // public override string ToString()
        // {
        //     return base.ToString("foda-se");
        // }
    }
}