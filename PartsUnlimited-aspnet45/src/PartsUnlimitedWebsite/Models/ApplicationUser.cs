using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    //hols x2
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}