using Jalmid_Media.DAL;
using Jalmid_Media.Helpers.Extension;
using Jalmid_Media.Helpers.Extension.Innowave.Helpers.Extension;
using Jalmid_Media.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace Jalmid_Media.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext appDbContext, IWebHostEnvironment env)
        {
            _appDbContext = appDbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            var sliders = _appDbContext.Sliders.ToList();
            _appDbContext.SaveChanges();
            return View(sliders);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Create(Slider slider)
        {

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!slider.Photo.CheckImage())
            {
                ModelState.AddModelError("Photo", "shekil Sech");
            }
            if (slider.Photo.CheckImageSize(1000))
            {
                ModelState.AddModelError("Photo", "Olchu Boyuktu");
            }

            Slider newSlider = new Slider();
            newSlider.ImageUrl = slider.Photo.SaveImage(_env, "/root");
            newSlider.Photo = slider.Photo;
            newSlider.Header = slider.Header;
            newSlider.Desc = slider.Desc;
            _appDbContext.Sliders.Add(newSlider);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider sliders = _appDbContext.Sliders.Find(id);
            if (sliders == null) return NotFound();

            return View(sliders);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteSlider(int? id)
        {
            if (id == null) return NotFound();
            Slider sliders = _appDbContext.Sliders.Find(id);
            if (sliders == null) return NotFound();
            _appDbContext.Sliders.Remove(sliders);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Update(int? id)
        {

            if (id == null) return NotFound();
            Slider slider = _appDbContext.Sliders.Find(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(int? id, Slider slider)
        {
            if (id == null) return NotFound();
            Slider existSlider = _appDbContext.Sliders.Find(id);
            if (existSlider == null) return NotFound();

            string filename = string.Empty;

            if (slider.Photo != null)
            {
                string path = Path.Combine(_env.WebRootPath, "/root", existSlider.ImageUrl);
                if (System.IO.File.Exists(path))
                {

                    System.IO.File.Delete(path);
                }

                if (!slider.Photo.CheckImage())
                {
                    ModelState.AddModelError("Photo", "shekil Sech");
                }
                if (slider.Photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Olchu Boyuktu");
                }

                filename = slider.Photo.SaveImage(_env, "/root");


            }

            existSlider.ImageUrl = filename ?? existSlider.ImageUrl;

            Slider newSlider = new Slider();
            newSlider.ImageUrl = slider.Photo.SaveImage(_env, "/root");
            newSlider.Photo = slider.Photo;
            _appDbContext.Sliders.Add(newSlider);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}
