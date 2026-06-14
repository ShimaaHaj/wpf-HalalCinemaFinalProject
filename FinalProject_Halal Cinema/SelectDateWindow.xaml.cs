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
    /// Interaction logic for SelectDateWindow.xaml
    /// </summary>
    public partial class SelectDateWindow : Window
    {
        public SelectDateWindow()
        {
            InitializeComponent();
        }

        private void goHomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void goHomePage_MouseEnter(object sender, MouseEventArgs e)
        {
            goHomePage.Foreground = Brushes.White;
        }

        private void goHomePage_MouseLeave(object sender, MouseEventArgs e)
        {
            goHomePage.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            goHomePage.Background = new SolidColorBrush(Color.FromRgb(234, 240, 251));
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            MoviesWindow moviesWindow = new MoviesWindow();
            moviesWindow.Show();
            this.Close();
        }
    }
}
