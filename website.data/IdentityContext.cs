using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using website.core.Models.Auth;

namespace website.data
{
    public class IdentityContext : IdentityDbContext<User>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Fix for MySQL database.
        /// </summary>
        /// <param name="builder">Model builder object.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .Property(r => r.EmailConfirmed)
                .HasConversion(new BoolToZeroOneConverter<Int16>());
            builder.Entity<User>()
                .Property(r => r.LockoutEnabled)
                .HasConversion(new BoolToZeroOneConverter<Int16>());
            builder.Entity<User>()
                .Property(r => r.PhoneNumberConfirmed)
                .HasConversion(new BoolToZeroOneConverter<Int16>());
            builder.Entity<User>()
                .Property(r => r.TwoFactorEnabled)
                .HasConversion(new BoolToZeroOneConverter<Int16>());

            // Add default roles:
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() },
                    new IdentityRole { Name = "User", NormalizedName = "User".ToUpper() }
                    );

            // Add default admin user:
            User user = new User
            {
                UserName = "admin",
                Email = "admin@email.com",
                NormalizedEmail = "admin@email.com".ToUpper(),
                NormalizedUserName = "admin".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "12345678");

            builder.Entity<User>().HasData(user);
        }
    }
}