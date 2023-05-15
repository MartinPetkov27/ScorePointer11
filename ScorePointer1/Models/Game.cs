using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePointer1.Models
{
    public class Game
    {
        public string Name { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime? FinishedOn { get; set; }

        public List<Player> Players = new List<Player>();

        public Player Winner;
        public Game()
        {
            this.Name = Name;
            this.AddedOn = AddedOn;
            this.FinishedOn = FinishedOn;
        }
        public Game(string name, DateTime AddedOn, DateTime? FinishedOn)
        {
            Name = name;
            this.AddedOn = AddedOn;
            this.FinishedOn = FinishedOn;
        }
        public Player GetWinner()
        {
            double maxPoints = -1;
            Player winner = new Player();
            foreach (Player player in Players)
            {
                if (player.StartingPoints > maxPoints)
                {
                    winner = player;
                    maxPoints = player.StartingPoints;
                }
            }
            return winner;
        }
        
    }
}
