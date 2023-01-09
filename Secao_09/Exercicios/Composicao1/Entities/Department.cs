namespace Composicao1.Entities
{
    class Department
    {
        public string? Name { get; set; }

        //construtor padrão da classe
        public Department() { }

        //construtor com um parametro (name)
        public Department(string name)
        {
            Name = name;
        }
    }
}