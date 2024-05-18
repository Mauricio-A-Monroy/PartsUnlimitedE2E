using Microsoft.AspNet.Identity.EntityFramework;

namespace PartsUnlimited.Models
{
    //comentario
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}