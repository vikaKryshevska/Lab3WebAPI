using Lab3WebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebAPI.Entities
{
    /*    [Table("AspNetUsers")]*/
   // [Table(UserRoles.SUBSCRIBER)]
    public class Subscriber
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public ICollection<Service> Services { get; set; }
        public ICollection<Bill> Bills { get; set; }

        //public ICollection<SubscriberServices> Services { get; set; }
    }
}
