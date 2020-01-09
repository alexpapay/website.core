using Microsoft.EntityFrameworkCore;
using website.core.Models.Portfolio;
using website.core.Models.Products;
using website.core.Models.Testimonials;

namespace website.data
{
    public class WebsiteContext : DbContext
    {
        public WebsiteContext() { }

        public WebsiteContext(DbContextOptions<WebsiteContext> options) : base(options) { }

        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
    }
}
