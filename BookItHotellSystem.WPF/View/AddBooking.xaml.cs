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
using System.Windows.Shapes;

namespace BookItHotellSystem.WPF.View
{
    /// <summary>
    /// Interaction logic for AddBooking.xaml
    /// </summary>
    public partial class AddBooking : Window
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        
       
        private void Register_Booking(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-23210CRV\\SQLEXPRESS;Initial Catalog=BookItDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO Booking values (@BookingId,@Guest,@Room,@CheckInDate,@CheckOutDate,@Days,@CostPerDay,@TotalCost)", sqlCon);
            sqlCmd.Parameters.AddWithValue("@BookingId", Guid.NewGuid());
            sqlCmd.Parameters.AddWithValue("@Guest", chosenGuest.Text);
            sqlCmd.Parameters.AddWithValue("@Room", chosenRoom.Text);
            sqlCmd.Parameters.AddWithValue("@CheckInDate", checkInDate.DisplayDate);
            sqlCmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate.DisplayDate);
            sqlCmd.Parameters.AddWithValue("@Days", int.Parse(days.Text));
            sqlCmd.Parameters.AddWithValue("@CostPerDay", int.Parse(costPerDay.Text));
            sqlCmd.Parameters.AddWithValue("@TotalCost", int.Parse(costPerDay.Text));
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            this.Close();
        }
    }
}
