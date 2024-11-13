using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace MeetMate.ViewModels
{
    public class EventPlannerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Events { get; set; } = new ObservableCollection<string>();
        public ICommand AddEventCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public EventPlannerViewModel()
        {
            AddEventCommand = new Command(AddEvent);
        }

        private void AddEvent()
        {
            Events.Add($"Event {Events.Count + 1}");
            OnPropertyChanged("Events");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}