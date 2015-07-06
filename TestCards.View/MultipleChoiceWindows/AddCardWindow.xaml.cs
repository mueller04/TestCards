using System;
using System.Collections;
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
using TestCards.BLL;

namespace TestCards.View
{
    /// <summary>
    /// Interaction logic for AddCardWindow.xaml
    /// </summary>
    public partial class AddCardWindow : Window
    {
        public CardRepository CardRepo;
        public static AddCardWindow AppWindow;

        public AddCardWindow()
        {
            InitializeComponent();
            CardRepo = new CardRepository();
            AppWindow = this;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Submit();
        }

        private void Submit()
        {
            if (txtQuestion.Text == null || txtCorrectAnswer.Text == null
                || txtWrongAnswer1 == null || txtWrongAnswer2 == null || txtWrongAnswer3 == null)
            {
                MessageBox.Show("All fields must be filled out.");
            }
            else
            {
                CardRepo.Add(txtQuestion.Text, txtCorrectAnswer.Text, txtWrongAnswer1.Text, txtWrongAnswer2.Text, txtWrongAnswer3.Text);
                txtQuestion.Clear();
                txtCorrectAnswer.Clear();
                txtWrongAnswer1.Clear();
                txtWrongAnswer2.Clear();
                txtWrongAnswer3.Clear();
            }


            
        }
    }
}
