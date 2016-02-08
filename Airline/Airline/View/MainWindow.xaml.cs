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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase database = new DataBase();

            DataContext = database;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Passenger passenger = new Passenger();
                Seat seat = new Seat();
                passenger.getUserName = textBoxName.Text;
                passenger.getUserAge = textBoxAge.Text;
                seat.seatID = listBoxSeat.SelectedItem.ToString();
                
                SaveXML.SaveData(passenger, seat.seatID, "passengers.xml");
                MessageBox.Show("You have submitted your name to the flight.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
