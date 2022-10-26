using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goLeft, goRight;
        bool goUp, goDown, enter;

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
            if (e.KeyCode == Keys.Enter) enter = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
            if (e.KeyCode == Keys.Enter) enter = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            score++;
            Score.Text = "Score: " + (score / 10).ToString();

            if (score < 1500)
            {
                roadSpeed = 15 + score / 100;
                trafficSpeed = 20 + score / 100;
            }
                     
            if (goLeft == true && player.Left > 15)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Right < 465)
            {
                player.Left += playerSpeed;
            }

            if (goUp == true && player.Top > 100)
            {
                player.Top -= playerSpeed;
            }

            if (goDown == true && player.Bottom < 650)
            {
                player.Top += playerSpeed;
            }

            //ulica
            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 700) roadTrack2.Top = -700;
            if (roadTrack1.Top > 700) roadTrack1.Top = -700;

            //samochody
            Ai1.Top += trafficSpeed;
            Ai2.Top += trafficSpeed;

            if (Ai1.Top > 700)
            {
               changeAIcars(Ai1);
               Ai1.Left = rand.Next(18, 180);
               Ai1.Top = carPosition.Next(100, 800) * -1;
            }

            if (Ai2.Top > 700)
            {
               changeAIcars(Ai2);
               Ai2.Left = rand.Next(250, 420);
               Ai2.Top = carPosition.Next(100, 800) * -1;
            }

            if (player.Bounds.IntersectsWith(Ai1.Bounds) || player.Bounds.IntersectsWith(Ai2.Bounds))
            {
                gameOver();
            }

            if (score > 10 && score < 500) badge.Image = Properties.Resources.bronze;
            if (score >= 500 && score < 1000) badge.Image = Properties.Resources.silver;
            if (score >= 1000) badge.Image = Properties.Resources.gold;
 
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
            }

        }

    private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;

            badge.Visible = true;
            badge.BringToFront();

            btnStart.Enabled = true;
            if (enter == true) ResetGame();
            btnSave.Enabled = true;

        }

        private void ResetGame()
        {
            TxtStart.Visible = false;
            btnStart.Enabled = false;
            btnSave.Enabled = false;
            explosion.Visible = false;
            badge.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;

            Ai1.Visible = true;
            Ai2.Visible = true;
            badge.Image = Properties.Resources.bronze;
            roadSpeed = 12;
            trafficSpeed = 15;

            Ai1.Top = carPosition.Next(100, 800) * -1;
            Ai1.Left = carPosition.Next(40, 195) * -1;

            Ai2.Top = carPosition.Next(100, 800) * -1;
            Ai2.Left = carPosition.Next(250, 420) * -1;

            gameTimer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Label caption = new Label();
            caption.Text = "Score: " + score;
            caption.Font = new Font("Calibri", 40, FontStyle.Bold);
            caption.ForeColor = Color.White;
            caption.AutoSize = false;
            caption.Width = panel1.Width;
            caption.Height = 60;
            caption.TextAlign = ContentAlignment.MiddleCenter;

            panel1.Controls.Add(caption);
            panel1.Controls.Add(badge);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Race car";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File| *.jpg";
            dialog.ValidateNames = true;    //test if it can be saved safely under its name

            //click OK on dialog box
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(panel1.Width);
                int height = Convert.ToInt32(panel1.Height);
                Bitmap bmp = new Bitmap(width, height);
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
            panel1.Controls.Remove(caption);
            panel1.Controls.Remove(badge);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
        private void Start()
        {
            TxtStart.Visible = true;
            Ai1.Visible = false;
            Ai2.Visible = false;
            explosion.Visible = false;
            btnStart.Enabled = true;
            btnSave.Enabled = false;
            explosion.Visible = false;
            badge.Visible = false;

            if (enter == true) ResetGame();
        }

    }
}
