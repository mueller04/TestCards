using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCards.BLL
{
    public class CardRepository
    {
        public List<Card> Cards { get; set; }

        public CardRepository()
        {
            Cards = new List<Card>();
        }

        public void Add(string question, string correctAnswerText, string incorrectAnswerText1, 
                                    string incorrectAnswerText2, string incorrectAnswerText3)
        {
          Answer correctAnswer = new Answer() { Text = correctAnswerText };
          Answer incorrectAnswer1 = new Answer() { Text = incorrectAnswerText1, IsCorrect = false};
          Answer incorrectAnswer2 = new Answer() { Text = incorrectAnswerText2, IsCorrect = false};
          Answer incorrectAnswer3 = new Answer() { Text = incorrectAnswerText3, IsCorrect = false};

          Card card = new Card() {Question = question,
                                   CorrectAnswer = correctAnswer,
                                    IncorrectAnswer1 = incorrectAnswer1,
                                    IncorrectAnswer2 = incorrectAnswer2,
                                    IncorrectAnswer3 = incorrectAnswer3};

            Cards.Add(card);
        }
        

    }
}
