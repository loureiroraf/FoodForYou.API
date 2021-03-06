using Microsoft.AspNetCore.Identity;

namespace FoodForYou.Api.Model
{
    public class UserModel : IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }
    }
}