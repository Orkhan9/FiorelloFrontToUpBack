using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public double Price { get; set; }
        [Required,StringLength(100)]
        public string ImageName { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

    }
}
