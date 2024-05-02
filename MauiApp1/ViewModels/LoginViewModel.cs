
using System.Windows.Input;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Services;
using MauiApp1.Views;

public class LoginViewModel : ObservableObject
{
    private readonly IApiService _apiService;
    private string _username;
    private string _password;

    public string Username
    {
        get => _username;
        set => SetProperty(ref _username, value);
    }
    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    public ICommand LoginCommand { get; }

    public LoginViewModel(IApiService apiService)
    {
        _apiService = apiService;
        LoginCommand = new RelayCommand(async () => await LoginAsync());
        Username = "arsen-bwn@yandex.ru";
    }

    private async Task LoginAsync()
    {
        if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
        {
            try
            {
                var user = await _apiService.AuthenticateAsync();
           
            }
            catch
            {
                
            }
        }
    }
}