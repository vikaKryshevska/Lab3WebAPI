using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebAPI.Entities
{
    public class Bill
    {
        
        public int Id { get; set; }
        public double Prise { get; set; }
        public bool Status { get; set; }
        public int SubscriberId { get; set; }
        public Subscriber Subscriber { get; set; }
    }
}
