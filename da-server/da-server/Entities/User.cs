using System.ComponentModel.DataAnnotations;

namespace da_server.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Field 'Login' is required!")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "Login must be between 4 and 25 characters!")]
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Profile? Profile { get; set;} = null!;
    }
}