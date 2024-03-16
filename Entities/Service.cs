namespace Lab3WebAPI.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public double Prise { get; set; }
        public ICollection<Subscriber> Subscribers { get; set; }
        //public ICollection<SubscriberServices> Subscribers { get; set; }

    }
}
