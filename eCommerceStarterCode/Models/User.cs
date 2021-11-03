using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
