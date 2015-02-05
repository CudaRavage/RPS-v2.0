using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_2 
{
    //the first version of this program used a random number and a 
    //switch to create the opponents throw. if wanted to remake this 
    //with an array, because that felt like a productive exercise.


    //halfway through this I started to think I could cut a lot of code by making classes for a lot of this crap


    public partial class Form1 : Form
    {

        Random random = new Random(); //allows a random number, which will be used to access array index
        string[] opponentThrow = new string[] { "rock", "paper", "scissors" }; //array for opponent options

      
        public Form1() 
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) // "throw" button
        {

            int OpponentThrow = random.Next(0, opponentThrow.Length); // opponent throw randomized

            if (radioButtonRock.Checked == true) // player chooses rock
            {
                if (OpponentThrow == 0)
                {
                    textBox.Text = "TIE!";
                    pictureBoxOpponentRock.Image = pictureBoxPlayerRock.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 1)
                {
                    textBox.Text = "LOSE!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxPlayerPaper.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 2)
                {
                    textBox.Text = "WIN!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxPlayerScissors.Image;
                }

            }

            else if (radioButtonPaper.Checked == true) // player chooses paper
            {
                if (OpponentThrow == 0)
                {
                    textBox.Text = "WIN!";
                    pictureBoxOpponentRock.Image = pictureBoxPlayerRock.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 1)
                {
                    textBox.Text = "TIE!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxPlayerPaper.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 2)
                {
                    textBox.Text = "LOSE!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxPlayerScissors.Image;
                }
            }

            else if (radioButtonScissors.Checked == true) // player chooses scissors
            {
                if (OpponentThrow == 0)
                {
                    textBox.Text = "WIN!";
                    pictureBoxOpponentRock.Image = pictureBoxPlayerRock.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 1)
                {
                    textBox.Text = "LOSE!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxPlayerPaper.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxQuest.Image;
                }

                else if (OpponentThrow == 2)
                {
                    textBox.Text = "TIE!";
                    pictureBoxOpponentRock.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentPaper.Image = pictureBoxQuest.Image;
                    pictureBoxOpponentScissors.Image = pictureBoxPlayerScissors.Image;
                }
            }







           // MessageBox.Show(opponentThrow[random.Next(0, opponentThrow.Length)]);


        }
    }
}
