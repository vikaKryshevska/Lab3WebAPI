namespace Lab3WebAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    public class UserChangeRoleInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
