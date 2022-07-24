using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        Timer timer = new Timer();
        int PipeSpeed = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Flappy Bird";
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= PipeSpeed;
            PipeUp.Left -= PipeSpeed;

            if (PipeDown.Left < -90)
            {
                PipeDown.Left = 460;
                PipeDown.Top += 20;
                score++;
                
            }
            if (PipeUp.Left < -90)
            {
                PipeUp.Left = 460;
                PipeUp.Top -= 20;
                score++;
                
            }
            scoreLBL.Text = "SCORE : " + score.ToString();
            if(Bird.Bounds.IntersectsWith(PipeDown.Bounds) ||
                Bird.Bounds.IntersectsWith(PipeUp.Bounds) ||  
                Bird.Bounds.IntersectsWith(ground.Bounds) ||
                Bird.Top < Bird.Height*(-1))
            {
                End();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Space == e.KeyCode)
            {
                gravity -= 35;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Space == e.KeyCode)
            {
                gravity = 10;
            }
        }

        private void PipeUp_Click(object sender, EventArgs e)
        {

        }
        private void End()
        {
            timer.Stop();
            scoreLBL.Text += "  GAME OVER!";
        }
    }
}
