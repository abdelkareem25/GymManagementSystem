using GYMManagementSystem.Context;
using GYMManagementSystem.Entites;
using GYMManagementSystem.Repositores.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GYMManagementSystem.Repositores.Classes
{
    public class PlanRepo : IPlanRepo
    {
        private readonly GYM_DbContext _context;

        public PlanRepo(GYM_DbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Plan>> GetAllPlansAsync(CancellationToken CT = default)
        {
            return await _context.plans.AsNoTracking().ToListAsync(CT);

        }
    }
}
