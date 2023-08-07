using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //required for 'ToListAsync' method
using System.Data;

namespace UserManager.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class RoleManagerController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;


        public RoleManagerController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }


        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }


        [HttpPost]
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                string roleID = Guid.NewGuid().ToString();
                await _roleManager.CreateAsync(new IdentityRole { Id = roleID, Name = roleName, NormalizedName = roleName.ToUpper() });
            }
            return RedirectToAction("Index");
        }
    }
}
