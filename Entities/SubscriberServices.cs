using Microsoft.AspNet.Identity;

namespace Lab3WebAPI.Entities
{
    public class SubscriberServices
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public Subscriber Subscriber { get; set; }

        public string ServicesName { get; set; }
        public Service Service { get; set; }
    }
}
