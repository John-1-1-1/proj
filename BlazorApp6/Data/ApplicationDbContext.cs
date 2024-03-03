using BlazorApp6.Components.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp6.Data;

public class ApplicationDbContext
    : IdentityDbContext<ApplicationUser> {

    public DbSet<User> User { get; set; } = null!;
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    
}