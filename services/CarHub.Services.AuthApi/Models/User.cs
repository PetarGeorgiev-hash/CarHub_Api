using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;

namespace CarHub.Services.AuthApi.Models
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }

}

