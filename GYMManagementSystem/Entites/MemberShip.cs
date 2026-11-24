namespace GYMManagementSystem.Entites
{
    public class MemberShip : BaseEntity
    {
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }
        public Plan Plan { get; set; } = default!;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public string Status => StartDate > DateTime.Now ? "Pending" : EndDate > DateTime.Now ?  "Active": "Expired";

    }
}
