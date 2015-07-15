using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestCards.BLL.Models;

namespace TestCards.BLL
{
    public class CardRepository
    {
        public List<Card> Cards { get; set; }
        private Random rnd;
        private Type cardType;

//Create another repository for FlashCards.  Make them both implement ICardRepository
        //Possibly forget about using ICard and delete that it may be unnecccessary
        public CardRepository()
        {
            rnd = new Random();
            Cards = new List<Card>();
            GetFromJSON();
            cardType = Cards.GetListType();
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
            WriteToJSON();
        }


        public void GetFromJSON()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\mike\Documents\Visual Studio 2013\Projects\cards.json"))
            {
                    Cards = (List<Card>)serializer.Deserialize(file, typeof(List<Card>));
            }
        }

        public void WriteToJSON()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\mike\Documents\Visual Studio 2013\Projects\cards.json"))
            using (JsonTextWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Cards);
            }
        }

        public Object GetCard()
        {
            int cardIndex = rnd.Next(Cards.Count);
            Object randomCard = Cards[cardIndex];
            return randomCard;
        }



    }
}
