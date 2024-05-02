using MauiApp1.Models;

namespace MauiApp1.Services;

public interface IApiService
{
    Task<UserModel> AuthenticateAsync();
    Task<IList<RepositoryModel>> GetRepositoriesAsync();
    Task<RepositoryModel> GetRepositoryDetailsAsync( string repoName);
}