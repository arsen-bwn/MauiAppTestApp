using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using System.Windows.Input;

namespace MauiApp1.ViewModels;


public class RepositoryDetailViewModel : BaseViewModel
{
    private readonly IApiService _apiService;
    private RepositoryModel _repository;
  

    public RepositoryDetailViewModel(IApiService apiService, string repoName)
    {
        _apiService = apiService;
        LoadRepositoryDetail(repoName);
        Title = "Repo" + repoName;
        OpenInBrowserCommand = new RelayCommand(OpenInBrowser);



    }

    public RepositoryModel Repository
    {
        get => _repository;
        set => SetProperty(ref _repository, value);
    }

    private async void LoadRepositoryDetail(string repoName)
    {
        Repository = await _apiService.GetRepositoryDetailsAsync(repoName);
    }

    public ICommand OpenInBrowserCommand { get; }

    private async void OpenInBrowser()
    {
        
            await Browser.OpenAsync(_repository.Url, BrowserLaunchMode.SystemPreferred);
        
    }

}
