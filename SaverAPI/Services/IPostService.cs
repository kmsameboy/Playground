using SaverAPI.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaverAPI.Services
{
    public interface IPostService
    {
        Task<IList<Post>> GetPostsAsync();
        
        Task<Post> GetPostByIdAsync(Guid postId);

        Task<bool> CreatePostAsync(Post post);

        Task<bool> UpdatePostAsync(Post postToUpdate);

        Task<bool> DeletePostAsync(Guid postId);
        Task<bool> UserOwnsPostAsync(Guid postId, string userId);
    }
}
