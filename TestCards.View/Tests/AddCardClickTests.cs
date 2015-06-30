using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestCards.BLL;

namespace TestCards.View.Tests
{
    [TestFixture]
    class AddCardClickTests
    {
        [Test]
        public void CardAddSavesQuestioninCollection()
        {
            //Arrange
            CardRepository cardRepo = new CardRepository();

            //Act
            cardRepo.Add("What are Dolphins", "They are Mammals", "They are fish", "They are Godzilla", "Aliens");

            //Assert
            Assert.AreEqual(cardRepo.Cards[0].Question, "What are Dolphins");

        }

    }
}
