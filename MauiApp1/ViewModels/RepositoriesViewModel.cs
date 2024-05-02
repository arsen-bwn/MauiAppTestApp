
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using MauiApp1.Services;
using MauiApp1.ViewModels;

public class RepositoriesViewModel : BaseViewModel
{
    private readonly IApiService _apiService;
    public ObservableCollection<RepositoryModel> Repositories { get; } = new ObservableCollection<RepositoryModel>();

    public RepositoriesViewModel(IApiService apiService)
    {
        _apiService = apiService;
        LoadRepositoriesCommand = new RelayCommand(async () => await LoadRepositoriesAsync());
        Title = "Repositories";
    }

    public ICommand LoadRepositoriesCommand { get; }

    private async Task LoadRepositoriesAsync()
    {
        var repos = await _apiService.GetRepositoriesAsync();
        Repositories.Clear();
        foreach (var repo in repos)
        {
            Repositories.Add(repo);
        }
    }
}