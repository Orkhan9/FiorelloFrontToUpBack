using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class Say
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string ImageName { get; set; }
        [Required,StringLength(200)]
        public string Text { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Profession { get; set; }
    }
}
