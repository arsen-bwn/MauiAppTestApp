using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    

    public class BaseViewModel : ObservableObject
    {

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ICommand GoBackCommand { get; }

        public BaseViewModel()
        {
            GoBackCommand = new RelayCommand(GoBack);
        }

        protected virtual void GoBack()
        {
            if (Application.Current.MainPage is NavigationPage navPage)
            {
                navPage.Navigation.PopAsync();
            }
        }
    }
}
