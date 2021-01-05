using SaverAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaverAPI.Services
{
    public class CosmosPostService : IPostService
    {
        public Task<bool> CreatePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(Guid postId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByIdAsync(Guid postId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Post>> GetPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePostAsync(Post postToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserOwnsPostAsync(Guid postId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
