﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bosh saxlamaq olmaz!"),StringLength(50,ErrorMessage ="50 simvoldan artiq yazmayin")]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
