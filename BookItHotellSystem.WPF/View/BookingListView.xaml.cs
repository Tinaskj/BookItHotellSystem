using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookItHotellSystem.WPF.View
{
    /// <summary>
    /// Interaction logic for BookingListView.xaml
    /// </summary>
    public partial class BookingListView : UserControl
    {
        public BookingListView()
        {
            InitializeComponent();
        }

        private void Add_Guest(object sender, RoutedEventArgs e)
        {
            AddGuest newGuest = new AddGuest();
            newGuest.Show();
        }

        private void Add_Booking(object sender, RoutedEventArgs e)
        {
            AddBooking newBooking = new AddBooking();
            newBooking.Show();
        }
    }
}
