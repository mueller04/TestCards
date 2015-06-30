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
        private CardRepository _cardRepo;

        public MainWindow()
        {
            InitializeComponent();
            _cardRepo = new CardRepository();
        }

        private void btnAddCard_Click(object sender, RoutedEventArgs e)
        {

        }

        //Ask for question, correct answer, and 3 false answers.  Then present the results and give user option to save.
        private void AddCardClick()
        {
            _cardRepo.Add("What are Dolphins", "They are Mammals", "They are fish", "They are Godzilla", "Aliens");
        }

    }
}
