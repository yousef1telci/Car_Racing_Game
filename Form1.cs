using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_C_
{

    /*
            sound efect porblem then resource
     */

    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 13;
        int Score;
        int CarImage;    // for change the car image

        Random rand = new Random();
        Random carPosition = new Random();

        bool goLeft , goRight ;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        // keyDown event <<<  عند ضغط مفتاح معين.
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }
        //Form1_KeyUp
        private void keyISUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score : " + Score;
            Score++;

            // player left and right
            if (goLeft == true && picPlayer.Left > 5)
            {
                picPlayer.Left -=playerSpeed;
            }
            if (goRight == true && picPlayer.Left < 325)
            {
                picPlayer.Left += playerSpeed;
            }

            // road 
            roadTrack1.Top += roadSpeed;
            RoadTruck2.Top += roadSpeed;

            if (roadTrack1.Top > 515)
            {
                roadTrack1.Top = -515;
            }
            if (RoadTruck2.Top > 515)
            {
                RoadTruck2.Top = -515;
            }

            // AI cars
            picAi1.Top += trafficSpeed;
            picAi2.Top += trafficSpeed;

            if (picAi1.Top > 515)
            {
                picAi1.Top = -100;
                changeAiCars(picAi1);
            }
            if (picAi2.Top > 515)
            {
                picAi2.Top = -100;
                changeAiCars(picAi2);
            }

            if (picPlayer.Bounds.IntersectsWith(picAi1.Bounds) ||
                picPlayer.Bounds.IntersectsWith(picAi2.Bounds))
            {
                gameOver();
            }
            //
            if (Score > 40 && Score < 500)
            {
                picAward.Image = Properties.Resources.bronze;       
            }
            if (Score > 500 && Score < 2000)
            {
                picAward.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if (Score > 2000)
            {
                picAward.Image = Properties.Resources.silver;
                roadSpeed = 30;
                trafficSpeed = 25;
            }
        }

        private void changeAiCars(PictureBox tembCars)
        {
            CarImage = rand.Next(1, 9);

            switch (CarImage)
            {
                case 1: 
                    tembCars.Image =Properties.Resources.carPink;
                    break;
                case 2:
                    tembCars.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tembCars.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tembCars.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tembCars.Image = Properties.Resources.ambulance;
                    break;
                case 6:
                    tembCars.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tembCars.Image = Properties.Resources.carOrange;
                    break;
                case 8:
                    tembCars.Image = Properties.Resources.CarRed;
                    break;
            }

            // AI cars position
            if (tembCars.Tag.ToString() == "carLeft")
            {
                picAi1.Left = carPosition.Next(5, 160);
            }
            if (tembCars.Tag.ToString() == "carRight")
            {
                picAi2.Left = carPosition.Next(265, 325);
            }

        }

        private void gameOver()
        {
            //GameTimer.Enabled = false;
            //picPlayer.Image =Properties.Resources.explosion;
            GameTimer.Stop();
            picExplosion.Visible = true;
            playSound();
            picPlayer.Controls.Add(picExplosion);
            picExplosion.Location = new Point(-8, 5);
            picExplosion.BackColor = Color.Transparent; 

            picAward.Visible = true;
            picAward.BringToFront();

            btnStart.Enabled = true;
        }

        private void resetGame()
        {
            btnStart.Enabled = false;
            picExplosion.Visible = false;
            picAward.Visible = false;
            goLeft = false;
            goRight = false;
            Score = 0;
            picAward.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            picAi1.Top = carPosition.Next(200, 500) * -1;
            picAi1.Left = carPosition.Next(5, 160);

            picAi2.Top = carPosition.Next(200, 500) * -1;
            picAi2.Left = carPosition.Next(265, 325);

            GameTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playSound()
        {
            //System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
           
        }
    }
}
