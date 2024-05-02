using MauiApp1.Models;
using RestSharp;

namespace MauiApp1.Services;



public class ApiService : IApiService
{
    private readonly RestClient _client = new RestClient("https://api.github.com/");
    private readonly String _token = "github_pat__to_be";
    public async Task<UserModel> AuthenticateAsync()
    {
        var request = new RestRequest("user", Method.Get);
        request.AddHeader("Authorization", $"Bearer {_token}");
        var response = await _client.ExecuteAsync<UserModel>(request);
        return response.Data;
    }

    public async Task<IList<RepositoryModel>> GetRepositoriesAsync()
    {
        var request = new RestRequest("user/repos", Method.Get);
        request.AddHeader("Authorization", $"Bearer {_token}");
        var response = await _client.ExecuteAsync<IList<RepositoryModel>>(request);
        return response.Data;
    }

    public async Task<RepositoryModel> GetRepositoryDetailsAsync(string repoName)
    {
        var request = new RestRequest($"repos/{repoName}", Method.Get);
        request.AddHeader("Authorization", $"Bearer {_token}");
        var response = await _client.ExecuteAsync<RepositoryModel>(request);
        return response.Data;
    }
}

