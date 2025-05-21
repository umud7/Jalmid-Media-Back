using Jalmid_Media.DAL;
using Jalmid_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Jalmid_Media.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM();
            aboutVM.AboutBanner = _context.AboutBanners.FirstOrDefault();
            aboutVM.WeAreStory = _context.WeAreStories.FirstOrDefault();
            aboutVM.Mission = _context.Missions.FirstOrDefault();
            aboutVM.MainValues = _context.MainValues.ToList();
            aboutVM.Staffs = _context.Staff.ToList();
            aboutVM.Achievements = _context.Achievements.ToList();
            aboutVM.AboutEndBanner = _context.AboutEndBanners.FirstOrDefault();
            return View(aboutVM);
        }
    }
}
