using BookItHotellSystem.WPF.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for GuestList.xaml
    /// </summary>
    public partial class GuestList : UserControl
    {
        public GuestList()
        {
            InitializeComponent();
            
        }

    //    public void FillList()
    //    {
    //        try
    //        {
    //            SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-23210CRV\\SQLEXPRESS;Initial Catalog=BookItDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    //            sqlCon.Open();
    //            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Guest", sqlCon);
    //            SqlDataAdapter adapter = new SqlDataAdapter();
    //            DataSet ds = new DataSet();
    //            adapter.Fill(ds, "Guest");
    //            SqlDataReader reader;
    //            GuestModel guestModel = new GuestModel();
    //            List<GuestModel> GuestList = new List<GuestModel>();


    //            foreach (DataRow dr in ds.Tables[0].Rows)
    //            {
    //                GuestList = new List<GuestModel>();
    //                GuestList.Add(Guest)
    //                lstBox.ItemsSource = GuestList;
    //            }
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }
    }
}
