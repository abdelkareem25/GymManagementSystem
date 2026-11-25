using GYMManagementSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GYMManagementSystem.Controllers
{
    public class PlanController : Controller
    {
        private GYM_DbContext _context = new GYM_DbContext();
        public async Task<IActionResult> Index()
        {
            var plans = await _context.plans.ToListAsync();
            return View(plans);
        }
    }
}
