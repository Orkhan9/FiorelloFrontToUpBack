using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToUp.DAL;
using FrontToUp.Models;
using FrontToUp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FrontToUp.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    //[Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _db;
        public UsersController(UserManager<AppUser> userManager, AppDbContext db,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    Id=user.Id,
                    Fullname = user.FullName,
                    Email = user.Email,
                    Username = user.UserName,
                    Status = user.Status,
                    Role =(await _userManager.GetRolesAsync(user))[0]
                };
                usersVM.Add(userVM);
            }
            return View(usersVM);
        }

        public async Task<IActionResult> ChangeStatus(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeStatus(string id,bool Status)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            user.Status = Status;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Email = user.Email,
                Fullname = user.FullName,
                Username = user.UserName,
                Status = user.Status,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles=new List<string> { "Member","Admin"}
            };

            //List<IdentityRole> AllRoles = _roleManager.Roles.ToList();
            //foreach (IdentityRole item in AllRoles)
            //{
            //    return Json(item.Name);
            //}
            //return Json(AllRoles);
            return View(userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id,string Role)
        {
            if (Role == null) return NotFound();
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            await _userManager.RemoveFromRoleAsync(user, oldRole);
            await _userManager.AddToRoleAsync(user, Role);

            return RedirectToAction(nameof(Index));
        }
    }
}
