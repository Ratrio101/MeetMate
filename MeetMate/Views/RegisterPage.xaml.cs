using MeetMate.ViewModels;
using Microsoft.Maui.Controls;

namespace MeetMate.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }
    }
}