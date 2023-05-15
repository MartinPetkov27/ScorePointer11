using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScorePointer1.Services;
using ScorePointer1.Models;
using System.IO;

namespace ScorePointer1
{
    public partial class Form2 : Form
    {
        GameService _gameService;
        public Form2()
        {
            _gameService = new GameService();
            InitializeComponent();
        }

        private void btInitializeGame_Click(object sender, EventArgs e)
        {
            Game game1 = new Game(txtGameName.Text.ToString(), DateTime.Now, null);
            _gameService.SaveGame(game1);
            btInitializeGame.Visible = false;
            ShowAddStuff();
        }
        private void ShowAddStuff()
        {
            lblMssAddPlayer.Visible = true;
            lblMssWriteName.Visible = true;
            comboBox1.Visible = true;
            lblMssStaringPoints.Visible = true;
            txtStartingPoints.Visible = true;
            btAddPlayer.Visible = true;
            lsbPlayers.Visible = true;
            btStart.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Custom")
            {
                comboBox1.Enabled = false;
                txtChangedName.Visible = true;
            }
           
        }

        private void btAddPlayer_Click(object sender, EventArgs e)
        {
            Player player1 = new Player(GetPlayerName(),Convert.ToDouble(txtStartingPoints.Text.ToString()));
            _gameService.GetGame().Players.Add(player1);
            AddToListBox(player1);
        }
        private string GetPlayerName()
        {
            if (txtChangedName.Visible == true)
            {
                string name = txtChangedName.Text.ToString();
                txtChangedName.Visible = false;
                comboBox1.Enabled = true;
                return name;
            }
            else
            {
                return comboBox1.SelectedItem.ToString();
            }
        }
        private void AddToListBox(Player p )
        {
            lsbPlayers.Items.Add("## " + p.Name + " - " + p.StartingPoints + " ##");
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(_gameService);
            form3.Show();
            Visible = false;
            PrintPLayers(_gameService.GetGame());
        }
        private void PrintPLayers(Game game1)
        {
            string filepath = @"D:\Programing\Proizvodstwena praktika\ScorePointer1";
            List<string> lines = new List<string>();
            foreach (var player in game1.Players)
            {
                string line = player.Name + "," + player.StartingPoints.ToString();
                lines.Add(line);
            }
            File.WriteAllLines(filepath, lines);

        }
    }
}
