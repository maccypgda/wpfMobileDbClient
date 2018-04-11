using System;
using System.Collections.Generic;
using System.Windows;
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
            this.DataContext = this;
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
            newWindow.ShowDialog();
        }
        //working
        void newWindow_RaiseCustomEvent(object sender, CustomEventArgs e)
        {
            sqlQuery = "INSERT INTO mobMobile (mobProd, mobMod, mobImei, mobComments, mobOwner, mobInvoice) VALUES ('" +
            e.Message[0] + "', '" + e.Message[1] + "', '" + e.Message[2] + "', '" + e.Message[3] + "', '" + e.Message[4] + "', '" + e.Message[5] + "')";
            firstDataTextBox.Text = sqlQuery;
            saveDataToDataBase(sqlQuery);
        }
        private void readDB_Click(object sender, RoutedEventArgs e)
        {

            //TODO:
            //CLEAR DATAGRID BEFORE LOADING NEW DATA
            this.dataGrid.ItemsSource = null;
            this.dataGrid.Items.Refresh();
            //////////////


            sqlQuery = "SELECT * FROM mobMobile";
            SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-LNOR2D8\SQLEXPRESS; database=Mobile; User id=sa; Password=password;");
            connection.Open();
            SqlCommand SQLcommand = connection.CreateCommand();
            SQLcommand.CommandText = sqlQuery;
            SqlDataReader reader = SQLcommand.ExecuteReader();
            while (reader.Read())
            {
                newList.Add(reader["mobId"].ToString());
                newList.Add(reader["mobProd"].ToString());
                newList.Add(reader["mobMod"].ToString());
                newList.Add(reader["mobImei"].ToString());
                newList.Add(reader["mobComments"].ToString());
                newList.Add(reader["mobOwner"].ToString());
                newList.Add(reader["mobInvoice"].ToString());

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
            }
            firstDataTextBox.Text = dataFromDB[1].ID;
            this.dataGrid.ItemsSource = dataFromDB;
            reader.Close();
        }
        
        private void clearGrid_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Items.Refresh();
        }
    }

    
    }

