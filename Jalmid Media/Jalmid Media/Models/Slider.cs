using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Jalmid_Media.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
