using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace MeetMate.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public ICommand RegisterCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterViewModel()
        {
            RegisterCommand = new Command(Register);
        }

        private async void Register()
        {
            // Simulate registration logic
            await Application.Current.MainPage.DisplayAlert("Registration", "Registration successful!", "OK");
            // Navigate back to login page
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
