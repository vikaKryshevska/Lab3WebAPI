using Lab3WebAPI.Entities;

namespace Lab3WebAPI.Models
{
    public class SubscriberModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<int> Services { get; set; }
    }
}
