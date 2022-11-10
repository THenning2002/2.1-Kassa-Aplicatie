using Clean_UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_UI.MVVM.ViewModel
{
    internal class MainViewModel : ObservalbleObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand ProductenViewCommand { get; set; }

        public RelayCommand KlantenViewCommand { get; set; }

        public RelayCommand BestellingenViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        public ProductenViewModel ProductenVM { get; set; }

        public KlantenViewModel KlantenVM { get; set; }

        public BestellingenViewModel BestellingenVM { get; set; }


        private object _currentView;

        public object Currentview
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
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            ProductenVM = new ProductenViewModel();
            KlantenVM = new KlantenViewModel();
            BestellingenVM = new BestellingenViewModel();


            Currentview = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                Currentview = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                Currentview = DiscoveryVM;
            });

            ProductenViewCommand = new RelayCommand(o =>
            {
                Currentview = ProductenVM;
            });

            KlantenViewCommand = new RelayCommand(o =>
            {
                Currentview = KlantenVM;
            });

            BestellingenViewCommand = new RelayCommand(o =>
            {
                Currentview = BestellingenVM;
            });


        }
    }
}
