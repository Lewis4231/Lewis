using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data.SqlClient;

namespace ConfigSQL
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public MainWindow()
        {
            InitializeComponent();
            txtServerName.Text = string.Concat(Environment.MachineName, @"\교수용PC");  
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            con.Close();
            MessageBox.Show("Connected to the "+cmbDatabase.Text+"Successfully","Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
            new Window1().Show();
        }
        private void cmbDatabase_DropDownOpened(object sender, EventArgs e)
        {
            cmbDatabase.Items.Clear();
            try
            {
                if(cmbAuthenticationType.Text.Equals("Windows Authentication"))
                {
                    SQLConnection.ConnectionString = @"Server = " + txtServerName.Text + "; Integrated Security=SSPI;";
                    con.ConnectionString = SQLConnection.ConnectionString;
                }
                else if(cmbAuthenticationType.Text.Equals("SQL Server Authentication"))
                {
                    SQLConnection.ConnectionString = @"Server = " + txtServerName.Text + "; User Id ="+txtUsername.Text+"; Password="+txtPassword.Text+";";
                    con.ConnectionString = SQLConnection.ConnectionString;
                }
                con.Open();
                com.Connection = con;
                com.CommandText = "SELECT DB_Name(database_id) AS[Database], database_id FROM sys.databases; ";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmbDatabase.Items.Add(dr["Database"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OOPSSss!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmbAuthenticationType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbAuthenticationType.SelectedItem.ToString().Contains("Windows Authentication"))
            {
                txtUsername.IsEnabled = false;
                txtPassword.IsEnabled = false;
            }
            else if((cmbAuthenticationType.SelectedItem.ToString().Contains("SQL Server Authentication")))
            {
                txtUsername.IsEnabled=true;
                txtPassword.IsEnabled = true;
            }
        }
    }
}
