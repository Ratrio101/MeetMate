using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.ComponentModel;
using MeetMate.Views;

namespace MeetMate.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }
        public ICommand NavigateToRegisterCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            LoginCommand = new Command(Login);
            NavigateToRegisterCommand = new Command(NavigateToRegister);
        }

        private async void Login()
        {
            // Simulate authentication logic
            await Application.Current.MainPage.DisplayAlert("Login", "Login successful!", "OK");
            // Navigate to event planner page
            await Application.Current.MainPage.Navigation.PushAsync(new EventPlannerPage());
        }

        private async void NavigateToRegister()
        {
            // Navigation logic to RegisterPage
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}