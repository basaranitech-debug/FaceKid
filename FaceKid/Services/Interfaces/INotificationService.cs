using FaceKid.Entities;

namespace FaceKid.Services.Interfaces
{
    public interface INotificationService
    {
        Task<List<Notification>> GetByUserIdAsync(string userId);
    }
}
