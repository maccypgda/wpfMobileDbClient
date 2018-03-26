using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace inheritTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string firstString = "";
        List<string> dataFromPopup = new List<string>();
        List<Reader> dataFromDB = new List<Reader>();
        List<string> newList = new List<string>();
        string sqlQuery;

        public MainWindow()
        {
            InitializeComponent();
        }
        public void dbConnectionOpen()
        {
            SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-LNOR2D8\SQLEXPRESS; database=Mobile; User id=sa; Password=password;");
            connection.Open();
            SqlCommand SQLcommand = connection.CreateCommand();
        }
        public void saveDataToDataBase(string query)
        {
            string saveInDbQuery = query;
            SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-LNOR2D8\SQLEXPRESS; database=Mobile; User id=sa; Password=password;");
            connection.Open();
            SqlCommand SQLcommand = connection.CreateCommand();
            SQLcommand.CommandText = saveInDbQuery;
            SqlDataReader reader = SQLcommand.ExecuteReader();
            reader.Close();
        }
        private void newMobile_Click(object sender, RoutedEventArgs e)
        {
            popup1 newWindow = new popup1();
            newWindow.passDatafromPopu1toMain += new EventHandler<CustomEventArgs>(newWindow_RaiseCustomEvent);
            newWindow.Show();
        }
        //working
        void newWindow_RaiseCustomEvent(object sender, CustomEventArgs e)
        {
            //dataFromPopup = e.Message;
            //firstDataTextBox.Text = e.Message[0] + " " + e.Message[1] + " " + e.Message[2];
            //sqlQuery = "INSERT INTO mobMobile (mobId, mobProd, mobMod, mobImei, mobComments, mobOwner, mobInvoice) VALUES (" +
            
            sqlQuery = "INSERT INTO mobMobile (mobProd, mobMod, mobImei, mobComments, mobOwner, mobInvoice) VALUES ('" +
            e.Message[0] + "', '" + e.Message[1] + "', '" + e.Message[2] + "', '" + e.Message[3] + "', '" + e.Message[4] + "', '" + e.Message[5] + "')";
            firstDataTextBox.Text = sqlQuery;
            saveDataToDataBase(sqlQuery);
        }

        private void readDB_Click(object sender, RoutedEventArgs e)
        {
            sqlQuery = "SELECT * FROM mobMobile";
            //dbConnectionOpen();
            SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-LNOR2D8\SQLEXPRESS; database=Mobile; User id=sa; Password=password;");
            connection.Open();
            SqlCommand SQLcommand = connection.CreateCommand();
            SQLcommand.CommandText = sqlQuery;
            //SqlDataAdapter da = new SqlDataAdapter();
            SqlDataReader reader = SQLcommand.ExecuteReader();
            //DataTable dt = new DataTable("mobMobile");
            //da.Fill(dt);
            //dataGrid.ItemsSource = dt.DefaultView;
            //firstDataTextBox.Text = reader["mobProd"].ToString();
            while (reader.Read())
            {
                //firstDataTextBox.Text = reader["mobId"].ToString() + reader["mobProd"].ToString() +
                //    reader["mobMod"].ToString() +
                //    reader["mobImei"].ToString() +
                //    reader["mobComments"].ToString() +
                //    reader["mobOwner"].ToString() +
                //    reader["mobInvoice"].ToString();
                newList.Add(reader["mobId"].ToString());
                newList.Add(reader["mobProd"].ToString());
                newList.Add(reader["mobMod"].ToString());
                newList.Add(reader["mobImei"].ToString());
                newList.Add(reader["mobComments"].ToString());
                newList.Add(reader["mobOwner"].ToString());
                newList.Add(reader["mobInvoice"].ToString());
                //dataGrid.DataContext = dataFromDB;
                //firstDataTextBox.Text = dataGrid.DataContext.ToString();

                var readTable = new Reader();
                readTable.ID = reader["mobId"].ToString();
                readTable.Producer = reader["mobProd"].ToString();
                readTable.Model = reader["mobMod"].ToString();
                readTable.IMEI = reader["mobImei"].ToString();
                readTable.Comments = reader["mobComments"].ToString();
                readTable.Owner = reader["mobOwner"].ToString();
                readTable.InvoiceNr = reader["mobInvoice"].ToString();
                dataFromDB.Add(readTable);
                newList.Add(reader["mobInvoice"].ToString());

                //dataGrid.DataSource = dataFromDB;
            }
            //firstDataTextBox.Text = newList.ForEach();
            firstDataTextBox.Text = dataFromDB[1].ID;
            this.dataGrid.ItemsSource = dataFromDB;
            reader.Close();
        }


        //?????????????????????????????????????????????????????????????
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var grid = sender as DataGrid;
            sqlQuery = "SELECT * FROM mobMobile";
            //dbConnectionOpen();
            SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-LNOR2D8\SQLEXPRESS; database=Mobile; User id=sa; Password=password;");
            connection.Open();
            SqlCommand SQLcommand = connection.CreateCommand();
            SQLcommand.CommandText = sqlQuery;
            SqlDataReader reader = SQLcommand.ExecuteReader();
            //firstDataTextBox.Text = reader["mobProd"].ToString();
            while (reader.Read())
            {
                grid.ItemsSource = reader["mobProd"].ToString() +
                    reader["mobMod"].ToString() +
                    reader["mobImei"].ToString() +
                    reader["mobComments"].ToString() +
                    reader["mobOwner"].ToString() +
                    reader["mobInvoice"].ToString();

            }
            reader.Close();
            
        }
    }

    
    }

