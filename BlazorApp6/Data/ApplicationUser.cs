using Microsoft.AspNetCore.Identity;


// Add profile data for application users by adding properties to the ApplicationUser class
namespace BlazorApp6.Data;

public class ApplicationUser : IdentityUser {
    public int Year { get; set; }
}