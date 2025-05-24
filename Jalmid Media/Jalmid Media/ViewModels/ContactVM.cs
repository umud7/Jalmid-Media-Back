using Jalmid_Media.Models;
using System.Collections.Generic;

namespace Jalmid_Media.ViewModels
{
    public class ContactVM
    {
        public ContactBanner ContactBanner { get; set; }
        public ContactInfo ContactInfos { get; set; }
        public ContactMap ContactMap { get; set; }
        public List<ContactFaq> ContactFaqs { get; set; }
    }
}
