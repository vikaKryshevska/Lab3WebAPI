using Lab3WebAPI.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebAPI.Entities
{
 //   [Table(UserRoles.ADMIN)]
    public class Administrator
    {
        internal string Role { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }

        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
