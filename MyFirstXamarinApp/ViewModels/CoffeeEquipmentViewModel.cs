using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstXamarinApp.ViewModels
{
    public class CoffeeEquipmentViewModel : BindableObject
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }  
        
        public ICommand IncreaseCount { get; }
        
        private int _count = 0;
        private string _countDisplay = "It's lit";

        public string CountDisplay
        {
            get => _countDisplay;
            set
            {
                if (value == _countDisplay)
                    return;

                _countDisplay = value;
                OnPropertyChanged();
            }
        }

        private void OnIncrease()
        {
            _count++;
            CountDisplay = _count == 1 ? "You clicked 1 time" : $"You clicked {_count} times";
        }
    }
}