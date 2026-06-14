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
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void goMoviesPage_Click(object sender, RoutedEventArgs e)
        {
            MoviesWindow moviesWindow = new MoviesWindow();
            moviesWindow.Show();
            this.Close();
        }

        private void goMoviesPage_MouseEnter(object sender, MouseEventArgs e)
        {
            goMoviesPage.Foreground = Brushes.White;
        }

        private void goMoviesPage_MouseLeave(object sender, MouseEventArgs e)
        {
            goMoviesPage.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            goMoviesPage.Background = new SolidColorBrush(Color.FromRgb(234, 240, 251));
        }
    }
}
