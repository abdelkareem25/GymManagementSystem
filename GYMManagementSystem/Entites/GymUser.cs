using GYMManagementSystem.Entites.Enums;

namespace GYMManagementSystem.Entites
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public Gender Gender { get; set; } = default!;
        public DateTime DateOfBirth { get; set; } = default!;
        public bool IsActive { get; set; } = default!;
        public Address Address { get; set; } = default!;
    }
}
