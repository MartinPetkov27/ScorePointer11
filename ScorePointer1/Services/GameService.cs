using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScorePointer1.Models;


namespace ScorePointer1.Services
{
    public class GameService
    {
        private Game newestGame;

        public List<string> Names = new List<string> { "Mr.White", "Skyler White", "Jesse Pinkman", "Hank Schrader", "Marie Schrader",
            "Walter White Jr.",  "Gus Fring", "Saul Goodman", "Mike Ehrmantraut", "Todd", " Steven Gomez ",
        "Badger", "Bogdan", "Tuco Salamanca", "Hector Salamanca", "Don Eladio", "Jane Margolis", "Victor", "Gretchen Schwartz", "Elliott Schwartz"};
        public string GetSuggestedName()
        {
            string suggestedName = null;
            Random rnd = new Random();
            int i = 19;
            int number = rnd.Next(0, i);
            suggestedName = Names[number];
            Names.Remove(suggestedName);
            i--;
            return suggestedName;
        }
        public void SaveGame(Game currentGame)
        {
            newestGame = currentGame;
        }
        public Game GetGame()
        {
            return newestGame;
        }
    }
}
