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

namespace FinalProject_Halal_Cinema
{
    /// <summary>
    /// Interaction logic for MoviesWindow.xaml
    /// </summary>
    public partial class MoviesWindow : Window
    {
        public MoviesWindow()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
            this.Close();
        }

        private void goDatePage_Click(object sender, RoutedEventArgs e)
        {
            SelectDateWindow selectDateWindow = new SelectDateWindow();
            selectDateWindow.Show();
            this.Close();
        }

        private void goDatePage_MouseEnter(object sender, MouseEventArgs e)
        {
            goDatePage.Foreground = Brushes.White;
        }

        private void goDatePage_MouseLeave(object sender, MouseEventArgs e)
        {
            goDatePage.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            goDatePage.Background = new SolidColorBrush(Color.FromRgb(234, 240, 251));
        }
    }
}
