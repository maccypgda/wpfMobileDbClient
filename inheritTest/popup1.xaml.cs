using System;
using System.Collections.Generic;
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

namespace inheritTest
{
    /// <summary>
    /// Interaction logic for popup1.xaml
    /// </summary>
    public partial class popup1 : Window
    {
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        public event EventHandler<CustomEventArgs> passDatafromPopu1toMain;
        List<string> dataFromPopup = new List<string>();

        public popup1()
        {
            InitializeComponent();
            CenterWindowOnScreen();
        }
        public List<string> myText()
        {
            dataFromPopup.Add(producentNameTextBox.Text);
            dataFromPopup.Add(modelNameTextBox.Text);
            dataFromPopup.Add(imeiTextBox.Text);
            dataFromPopup.Add(DamageTypeTextBox.Text);
            dataFromPopup.Add(ownerTextBox.Text);
            dataFromPopup.Add(invoiceNumberTextBox.Text);

            return dataFromPopup;
        }
        private void addMobileButton_Click(object sender, RoutedEventArgs e)
        {
            if (producentNameTextBox.Text == "")
            {
                string message = "Wypenij pole 'producent'!";
                addMobileErrorWindow errorWindow = new addMobileErrorWindow(message);
                errorWindow.ShowDialog();
            }
            else
            {
                myText();
                passDatafromPopu1toMain(this, new CustomEventArgs(dataFromPopup));
                this.Close();
            }
        }
    }
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(List<string> newList)
        {
            msg = newList;
        }
        private List<string> msg;
        public List<string> Message
        {
            get { return msg; }
        }
    }
}

