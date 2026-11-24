using GYMManagementSystem.Entites.Enums;

namespace GYMManagementSystem.Entites
{
    public class Trainer : GymUser
    {
        public DateTime HireDate { get; set; } = default!;
        public Speciality Specialization { get; set; } 
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
    }
}
