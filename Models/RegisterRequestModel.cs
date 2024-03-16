using Lab3WebAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lab3WebAPI.Models
{
    public class RegisterRequestModel
    {

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmedPassword { get; set; }
    }
}