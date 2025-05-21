using Jalmid_Media.DAL;
using Jalmid_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Jalmid_Media.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServiceVM serviceVM = new ServiceVM();
            serviceVM.ServiceBanner = _context.ServiceBanners.FirstOrDefault();
            serviceVM.Services = _context.Services.ToList();
            serviceVM.EndOfServiceBanner = _context.EndOfServiceBanners.FirstOrDefault();
            return View(serviceVM);
        }
    }
}
