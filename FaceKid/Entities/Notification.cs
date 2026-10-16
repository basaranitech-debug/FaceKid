namespace FaceKid.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null;

    }
}
