using System;
using SaverAPI.Contracts.V1.Requests.Queries;

namespace SaverAPI.Services
{
    public interface IUriService
    {
        Uri GetPostUri(string postId);

        Uri GetAllPostsUri(PaginationQuery pagination = null);
    }
}