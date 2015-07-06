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
    /// Interaction logic for ReviewCardWindow.xaml
    /// </summary>
    public partial class ReviewCardWindow : Window
    {
        private int _randomNumber;
        private Answer answer1;
        private Answer answer2;
        private Answer answer3;
        private Answer answer4;
        private CardRepository CardRepo;

        public ReviewCardWindow()
        {
            Random rnd = new Random();
            InitializeComponent();
            ArrayList cards = new ArrayList();
            CardRepo = new CardRepository();
            Card randomCard = (Card)CardRepo.GetCard();
            txtQuestion.Text = randomCard.Question;
            _randomNumber = rnd.Next(3);

            if (_randomNumber == 0)
            {
                answer1 = randomCard.CorrectAnswer;
                txtAnswer1.Text = answer1.Text;
                
                answer2 = randomCard.IncorrectAnswer1;
                txtAnswer2.Text = answer2.Text;

                answer3 = randomCard.IncorrectAnswer2;
                txtAnswer3.Text = answer3.Text;

                answer4 = randomCard.IncorrectAnswer3;
                txtAnswer4.Text = answer4.Text;

            } else if (_randomNumber == 1)
            {
                answer2 = randomCard.CorrectAnswer;
                txtAnswer2.Text = answer2.Text;

                answer1 = randomCard.IncorrectAnswer1;
                txtAnswer1.Text = answer1.Text;

                answer3 = randomCard.IncorrectAnswer2;
                txtAnswer3.Text = answer3.Text;

                answer4 = randomCard.IncorrectAnswer3;
                txtAnswer4.Text = answer4.Text;

            } else if (_randomNumber == 2)
            {
                answer3 = randomCard.CorrectAnswer;
                txtAnswer3.Text = answer3.Text;

                answer1 = randomCard.IncorrectAnswer2;
                txtAnswer1.Text = answer1.Text;

                answer2 = randomCard.IncorrectAnswer3;
                txtAnswer2.Text = answer2.Text;

                answer4 = randomCard.IncorrectAnswer1;
                txtAnswer4.Text = answer4.Text;

            } else if (_randomNumber == 3)
            {
                answer4 = randomCard.CorrectAnswer;
                txtAnswer4.Text = answer4.Text;

                answer1 = randomCard.IncorrectAnswer1;
                txtAnswer1.Text = answer1.Text;

                answer2 = randomCard.IncorrectAnswer2;
                txtAnswer2.Text = answer2.Text;

                answer3 = randomCard.IncorrectAnswer3;
                txtAnswer3.Text = answer3.Text;
            }

        }

        private void radioAnswer_Checked(object sender, RoutedEventArgs e)
        {

            if (radioAnswer1.IsChecked == true)
            {
                AnswerDialog(answer1.IsCorrect);
                WhenAnswerIsCorrectDisplayNext(answer1.IsCorrect);
            } 
            else if (radioAnswer2.IsChecked == true)
            {
                AnswerDialog(answer2.IsCorrect);
                WhenAnswerIsCorrectDisplayNext(answer2.IsCorrect);
            }
            else if (radioAnswer3.IsChecked == true)
            {
                AnswerDialog(answer3.IsCorrect);
                WhenAnswerIsCorrectDisplayNext(answer3.IsCorrect);
            } 
            else if (radioAnswer4.IsChecked == true)
            {
                AnswerDialog(answer4.IsCorrect);
                WhenAnswerIsCorrectDisplayNext(answer4.IsCorrect);
            }
        }

        private void AnswerDialog(bool isCorrect)
        {
            if (isCorrect)
            {
                txtAnswerStatus.Text = "Correct";
            }
            else
            {
                txtAnswerStatus.Text = "Incorrect";
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void WhenAnswerIsCorrectDisplayNext(bool isAnswerCorrect)
        {
            if (isAnswerCorrect)
            {
            this.Close();
            ReviewCardWindow newCardWindowReflexive = new ReviewCardWindow();
            newCardWindowReflexive.Show();
            }
        }

    }
}
