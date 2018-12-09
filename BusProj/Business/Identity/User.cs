using Microsoft.AspNetCore.Identity;

namespace BusCore.Business.Identity
{
    public class User : IdentityUser
    {
        public string Locale { get; set; } = "en-GB";

        public string OrgId { get; set; }
    }

    public class Organization
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}