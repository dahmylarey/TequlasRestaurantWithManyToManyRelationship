using Microsoft.AspNetCore.Identity;

namespace TequlasRestaurant.Models.DomainModels
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
    }
}
