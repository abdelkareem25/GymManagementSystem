namespace GYMManagementSystem.Entites
{
    public class Session : BaseEntity
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } 
        public int Capacity { get; set; }
        public string Description { get; set; } 
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; } = default!;
    }
}
