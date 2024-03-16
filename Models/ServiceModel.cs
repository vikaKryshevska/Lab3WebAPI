using Lab3WebAPI.Entities;

namespace Lab3WebAPI.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Status { get; set; }
        public double Prise { get; set; }
        public ICollection<int> Subscribers { get; set; }
    }
}
