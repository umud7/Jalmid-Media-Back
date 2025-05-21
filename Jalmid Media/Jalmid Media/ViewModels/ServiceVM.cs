using Jalmid_Media.Models;
using System.Collections.Generic;

namespace Jalmid_Media.ViewModels
{
    public class ServiceVM
    {
        public ServiceBanner ServiceBanner { get; set; }
        public List<Service> Services { get; set; }
        public EndOfServiceBanner EndOfServiceBanner { get; set; }
    }
}
