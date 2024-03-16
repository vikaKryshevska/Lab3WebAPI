namespace Lab3WebAPI.Entities
{
    public class Administrator
    {
        internal string Role { get; set; }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
