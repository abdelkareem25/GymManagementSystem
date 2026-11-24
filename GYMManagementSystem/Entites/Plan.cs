using System.Numerics;

namespace GYMManagementSystem.Entites
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; }= default!;
        public int DurationDays { get; set; } = default!;
        public decimal Price { get; set; } = default!;
        public bool IsActive { get; set; } = default!;
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}

