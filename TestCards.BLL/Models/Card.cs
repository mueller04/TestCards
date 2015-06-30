using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCards.BLL
{
    public class Card
    {
        public string Question { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Answer IncorrectAnswer1 { get; set; }
        public Answer IncorrectAnswer2 { get; set; }
        public Answer IncorrectAnswer3 { get; set; }
    }
}
