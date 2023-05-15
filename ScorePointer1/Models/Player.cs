using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorePointer1.Models
{
    public class Player
    {
        public string Name { get; set; }//pole za ime 
        public double StartingPoints { get; set; }

        public Player(string Name, double StartingPoints)
        {
            this.Name = Name;
            this.StartingPoints = StartingPoints;
        }
        public Player()
        {
            Name = Name;
            StartingPoints = StartingPoints;
        }
    }
}
