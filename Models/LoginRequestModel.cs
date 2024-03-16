using System.ComponentModel.DataAnnotations;

namespace Lab3WebAPI.Models
{
    public class LoginRequestModel
    {

        public string? Name { get; set; }

        public string? Password { get; set; }
    }
}
