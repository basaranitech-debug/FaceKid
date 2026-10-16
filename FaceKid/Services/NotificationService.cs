using FaceKid.Data;
using FaceKid.Entities;
using FaceKid.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FaceKid.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ApplicationDbContext _context;

        public NotificationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetByUserIdAsync(string userId)
        {
            return await _context.Notifications
                    .AsNoTracking()
                    .Where(x => x.UserId == userId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Take(10)
                    .ToListAsync();
        }
    }
}
