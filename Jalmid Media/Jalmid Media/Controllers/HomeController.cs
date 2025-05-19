using Jalmid_Media.DAL;
using Jalmid_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Jalmid_Media.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.FirstOrDefault();
            homeVM.XidmetlerHomes = _context.XidmetlerHomes.ToList();
            homeVM.WhyUs = _context.WhyUs.ToList();
            homeVM.Testimonials = _context.Testimonials.ToList();
            homeVM.HomeBanner = _context.HomeBanners.FirstOrDefault();

            return View(homeVM);
        }
    }
}
