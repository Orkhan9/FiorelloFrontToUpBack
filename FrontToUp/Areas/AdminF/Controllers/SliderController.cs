using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FrontToUp.DAL;
using FrontToUp.Extentions;
using FrontToUp.Helpers;
using FrontToUp.Migrations;
using FrontToUp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FrontToUp.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            
            return View(_db.SliderImages);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider =await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        public IActionResult Create()
        {
            if (_db.SliderImages.Count() >= 5)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }



        #region Multi file upload
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderImage slider)
        {
            if (ModelState["Photos"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            int canUploadCount = 5 - (_db.SliderImages.Count());
            if (canUploadCount < slider.Photos.Length)
            {
                ModelState.AddModelError("Photos", $"Maksimum yukleye bileceyiniz shekil sayi - {canUploadCount}");
                return View();
            }

            foreach (IFormFile photo in slider.Photos)
            {
                if (!photo.IsImage())
                {
                    ModelState.AddModelError("Photos", " Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photos", $"{photo.FileName} Sheklinin olcusu 200 kb-dan choxdur");
                    return View();
                }


                string fileName = await photo.SaveImg(_env.WebRootPath, "img");

                SliderImage newslider = new SliderImage();
                newslider.ImageName = fileName;
                await _db.SliderImages.AddAsync(newslider);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region One file upload
        //[HttpPost]
        //[ValidateAntiForgeryToken]        
        //public async Task<IActionResult> Create(SliderImage slider)
        //{
        //    if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
        //    {
        //        return View();
        //    }

        //    if (!slider.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
        //        return View();
        //    }

        //    if (slider.Photo.MaxLength(200))
        //    {
        //        ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
        //        return View();
        //    }

        //    if (_db.SliderImages.Count() >= 5)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }

        //    string fileName =await slider.Photo.SaveImg(_env.WebRootPath, "img");

        //    slider.ImageName = fileName;
        //    await _db.SliderImages.AddAsync(slider);
        //    await _db.SaveChangesAsync();

        //    return RedirectToAction(nameof(Index));
        //}
        #endregion

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", slider.ImageName);

            _db.SliderImages.Remove(slider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,SliderImage slider)
        {
            if (id == null) return NotFound();

            if (slider.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (slider.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                    return View();
                }

                SliderImage dbslider = await _db.SliderImages.FindAsync(id);
                if (dbslider == null) return NotFound();

                Helper.DeleteImage(_env.WebRootPath, "img", dbslider.ImageName);

                string fileName = await slider.Photo.SaveImg(_env.WebRootPath, "img");

                dbslider.ImageName = fileName;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
