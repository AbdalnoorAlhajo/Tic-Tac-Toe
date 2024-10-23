using _45___Tic_Tac_Toe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45___Tic_Tac_Toe
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        enum enPlaying { Player1 = 1, Player2 = 2 };

        enPlaying Player = enPlaying.Player1;

        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 20;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 500, 140, 500, 500);
            e.Graphics.DrawLine(pen, 750, 140, 750, 500);
            e.Graphics.DrawLine(pen, 300, 240, 900, 240);
            e.Graphics.DrawLine(pen, 300, 400, 900, 400);

        }


        void ChangePlayer()
        {
            if (lbPlayer.Text == "Player 1")
            {
                lbPlayer.Text = "Player 2";
                Player = enPlaying.Player2;
            }
            else if (lbPlayer.Text == "Player 2")
            {
                lbPlayer.Text = "Player 1";
                Player = enPlaying.Player1;
            }
        }

        Image ReturnImage()
        {
            if (Player == enPlaying.Player1)
            {
                return Resources._1_O;
            }
            else
            {
                return Resources._3__X;
            }
        }

        void ShowErorrMessage()
        {
            MessageBox.Show("This is choosen by your foe.", "Wrong Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void DiableImages()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;

        }

        void ResetPictureBox(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.Black;
            pictureBox.Tag = "?";
            pictureBox.Image = Resources._2__question_mark_96;
            Counter = 0;
            pictureBox.Enabled = true;
            timer1.Enabled = true;
        }

        void ResetAllPictureBox()
        {
            ResetPictureBox(pictureBox1);
            ResetPictureBox(pictureBox2);
            ResetPictureBox(pictureBox3);
            ResetPictureBox(pictureBox4);
            ResetPictureBox(pictureBox5);
            ResetPictureBox(pictureBox6);
            ResetPictureBox(pictureBox7);
            ResetPictureBox(pictureBox8);
            ResetPictureBox(pictureBox9);

        }

        string HowWin()
        {
            if (Player == enPlaying.Player2)
            {
                return "Player 2";
            }
            else
            {
                return "Player 1";
            }
        }

        bool Check3Images(PictureBox P1, PictureBox P2, PictureBox P3)
        {
            if ((P1.Tag == P2.Tag && P2.Tag == P3.Tag) && P1.Tag.ToString() != "?")
            {
                P1.BackColor = Color.Green;
                P2.BackColor = Color.Green;
                P3.BackColor = Color.Green;

                timer1.Enabled = false;

                lbPlayer.Text = "Game Over";
                lbResult.Text = HowWin();

                MessageBox.Show("Congraulation", "Gave Over!" , MessageBoxButtons.OK);
                DiableImages();

                return true;
            }
            else
            {
                return false;
            }
        }

        bool isGameInPrograss()
        {
            if(pictureBox2.Tag.ToString() == "?" || pictureBox1.Tag.ToString() ==  "?" || pictureBox3.Tag.ToString() == "?" || pictureBox4.Tag.ToString() == "?" ||
                    pictureBox5.Tag.ToString() == "?" || pictureBox6.Tag.ToString() == "?" ||
                    pictureBox7.Tag.ToString() == "?" || pictureBox8.Tag.ToString() == "?" || pictureBox9.Tag.ToString() == "?")
            {
                return true;
            }
            else
            {

            return false; 
            }
        }

        bool CheckWinner()
        {

            Check3Images(pictureBox1, pictureBox2, pictureBox3);

            Check3Images(pictureBox4, pictureBox5, pictureBox6);
                                                               
            Check3Images(pictureBox7, pictureBox8, pictureBox9);

            Check3Images(pictureBox1, pictureBox4, pictureBox7);

            Check3Images(pictureBox2, pictureBox5, pictureBox8);
  
            Check3Images(pictureBox3, pictureBox6, pictureBox9);

            Check3Images(pictureBox1, pictureBox5, pictureBox9);

            Check3Images(pictureBox3, pictureBox5, pictureBox7);
            


            if (isGameInPrograss() == true)
            {
                return false;
            }
            else
            {
                lbResult.Text = "Draw";
                lbPlayer.Text = "Game Over";
                timer1.Enabled = false;
                DiableImages();
                return true;
            }
 




        }

        void GameProces(PictureBox pbNumber)
        {

            if(pbNumber.Tag.ToString() == "?")
            {
                switch (Player)
                {
                    case enPlaying.Player1:
                        pbNumber.Image = ReturnImage();
                        pbNumber.Tag = "O";
                        CheckWinner();
                        ChangePlayer();                
                        break;
                    case enPlaying.Player2:
                        pbNumber.Image = ReturnImage();
                        pbNumber.Tag = "X";
                        CheckWinner();
                        ChangePlayer();
                        break;
                }
            }
            else
            {
                ShowErorrMessage();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            GameProces((PictureBox)sender);
        }


        private void lbResetGame_Click(object sender, EventArgs e)
        {
            ResetAllPictureBox();
            Player = enPlaying.Player1;
            lbPlayer.Text = "Player 1";
            lbResult.Text = "In Prograss";
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            label1.Text = "Timer: "+ Counter.ToString() + " S";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.exploratorium.edu/explore/puzzles/tictactoe#:~:text=Rules%20for%20Tic%2DTac%2DToe,or%20diagonally)%20is%20the%20winner.");
        }
    }
}
