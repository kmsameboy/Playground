using System.Threading.Tasks;
using Refit;
using SaverAPI.Contracts.V1.Requests;

namespace SaverAPI.Sdk.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cachedToken = string.Empty;
            
            var identityApi = RestService.For<IIdentityApi>("https://localhost:5001");
            var saverApi = RestService.For<ISaverApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(cachedToken)
            });

            var registerResponse = await identityApi.RegisterAsync(new UserRegistrationRequest
            {
                Email = "sdkaccount@gmail.com",
                Password = "Asd1234!"
            });
            
            var loginResponse = await identityApi.LoginAsync(new UserLoginRequest
            {
                Email = "sdkaccount@gmail.com",
                Password = "Asd1234!"
            });

            cachedToken = loginResponse.Content.Token;

            var allPosts = await saverApi.GetAllAsync();

            var createdPost = await saverApi.CreateAsync(new CreatePostRequest
            {
                Name = "This is created by the SDK",
                Tags = new []{"sdk"}
            });

            var retrievedPost = await saverApi.GetAsync(createdPost.Content.Data.Id);

            var updatedPost = await saverApi.UpdateAsync(createdPost.Content.Data.Id, new UpdatePostRequest
            {
                Name = "This is updated by the SDK"
            });

            var deletePost = await saverApi.DeleteAsync(createdPost.Content.Data.Id);
        }
    }
}