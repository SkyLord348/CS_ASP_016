using System;
using System.Windows;
using System.Windows.Controls;


namespace CS_ASP_016LPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Get First Date

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            resultLabel.Content = myCalendar.SelectedDate.ToString();




        }





    }
}
