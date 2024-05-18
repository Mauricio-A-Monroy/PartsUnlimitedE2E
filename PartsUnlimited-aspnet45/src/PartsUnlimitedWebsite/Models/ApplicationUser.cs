using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    //comentario 2
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}