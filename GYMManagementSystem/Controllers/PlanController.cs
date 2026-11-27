using GYMManagementSystem.Repositores.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GYMManagementSystem.Controllers
{
    public class PlanController : Controller
    {
        
        private IPlanRepo _planRepo;
        public PlanController(IPlanRepo planRepo)
        {
            _planRepo = planRepo;
        }
        public async Task<IActionResult> Index()
        {
            var plans = await _planRepo.GetAllPlansAsync();
            return View(plans);
        }
    }
}
