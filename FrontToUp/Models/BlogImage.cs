using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class BlogImage
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string ImageName { get; set; }
        [Required,StringLength(100)]
        public string Title { get; set; }
        [Required,StringLength(200)]
        public string Text { get; set; }
    }
}
