﻿using Jalmid_Media.Models;
using System.Collections.Generic;

namespace Jalmid_Media.ViewModels
{
    public class AboutVM
    {
        public AboutBanner AboutBanner { get; set; }
        public WeAreStory WeAreStory { get; set; }
        public Mission Mission { get; set; }
        public List<MainValue> MainValues { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Achievements> Achievements { get; set; }
        public AboutEndBanner AboutEndBanner { get; set; }
    }
}
