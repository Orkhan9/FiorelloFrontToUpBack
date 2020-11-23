using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string ImageName { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
    }
}
