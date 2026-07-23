using GymSystem.AppDbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Controllers
{
    public class PlansController : Controller
    {
        private readonly GymDbContext _dbContext;

        public PlansController()
        {
            _dbContext = new GymDbContext();
        }

        public async Task<IActionResult> Index()
        {
            var plans = await _dbContext.Plans.ToListAsync();
            return View(plans);
        }
        public  async Task< IActionResult> Details(int Id)
        {
            var plan = await _dbContext.Plans.FindAsync(Id);
            
            if (plan == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(plan);
        }
    }
}
