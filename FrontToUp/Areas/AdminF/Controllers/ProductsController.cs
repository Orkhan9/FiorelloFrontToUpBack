using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FrontToUp.DAL;
using FrontToUp.Extentions;
using FrontToUp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FrontToUp.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles ="Admin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public ProductsController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Products.Include(p=>p.Category).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _db.Categories;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product,Category category)
        {
            if (ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Count"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Price"].ValidationState == ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState == ModelValidationState.Invalid
               ) return NotFound();

            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Duzgun format sechin");
                return View();
            }

            if (product.Photo.MaxLength(300))
            {
                ModelState.AddModelError("Photo", "300kb-dan az olchude shekil sechin");
                return View();
            }

            string fileName = await product.Photo.SaveImg(_env.WebRootPath, "img");

            Product newProduct = new Product
            {
                Title = product.Title,
                Count = product.Count,
                Price = product.Price,
                ImageName = fileName,
                CategoryId = category.Id
            };

            await _db.AddAsync(newProduct);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
