using Lab3WebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebAPI.Entities
{
    /*    [Table("AspNetUsers")]*/
   // [Table(UserRoles.SUBSCRIBER)]
    public class Subscriber
    {
        internal string Role { get; set; }
        public int id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Account IdentityRole { get; set; }

        public ICollection<Service> Services { get; set; }

        //public ICollection<SubscriberServices> Services { get; set; }
    }
}
