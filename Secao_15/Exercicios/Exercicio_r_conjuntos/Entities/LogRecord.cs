namespace Exercicio_r_conjuntos.Entities
{
    class LogRecords
    {
        public string? Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecords(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecords))
            {
                return false;
            }
            LogRecords other = obj as LogRecords;
            return Username.Equals(other.Username);
        }
    }
}