using Microsoft.AspNetCore.Identity;

namespace Tecno;

public class ApplicationUser:IdentityUser
{
    public ICollection<Order>? orders{ get; set; }

}
