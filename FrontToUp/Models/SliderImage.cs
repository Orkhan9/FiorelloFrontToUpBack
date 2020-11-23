﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class SliderImage
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string ImageName { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [NotMapped]
        [Required]
        public IFormFile[] Photos { get; set; }
    }
}
