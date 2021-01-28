using AutoMapper;
using SaverAPI.Contracts.V1.Requests.Queries;
using SaverAPI.Domain;

namespace SaverAPI.MappingProfiles
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<GetAllPostsQuery, GetAllPostsFilter>();
        }
    }
}