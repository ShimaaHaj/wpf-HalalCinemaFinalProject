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

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myCalendar.SelectedDate == null)
                return;

            DateTime selectedDate = myCalendar.SelectedDate.Value.Date;

            if (IsInvalidDate(selectedDate))
            {
                ShowInvalidDateMessage();
                ClearSelectedDate();
            }
            else
            {
                ConfirmAndGoToMovies(selectedDate);
            }
        }

        private bool IsInvalidDate(DateTime selectedDate)
        {
            DateTime firstAllowedDate = DateTime.Today.AddDays(1);
            DateTime lastAllowedDate = DateTime.Today.AddDays(5);

            return selectedDate < firstAllowedDate || selectedDate > lastAllowedDate;
        }

        private void ShowInvalidDateMessage()
        {
            MessageBox.Show(
                "هذا التاريخ غير متاح للحجز.\nالرجاء اختيار يوم من الأيام الخمسة القادمة فقط.",
                "تاريخ غير متاح",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
        }

        private void ClearSelectedDate()
        {
            myCalendar.SelectedDate = null;
        }

        private void ConfirmAndGoToMovies(DateTime selectedDate)
        {
            MessageBoxResult result = MessageBox.Show(
                "لقد اخترت التاريخ: " + selectedDate.ToString("dd/MM/yyyy") +
                "\nهل تريد الانتقال إلى قائمة الأفلام؟",
                "تأكيد اختيار اليوم",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MoviesWindow moviesWindow = new MoviesWindow();
                moviesWindow.Show();
                this.Close();
            }
            else
            {
                ClearSelectedDate();
            }
        }
    }
}
