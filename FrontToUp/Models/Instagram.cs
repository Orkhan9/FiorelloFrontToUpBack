using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class Instagram
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string ImageName { get; set; }
    }
}
