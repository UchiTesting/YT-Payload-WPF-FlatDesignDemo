using FlatDesign.Core;
using FlatDesign.MVVM.View;

namespace FlatDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;

        #region Commands
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutUsViewCommand { get; set; }
        public RelayCommand CloseApplicationViewCommand { get; set; }
        #endregion

        #region Related VMs
        public AboutUsView AboutVm { get; set; }
        public HomeViewModel HomeVm { get; set; }
        #endregion

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            AboutVm = new AboutUsView();
            HomeVm = new HomeViewModel();
            CurrentView = new HomeViewModel();

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            AboutUsViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVm;
            });

            CloseApplicationViewCommand = new RelayCommand((o) => { App.Current.Shutdown(); });
        }
    }
}
