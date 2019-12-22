using System;
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
        }
    }
}