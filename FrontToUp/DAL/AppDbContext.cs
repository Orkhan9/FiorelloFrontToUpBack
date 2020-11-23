using FrontToUp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToUp.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderText> SliderTexts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Valentine> Valentines { get; set; }
        public DbSet<ExpertText> ExpertTexts { get; set; }
        public DbSet<ExpertImage> ExpertImages { get; set; }
        public DbSet<BlogText> BlogTexts { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Say> Says { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }

    }
}
