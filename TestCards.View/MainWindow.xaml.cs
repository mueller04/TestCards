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
using TestCards.BLL;

namespace TestCards.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public static MainWindow AppWindow;

        public MainWindow()
        {
            InitializeComponent();
            
            AppWindow = this;
        }

        private void btnAddCard_Click(object sender, RoutedEventArgs e)
        {
            AddCardClick();
        }

        
        private void AddCardClick()
        {
            var addCardWindow = new AddCardWindow();
            addCardWindow.ShowDialog();
        }

        private void btnReviewCards_Click(object sender, RoutedEventArgs e)
        {
            ReviewCards();
        }

        private void ReviewCards()
        {
            var reviewCardWindow = new ReviewCardWindow();
            reviewCardWindow.ShowDialog();
        }

        private void btnAddFlashcard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReviewFlashCards_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
