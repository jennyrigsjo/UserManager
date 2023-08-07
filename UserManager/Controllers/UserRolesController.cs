using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //required for 'ToListAsync' method
using System.Data;
using UserManager.Models;
using UserManager.Models.ViewModels;

namespace UserManager.Controllers
{
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class UserRolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public UserRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();

            var listOfUsers = new List<User>();

            foreach (ApplicationUser user in users)
            {
                var item = new User
                {
                    UserId = user.Id,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Roles = await GetUserRoles(user)
                };

                listOfUsers.Add(item);
            }

            return View(listOfUsers);
        }


        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }


        [HttpGet]
        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.UserId = userId;

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            ViewBag.UserName = user.UserName;

            var listOfRoles = new List<UserRole>();

            foreach (var role in _roleManager.Roles)
            {
                var item = new UserRole
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    item.Selected = true;
                }
                else
                {
                    item.Selected = false;
                }

                listOfRoles.Add(item);
            }

            return View(listOfRoles);
        }


        [HttpPost]
        public async Task<IActionResult> Manage(List<UserRole> selectedRoles, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return View();
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, currentRoles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(selectedRoles);
            }

            result = await _userManager.AddToRolesAsync(user, selectedRoles.Where(x => x.Selected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(selectedRoles);
            }

            return RedirectToAction("Index");
        }
    }
}
