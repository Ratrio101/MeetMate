using MeetMate.ViewModels;
using Microsoft.Maui.Controls;

namespace MeetMate.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }

}