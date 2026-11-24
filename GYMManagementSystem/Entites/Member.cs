namespace GYMManagementSystem.Entites
{
    public class Member: GymUser
    {
        public DateTime JoinDate { get; set; } = default!;
        public string? Photo { get; set; }
        public ICollection<MemberShip> MemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
