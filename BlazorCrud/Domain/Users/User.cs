using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCrud.Domain.Users
{
    [Table("User")]
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name for user is required")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string? MobilePhone { get; set; }

    }
}
