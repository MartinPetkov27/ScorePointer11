using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScorePointer1.Models;

namespace ScorePointer1.Services
{
    public class Games
    {
        private List<Game> List;

        public Games()
        {
            List = new List<Game>();
        }
        public void SaveGame(Game game1)
        {
            List.Add(game1);
        }
    }
}
