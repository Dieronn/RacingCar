namespace RacingCar
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.badge = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.Ai2 = new System.Windows.Forms.PictureBox();
            this.Ai1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.TxtStart = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.TxtStart);
            this.panel1.Controls.Add(this.badge);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.Ai2);
            this.panel1.Controls.Add(this.Ai1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(9, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 862);
            this.panel1.TabIndex = 0;
            // 
            // badge
            // 
            this.badge.Image = global::RacingCar.Properties.Resources.bronze;
            this.badge.Location = new System.Drawing.Point(165, 389);
            this.badge.Margin = new System.Windows.Forms.Padding(4);
            this.badge.Name = "badge";
            this.badge.Size = new System.Drawing.Size(250, 100);
            this.badge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.badge.TabIndex = 1;
            this.badge.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::RacingCar.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(112, 534);
            this.explosion.Margin = new System.Windows.Forms.Padding(4);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(100, 100);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 1;
            this.explosion.TabStop = false;
            // 
            // Ai2
            // 
            this.Ai2.Image = global::RacingCar.Properties.Resources.carGrey;
            this.Ai2.Location = new System.Drawing.Point(335, 32);
            this.Ai2.Margin = new System.Windows.Forms.Padding(4);
            this.Ai2.Name = "Ai2";
            this.Ai2.Size = new System.Drawing.Size(80, 140);
            this.Ai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai2.TabIndex = 1;
            this.Ai2.TabStop = false;
            this.Ai2.Tag = "carRight";
            // 
            // Ai1
            // 
            this.Ai1.Image = global::RacingCar.Properties.Resources.carGreen;
            this.Ai1.Location = new System.Drawing.Point(165, 42);
            this.Ai1.Margin = new System.Windows.Forms.Padding(4);
            this.Ai1.Name = "Ai1";
            this.Ai1.Size = new System.Drawing.Size(80, 140);
            this.Ai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai1.TabIndex = 1;
            this.Ai1.TabStop = false;
            this.Ai1.Tag = "carLeft";
            // 
            // player
            // 
            this.player.Image = global::RacingCar.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(288, 684);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 140);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::RacingCar.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(640, 862);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 0;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::RacingCar.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, -862);
            this.roadTrack1.Margin = new System.Windows.Forms.Padding(4);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(640, 862);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(532, 900);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Score.Location = new System.Drawing.Point(28, 900);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(349, 46);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // TxtStart
            // 
            this.TxtStart.AutoSize = true;
            this.TxtStart.BackColor = System.Drawing.Color.Black;
            this.TxtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtStart.ForeColor = System.Drawing.Color.White;
            this.TxtStart.Location = new System.Drawing.Point(71, 351);
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(408, 138);
            this.TxtStart.TabIndex = 2;
            this.TxtStart.Text = "PRESS ENTER \r\nOR START BUTTON \r\nTO BEGIN";
            this.TxtStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtStart.UseMnemonic = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(407, 902);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 961);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Racing Car Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox badge;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox Ai2;
        private System.Windows.Forms.PictureBox Ai1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label TxtStart;
        private System.Windows.Forms.Button btnSave;
    }
}

