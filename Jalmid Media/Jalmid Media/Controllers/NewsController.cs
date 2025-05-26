using Jalmid_Media.DAL;
using Jalmid_Media.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Jalmid_Media.Controllers
{
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            NewsVM newsVM = new NewsVM();
            newsVM.HeaderNews = _context.HeaderNews.FirstOrDefault();
            newsVM.LastNews = _context.LastNews.ToList();

            return View(newsVM);
        }


    }
}
