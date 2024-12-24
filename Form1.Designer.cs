namespace Car_Racing_C_
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
            this.picAward = new System.Windows.Forms.PictureBox();
            this.picExplosion = new System.Windows.Forms.PictureBox();
            this.picAi2 = new System.Windows.Forms.PictureBox();
            this.picAi1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.RoadTruck2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTruck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.picAward);
            this.panel1.Controls.Add(this.picExplosion);
            this.panel1.Controls.Add(this.picAi2);
            this.panel1.Controls.Add(this.picAi1);
            this.panel1.Controls.Add(this.picPlayer);
            this.panel1.Controls.Add(this.RoadTruck2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 611);
            this.panel1.TabIndex = 0;
            // 
            // picAward
            // 
            this.picAward.Image = global::Car_Racing_C_.Properties.Resources.bronze;
            this.picAward.Location = new System.Drawing.Point(125, 215);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(250, 100);
            this.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAward.TabIndex = 6;
            this.picAward.TabStop = false;
            // 
            // picExplosion
            // 
            this.picExplosion.Image = global::Car_Racing_C_.Properties.Resources.explosion;
            this.picExplosion.Location = new System.Drawing.Point(72, 354);
            this.picExplosion.Name = "picExplosion";
            this.picExplosion.Size = new System.Drawing.Size(64, 64);
            this.picExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExplosion.TabIndex = 5;
            this.picExplosion.TabStop = false;
            // 
            // picAi2
            // 
            this.picAi2.Image = global::Car_Racing_C_.Properties.Resources.carGrey;
            this.picAi2.Location = new System.Drawing.Point(351, 71);
            this.picAi2.Name = "picAi2";
            this.picAi2.Size = new System.Drawing.Size(50, 100);
            this.picAi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAi2.TabIndex = 4;
            this.picAi2.TabStop = false;
            this.picAi2.Tag = "carRight";
            // 
            // picAi1
            // 
            this.picAi1.Image = global::Car_Racing_C_.Properties.Resources.carGreen;
            this.picAi1.Location = new System.Drawing.Point(200, 87);
            this.picAi1.Name = "picAi1";
            this.picAi1.Size = new System.Drawing.Size(50, 101);
            this.picAi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAi1.TabIndex = 3;
            this.picAi1.TabStop = false;
            this.picAi1.Tag = "carLeft";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::Car_Racing_C_.Properties.Resources.carYellow;
            this.picPlayer.Location = new System.Drawing.Point(246, 477);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 99);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // RoadTruck2
            // 
            this.RoadTruck2.ErrorImage = null;
            this.RoadTruck2.Image = global::Car_Racing_C_.Properties.Resources.roadTrack;
            this.RoadTruck2.InitialImage = null;
            this.RoadTruck2.Location = new System.Drawing.Point(0, 0);
            this.RoadTruck2.Name = "RoadTruck2";
            this.RoadTruck2.Size = new System.Drawing.Size(500, 611);
            this.RoadTruck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTruck2.TabIndex = 1;
            this.RoadTruck2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.ErrorImage = null;
            this.roadTrack1.Image = global::Car_Racing_C_.Properties.Resources.roadTrack;
            this.roadTrack1.InitialImage = null;
            this.roadTrack1.Location = new System.Drawing.Point(0, -500);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(500, 611);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(190, 648);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 46);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScore.Location = new System.Drawing.Point(-5, 613);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(505, 32);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyISUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTruck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox RoadTruck2;
        private System.Windows.Forms.PictureBox picAward;
        private System.Windows.Forms.PictureBox picExplosion;
        private System.Windows.Forms.PictureBox picAi2;
        private System.Windows.Forms.PictureBox picAi1;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer GameTimer;
    }
}

