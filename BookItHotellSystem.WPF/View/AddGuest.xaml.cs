using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
    /// Interaction logic for AddGuest.xaml
    /// </summary>
    public partial class AddGuest : Window
    {
        public AddGuest()
        {
            InitializeComponent();
        }

        private void Add_Guest(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-23210CRV\\SQLEXPRESS;Initial Catalog=BookItDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO Guest values (@GuestId,@Name,@Adress,@Email,@Phone,@Info)", sqlCon);
            sqlCmd.Parameters.AddWithValue("@GuestId", Guid.NewGuid());
            sqlCmd.Parameters.AddWithValue("@Name", nameInput.Text);
            sqlCmd.Parameters.AddWithValue("@Adress", Adress.Text);
            sqlCmd.Parameters.AddWithValue("@Email", Email.Text);
            sqlCmd.Parameters.AddWithValue("@Phone", int.Parse(Phone.Text));
            sqlCmd.Parameters.AddWithValue("@Info", GuestInfo.Text);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            this.Close();
        }
    }
}
