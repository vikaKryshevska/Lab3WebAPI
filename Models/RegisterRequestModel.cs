using Lab3WebAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lab3WebAPI.Models
{
    public class RegisterRequestModel
    {


        [Required]
        public string Name { get; set; }
        [Required] 
        public string role { get; set; }

        [Required]
        public string Password { get; set; }
    }
}