using FaceKid.Data;
using FaceKid.Entities;
using FaceKid.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FaceKid.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Post>> GetHomeFeedAsync()
        {
            return await _context.Posts
                .Include(x => x.User)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }
    }
}
