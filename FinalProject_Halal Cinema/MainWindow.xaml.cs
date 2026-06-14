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

namespace FinalProject_Halal_Cinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedButton = "Movies";


        public MainWindow()
        {
            InitializeComponent();
        }




        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = "Movies";

            logoBtnMovies.Foreground = Brushes.White;
            txtBtnMovies.Foreground = Brushes.White;
            arwoBtnMovies.Foreground = Brushes.White;

            bordBtnAbout.Background = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            logoBtnAbout.Foreground = Brushes.White;
            txtBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arowBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

            logoBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arowBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));



            btnMovies.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));
            btnAbout.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            btnExit.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));

            SelectDateWindow selectDateWindow = new SelectDateWindow();
            selectDateWindow.Show();
            this.Close();
        }

        private void btnMovies_MouseEnter(object sender, MouseEventArgs e)
        {
            logoBtnMovies.Foreground = Brushes.White;
            txtBtnMovies.Foreground = Brushes.White;
            arwoBtnMovies.Foreground = Brushes.White;
            btnMovies.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));
        }

        private void btnMovies_MouseLeave(object sender, MouseEventArgs e)
        {
            if (selectedButton != "Movies")
            {
                logoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
                txtBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
                arwoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

                btnMovies.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            }
        }



        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = "About";

            logoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arwoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

            bordBtnAbout.Background = Brushes.White;
            logoBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnAbout.Foreground = Brushes.White;
            arowBtnAbout.Foreground = Brushes.White;

            logoBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arowBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));



            btnMovies.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            btnAbout.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));
            btnExit.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
        }

        private void btnAbout_MouseEnter(object sender, MouseEventArgs e)
        {
            bordBtnAbout.Background = Brushes.White;
            logoBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnAbout.Foreground = Brushes.White;
            arowBtnAbout.Foreground = Brushes.White;

            btnAbout.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));
        }

        private void btnAbout_MouseLeave(object sender, MouseEventArgs e)
        {
            if (selectedButton != "About")
            {
                bordBtnAbout.Background = new SolidColorBrush(Color.FromRgb(48, 92, 187));
                logoBtnAbout.Foreground = Brushes.White;
                txtBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
                arowBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

                btnAbout.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            }
        }




        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = "Exit";

            logoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            txtBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arwoBtnMovies.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

            bordBtnAbout.Background = new SolidColorBrush(Color.FromRgb(48, 92, 187));
            logoBtnAbout.Foreground = Brushes.White;
            txtBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
            arowBtnAbout.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

            logoBtnExit.Foreground = Brushes.White;
            txtBtnExit.Foreground = Brushes.White;
            arowBtnExit.Foreground = Brushes.White;



            btnMovies.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            btnAbout.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            btnExit.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));


            MessageBoxResult result = MessageBox.Show("هل أنت متأكد من الخروج من النظام؟", "تأكيد الخروج", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void btnExit_MouseEnter(object sender, MouseEventArgs e)
        {
            logoBtnExit.Foreground = Brushes.White;
            txtBtnExit.Foreground = Brushes.White;
            arowBtnExit.Foreground = Brushes.White;

            btnExit.Background = new SolidColorBrush(Color.FromRgb(11, 70, 174));
        }

        private void btnExit_MouseLeave(object sender, MouseEventArgs e)
        {
            if (selectedButton != "Exit")
            {
                logoBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));
                txtBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(37, 44, 72));
                arowBtnExit.Foreground = new SolidColorBrush(Color.FromRgb(48, 92, 187));

                btnExit.Background = new SolidColorBrush(Color.FromRgb(250, 251, 253));
            }
        }
    }
}
