using FlatDesign.Core;
using FlatDesign.MVVM.View;

namespace FlatDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;

        public HomeViewModel HomeVm { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() {
            HomeVm = new HomeViewModel();
            CurrentView = new HomeViewModel();
        }
    }
}
