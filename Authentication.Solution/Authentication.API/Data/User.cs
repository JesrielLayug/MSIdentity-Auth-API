using Microsoft.AspNetCore.Identity;

namespace Authentication.API.Data
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public byte[]? Image { get; set; }
    }
}
