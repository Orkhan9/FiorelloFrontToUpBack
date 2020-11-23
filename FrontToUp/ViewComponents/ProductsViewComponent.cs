using FrontToUp.DAL;
using FrontToUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public ProductsViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count=12)
        {
            IEnumerable<Product> model = _db.Products.Include(p => p.Category).Take(count);
            return View(await Task.FromResult(model));
        }
    }
}
