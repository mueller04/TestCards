using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TestCards.BLL
{
    public class Card : ICard
    {
        public string Question { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Answer IncorrectAnswer1 { get; set; }
        public Answer IncorrectAnswer2 { get; set; }
        public Answer IncorrectAnswer3 { get; set; }
        public static string Path = @"C:\Users\mike\Documents\Visual Studio 2013\Projects\cards.json";      
    }
}
