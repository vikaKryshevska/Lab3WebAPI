using System.ComponentModel.DataAnnotations;
namespace Lab3WebAPI.Models
{
    public class UpdatePermission
    {
        [Required(ErrorMessage = "UserName is required")]
        public string Name { get; set; }

    }
}
