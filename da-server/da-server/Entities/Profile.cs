using System.ComponentModel.DataAnnotations.Schema;

namespace da_server.Entities
{
    public class Profile
    {
        public Guid ProfileId { get; set; }

        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int AddressNumber { get; set; }
        public int LocalNumber { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string EditedAt { get; set; } = string.Empty;

        public User User { get; set; }
    }
}