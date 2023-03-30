using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationProject.Areas.Admin.Models;

namespace ReservationProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
        {
            AppRole role = new AppRole
            {
                Name = addRoleViewModel.RoleName
            };

            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(addRoleViewModel);
        }
        [HttpGet]
        public IActionResult EditRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            EditRoleViewModel editRoleViewModel = new EditRoleViewModel
            {
                RoleID = role.Id,
                RoleName = role.Name
            };

            return View(editRoleViewModel);

        }
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel editRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                var role = _roleManager.Roles.FirstOrDefault(x => x.Id == editRoleViewModel.RoleID);
                if (role != null)
                {
                    role.Name = editRoleViewModel.RoleName;
                    await _roleManager.UpdateAsync(role);
                    return RedirectToAction("Index");
                }
            }
            return View(editRoleViewModel);
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return RedirectToAction("Index");
        }
    }
}
