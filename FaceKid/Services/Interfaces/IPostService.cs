using FaceKid.Entities;

namespace FaceKid.Services.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> GetHomeFeedAsync();
    }
}
