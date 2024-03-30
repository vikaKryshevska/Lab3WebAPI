using Lab3WebAPI.Entities;

namespace Lab3WebAPI.Models
{
    public class SubscriberModel
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public ICollection<string> Services { get; set; }
    }
}
