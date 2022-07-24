
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.BackgroundImage = global::FlappyBird.Properties.Resources.BIRD;
            this.Bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bird.Location = new System.Drawing.Point(27, 318);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(100, 50);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 2;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PipeUp
            // 
            this.PipeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PipeUp.BackColor = System.Drawing.Color.Transparent;
            this.PipeUp.BackgroundImage = global::FlappyBird.Properties.Resources.pipeup;
            this.PipeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeUp.Location = new System.Drawing.Point(244, 457);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(100, 646);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 1;
            this.PipeUp.TabStop = false;
            this.PipeUp.Click += new System.EventHandler(this.PipeUp_Click);
            // 
            // PipeDown
            // 
            this.PipeDown.BackColor = System.Drawing.Color.Transparent;
            this.PipeDown.BackgroundImage = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PipeDown.Location = new System.Drawing.Point(27, -459);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(100, 631);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 0;
            this.PipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(-1, 626);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(439, 87);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.Color.Yellow;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.Location = new System.Drawing.Point(43, 663);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(138, 29);
            this.scoreLBL.TabIndex = 4;
            this.scoreLBL.Text = "SCORE : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::FlappyBird.Properties.Resources.BackgroundMorning;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 711);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.PipeUp);
            this.Controls.Add(this.PipeDown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreLBL;
    }
}

