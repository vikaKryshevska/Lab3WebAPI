namespace Lab3WebAPI.Entities
{
    public class Subscriber
    {
        internal string Role { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public ICollection<Service> Services { get; set; }

        //public ICollection<SubscriberServices> Services { get; set; }
    }
}
