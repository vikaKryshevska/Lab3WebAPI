using System.ComponentModel.DataAnnotations;

namespace Lab3WebAPI.Models
{
    public class AuthRequestModel
    {

        public string? Email { get; set; }

        public string? Password { get; set; }


    }
}
