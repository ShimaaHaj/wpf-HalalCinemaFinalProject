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
        int movieIndex = 0;


        string[] movieImages = { "img/movie1.png", "img/movie2.png", "img/movie3.png", "img/movie4.png", "img/movie5.png", "img/movie6.png" }; 
        string[] movieCategories = { "تاريخي", "علمي", "سيرة ذاتية", "مغامرة", "روحاني", "ملحمي" }; 
        string[] movieNames = { "Salah Al-Din", "Abbas Ibn Firnas", "Al-Biruni", "Ibn Battuta", "Tustar", "the Elephant" }; 
        string[] movieRatings = { "8.6", "7.8", "8.0", "7.7", "8.4", "7.5" }; 
        string[] movieYears = { "2014", "2009", "2006", "1990", "2023", "2014" }; 

        string[] movieDescriptions = 
        {
            "في زمنٍ تعصف فيه الصراعات بالمنطقة ينهض قائدٌ حكيم لتوحيد الصفوف والدفاع عن القدس في رحلةٍ تصنع أحد أعظم فصول التاريخ.",
            "حين اعتقد الجميع أن الطيران مجرد حلم يكرّس عالمٌ شغوف حياته لصناعة أجنحة قد تغيّر نظرة الإنسان إلى السماء إلى الأبد.",
            "مدفوعًا بشغفه لاكتشاف أسرار الكون ينطلق عالمٌ فذ في رحلة علمية لقياس الأرض وفهم الظواهر التي حيّرت البشر لقرون.",
            "يغادر رحالةٌ شاب وطنه قاصدًا الحج لتتحول رحلته إلى مغامرة استثنائية عبر القارات والحضارات المختلفة.",
            "في ليلةٍ هادئة يقود عملٌ من الرحمة والستر صاحبه إلى طريقٍ يغيّر حياته ويكشف له أثر الخير الخفي بين الناس.",
            "عندما يتجه جيشٌ عظيم نحو مكة يقف فيلٌ ضخم أمام اختبارٍ سيجعله جزءًا من واحدة من أشهر القصص الخالدة في التاريخ."
        };


        public MoviesWindow()
        {
            InitializeComponent();
            ShowMovie();
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




        private void ShowMovie()
        {
            imgMovie.Source = new BitmapImage(new Uri(movieImages[movieIndex], UriKind.Relative));

            txtCategory.Text = movieCategories[movieIndex];
            txtMovieName.Text = movieNames[movieIndex];
            txtRating.Text = movieRatings[movieIndex];
            txtYear.Text = movieYears[movieIndex];
            txtDescription.Text = movieDescriptions[movieIndex];

            UpdateDots();
        }

        private void UpdateDots()
        {
            dot1.Background = Brushes.Transparent;
            dot2.Background = Brushes.Transparent;
            dot3.Background = Brushes.Transparent;
            dot4.Background = Brushes.Transparent;
            dot5.Background = Brushes.Transparent;
            dot6.Background = Brushes.Transparent;

            if (movieIndex == 0)
                dot1.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
            else if (movieIndex == 1)
                dot2.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
            else if (movieIndex == 2)
                dot3.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
            else if (movieIndex == 3)
                dot4.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
            else if (movieIndex == 4)
                dot5.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
            else if (movieIndex == 5)
                dot6.Background = new SolidColorBrush(Color.FromRgb(2, 56, 150));
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            movieIndex--;

            if (movieIndex == -1)
                movieIndex = 5;

            ShowMovie();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            movieIndex++;

            if (movieIndex == 6)
                movieIndex = 0;

            ShowMovie();
        }
    }
}
