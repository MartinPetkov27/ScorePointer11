using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScorePointer1.Models;
using ScorePointer1.Services;
using System.IO;

namespace ScorePointer1
{
    public partial class Form3 : Form 
    {
        GameService _gameService;
        Games _games = new Games();
        double selectedPoints ;
        string[] selectedItem;
        string selectedName;
        public double SelectedPoints
        {
            get { return selectedPoints; }
            set { selectedPoints = Convert.ToDouble(txtSlectedPoints.Text.ToString()); }
        }
        public string[] SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = lbPlayersInGame.SelectedItem.ToString().Split("---").ToArray(); }
        }
        public string SelectedName
        {
            get { return selectedName; }
            set { selectedName = selectedItem[0]; }
        }
       

        public Form3(GameService gameService)
        {
            _gameService = gameService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPoints();
        }

        private void lbPlayersInGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableMinusPlus();
        }
        private void EnableMinusPlus()
        {
            if(lbPlayersInGame.SelectedIndex == 1)
            {
                button1.Enabled = true;
                btMinus.Enabled = true;
            }
        }
        private void AddPlayersToLB()
        {
            foreach (var item in _gameService.GetGame().Players)
            {
                lbPlayersInGame.Items.Add(item.Name + "---" + item.StartingPoints.ToString());
            }

        }
        private void AddPoints()
        {
            foreach (Player item in _gameService.GetGame().Players)
            {
                if (item.Name == selectedName)
                {
                    item.StartingPoints = item.StartingPoints + selectedPoints;
                }
            }
            lbPlayersInGame.Items.Clear();
            AddPlayersToLB();
        }
        private void MinusPoints()
        {
            foreach (Player item in _gameService.GetGame().Players)
            {
                if (item.Name == selectedName)
                {
                    item.StartingPoints = item.StartingPoints - selectedPoints;
                }
            }
            lbPlayersInGame.Items.Clear();
            AddPlayersToLB();
        }

        private void lbGameNameStart_Click(object sender, EventArgs e)
        {
            lbGameNameStart.Text = _gameService.GetGame().Name;  
            AddPlayersToLB();
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            MinusPoints();
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            _gameService.GetGame().FinishedOn = DateTime.Now;
            _games.SaveGame(_gameService.GetGame());
            Message();
        }
        private void Message()
        {
            string message = "The winner of " + _gameService.GetGame().Name + " game is " + _gameService.GetGame().Winner.Name + " with score of " + _gameService.GetGame().Winner.StartingPoints.ToString();
            string title = "The game has finished";
            MessageBox.Show(message, title);
        }
      
       
    }
}
