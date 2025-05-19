using Jalmid_Media.Models;
using Microsoft.EntityFrameworkCore;

namespace Jalmid_Media.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<XidmetlerHome>XidmetlerHomes { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<HomeBanner> HomeBanners { get; set; }
    }
}
