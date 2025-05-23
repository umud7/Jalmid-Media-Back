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
        public DbSet<Bio> Bio { get; set; }
        public DbSet<AboutBanner> AboutBanners { get; set; }
        public DbSet<WeAreStory> WeAreStories { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<MainValue> MainValues { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<AboutEndBanner> AboutEndBanners { get; set; }
        public DbSet<ServiceBanner> ServiceBanners { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<EndOfServiceBanner> EndOfServiceBanners { get; set; }
        public DbSet<HeaderNews> HeaderNews { get; set; }
        public DbSet<LastNews> LastNews { get; set; }
        public DbSet<ContactBanner> ContactBanners { get; set; }
    }
}
