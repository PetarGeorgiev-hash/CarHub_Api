using CarHub.Services.AuthApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarHub.Services.AuthApi.DataContext;
public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                base.OnModelCreating(modelBuilder);
        }
}
