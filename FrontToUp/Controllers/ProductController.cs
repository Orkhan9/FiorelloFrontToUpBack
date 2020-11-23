using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToUp.DAL;
using FrontToUp.Models;
using FrontToUp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToUp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _db.Products.Count();
            return View();
        }

        public IActionResult Load(int skip)
        {
            if(skip>= _db.Products.Count())
            {
                return Content("");
            }
            IEnumerable<Product> model = _db.Products.Include(p => p.Category).Skip(skip).Take(8);
            return PartialView("_ProductPartial", model);

            #region Old version
            //return Json(_db.Products.Select(p => new ProductVM
            //{
            //    Id = p.Id,
            //    Title = p.Title,
            //    ImageName = p.ImageName,
            //    Price = p.Price,
            //    Category = p.Category
            //}).Skip(4).Take(4));
            #endregion
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Product> model = _db.Products.Where(p => p.Title.Contains(search)).OrderByDescending(p => p.Id).Take(10);
            return PartialView("_SearchProductPartial", model);
        }
    }
}
