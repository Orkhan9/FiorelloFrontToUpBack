using FrontToUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public  Category Category { get; set; }
    }
}
