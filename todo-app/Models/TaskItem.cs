namespace Models
{
    public class TaskItem
    {
        public int Id { get; set; } // Primary Key
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
