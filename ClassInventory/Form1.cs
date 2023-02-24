using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List <Player> playerList = new List <Player> ();


        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string player, team, position;

            int age;

            player = nameInput.Text;
            age = Convert.ToInt16(ageInput.Text);
            team = teamInput.Text;
            position = positionInput.Text;

            Player player1 = new Player(player, team, position, age);
            playerList.Add(player1);

            outputLabel.Text = $"{player} has been added";

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showPlayer();

        }
        public void showPlayer()
        {
            outputLabel.Text = "";
            foreach (Player player in playerList)
            {
                outputLabel.Text += $" Player: {player.name},\n age: {player.age},\n team: {player.team},\n position: {player.position}\n\n";
            }
        }
    }
}
