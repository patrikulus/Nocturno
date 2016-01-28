using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Nocturno.Data.Models;
using Nocturno.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Nocturno.Web.Areas.Admin.Controllers
{
    // TODO Move business logic to UserService
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class Usercontroller : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public Usercontroller(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            var users = GetUserManager().Users.Include(x => x.Roles).ToList();
            return View(users);
        }

        public IActionResult Create()
        {
            var model = new UserViewModel();
            ViewBag.Roles = new SelectList(GetRoleManager().Roles);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
            if (ModelState.IsValid)
            {
                await GetUserManager().CreateAsync(user, "Pa$$w0rd");
                var createdUser = await GetUserManager().FindByEmailAsync(model.Email);
                await GetUserManager().AddToRoleAsync(createdUser, model.Role);
                return RedirectToAction("Index");
            }
            ViewBag.Roles = new SelectList(GetRoleManager().Roles);
            return View(model);
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ApplicationUser user = GetUserManager().Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            string roleId = null;
            var userRole = user.Roles.FirstOrDefault();
            if (userRole != null)
            {
                roleId = userRole.RoleId;
            }
            var model = new UserViewModel
            {
                UserName = user.UserName,
                Email = user.Email,
                Role = roleId != null ? GetRoleManager().Roles.FirstOrDefault(x => x.Id == roleId).Name : null,
                UserId = user.Id
            };
            ViewBag.Roles = new SelectList(GetRoleManager().Roles);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserViewModel model)
        {
            var user = await GetUserManager().FindByIdAsync(model.UserId);
            IdentityRole role = null;
            if (user.Roles.Any())
            {
                role = await GetRoleManager().FindByIdAsync(user.Roles.FirstOrDefault().RoleId);
            }

            if (ModelState.IsValid)
            {
                var modelRole = GetRoleManager().Roles.FirstOrDefault(x => x.Name == model.Role);
                if (user.Roles.All(x => x.RoleId != modelRole.Id))
                {
                    if (role != null)
                    {
                        await GetUserManager().RemoveFromRoleAsync(user, role.Name);
                    }
                    await GetUserManager().AddToRoleAsync(user, model.Role);
                }
                user.UserName = model.UserName;
                user.Email = model.Email;
                await GetUserManager().UpdateAsync(user);
                return RedirectToAction("Index");
            }
            ViewBag.Roles = new SelectList(GetRoleManager().Roles);
            return View(model);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ApplicationUser user = await GetUserManager().FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: Page/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            ApplicationUser user = await GetUserManager().FindByIdAsync(id);
            await GetUserManager().DeleteAsync(user);
            return RedirectToAction("Index");
        }

        private RoleManager<IdentityRole> GetRoleManager()
        {
            var roleManager = _serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            return roleManager;
        }

        private UserManager<ApplicationUser> GetUserManager()
        {
            var userManager = _serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            return userManager;
        }
    }
}