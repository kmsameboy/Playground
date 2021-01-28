using Swashbuckle.AspNetCore.Filters;
using SaverAPI.Contracts.V1.Responses;

namespace SaverAPI.SwaggerExamples.Responses
{
    public class TagResponseExample : IExamplesProvider<TagResponse>
    {
        public TagResponse GetExamples()
        {
            return new TagResponse
            {
                Name = "new tag"
            };
        }
    }
}