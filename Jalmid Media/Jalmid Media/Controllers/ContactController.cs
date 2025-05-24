using Jalmid_Media.DAL;
using Jalmid_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Jalmid_Media.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()

        {
            ContactVM contactVM = new ContactVM();
            contactVM.ContactBanner = _context.ContactBanners.FirstOrDefault();
            contactVM.ContactInfos = _context.ContactInfos.FirstOrDefault();
            contactVM.ContactMap = _context.ContactMaps.FirstOrDefault();
            contactVM.ContactFaqs = _context.ContactFaqs.ToList();

            return View(contactVM);
        }
    }
}
