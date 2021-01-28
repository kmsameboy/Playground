using Swashbuckle.AspNetCore.Filters;
using SaverAPI.Contracts.V1.Requests;

namespace SaverAPI.SwaggerExamples.Requests
{
    public class CreateTagRequestExample : IExamplesProvider<CreateTagRequest>
    {
        public CreateTagRequest GetExamples()
        {
            return new CreateTagRequest
            {
                TagName = "new tag"
            };
        }
    }
}