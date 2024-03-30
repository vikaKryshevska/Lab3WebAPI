using Lab3WebAPI.Entities;

namespace Lab3WebAPI.Models
{
    public class BillModel
    {

        public string Id { get; set; }
        public double Prise { get; set; }
        public bool Status { get; set; }
        public int SubscriberId { get; set; }
    }
}
