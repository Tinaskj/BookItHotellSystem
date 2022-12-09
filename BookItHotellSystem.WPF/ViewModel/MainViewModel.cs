using BookItHotellSystem.WPF.Core;
using BookItHotellSystem.WPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookItHotellSystem.WPF.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
       
        public RelayCommand BookingListViewCommand { get; set; }
        public RelayCommand GuestListViewCommand { get; set; }
        public RelayCommand RoomListViewCommand { get; set; }
        public BookingListViewModel BookingListVm { get; }
        public GuestListViewModel GuestListVm { get; }
        public RoomListViewModel RoomListVm { get; }

        private object _currentView;

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
            BookingListVm = new BookingListViewModel();
            GuestListVm = new GuestListViewModel();
            RoomListVm = new RoomListViewModel();    
            CurrentView = BookingListVm;


            BookingListViewCommand = new RelayCommand(o =>
            {
                CurrentView = BookingListVm;
            });


            GuestListViewCommand = new RelayCommand(o =>
            {
                CurrentView = GuestListVm;
            });



            RoomListViewCommand = new RelayCommand(o =>
            {
                CurrentView = RoomListVm;
            });

        }
    }
}
