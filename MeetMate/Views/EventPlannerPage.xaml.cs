using MeetMate.ViewModels;
using Microsoft.Maui.Controls;

namespace MeetMate.Views
{
    public partial class EventPlannerPage : ContentPage
    {
        public EventPlannerPage()
        {
            InitializeComponent();
            BindingContext = new EventPlannerViewModel();
        }
    }
}