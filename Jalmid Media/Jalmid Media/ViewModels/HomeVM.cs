using Jalmid_Media.Models;
using System.Collections.Generic;

namespace Jalmid_Media.ViewModels
{
    public class HomeVM
    {
        public Slider Sliders { get; set; }
        public List<XidmetlerHome> XidmetlerHomes { get; set; }
        public List<WhyUs> WhyUs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public HomeBanner HomeBanner { get; set; }
    }
}
