using FaceKid.Data;
using FaceKid.Entities;
using FaceKid.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        public async Task CreatePostAsync(string userId, string content)
        {
            var post = new Post
            {
                UserId = userId,
                Content = content,
                CreatedAt = DateTime.UtcNow
            };

            _context.Posts.Add(post);

            await _context.SaveChangesAsync();

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
