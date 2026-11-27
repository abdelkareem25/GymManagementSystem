using GYMManagementSystem.Entites;

namespace GYMManagementSystem.Repositores.Interfaces
{
    public interface IPlanRepo
    {
        Task<IEnumerable<Plan>> GetAllPlansAsync(CancellationToken CT = default); // CancellationToken CT = default : if the request is canceled, the operation will be canceled as well
    }
}
