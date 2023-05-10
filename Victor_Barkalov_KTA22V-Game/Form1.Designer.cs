namespace Victor_Barkalov_KTA22V_Game
{
    partial class BV_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BV_Form1));
            this.BV_timerLeft = new System.Windows.Forms.Timer(this.components);
            this.BV_timerRight = new System.Windows.Forms.Timer(this.components);
            this.BV_timerUP = new System.Windows.Forms.Timer(this.components);
            this.BV_timerDown = new System.Windows.Forms.Timer(this.components);
            this.BV_u1 = new System.Windows.Forms.Timer(this.components);
            this.BV_ufo3 = new System.Windows.Forms.PictureBox();
            this.BV_btnStart = new System.Windows.Forms.Button();
            this.BV_ufo2 = new System.Windows.Forms.PictureBox();
            this.BV_Hero1 = new System.Windows.Forms.PictureBox();
            this.BV_ufo1 = new System.Windows.Forms.PictureBox();
            this.BV_bullets = new System.Windows.Forms.Timer(this.components);
            this.BV_bullet = new System.Windows.Forms.PictureBox();
            this.BV_Box1 = new System.Windows.Forms.GroupBox();
            this.BV_lives2 = new System.Windows.Forms.PictureBox();
            this.BV_lives3 = new System.Windows.Forms.PictureBox();
            this.BV_lives1 = new System.Windows.Forms.PictureBox();
            this.BV_txtpoint = new System.Windows.Forms.Label();
            this.BV_points = new System.Windows.Forms.Label();
            this.BV_GameOver = new System.Windows.Forms.Panel();
            this.BV_reload = new System.Windows.Forms.Button();
            this.BV_pointsGO = new System.Windows.Forms.Label();
            this.BV_pointsGO2 = new System.Windows.Forms.Label();
            this.BV_closeGame = new System.Windows.Forms.Button();
            this.BV_lblGameOver = new System.Windows.Forms.Label();
            this.BV_BossStart = new System.Windows.Forms.Timer(this.components);
            this.BV_pic1 = new System.Windows.Forms.PictureBox();
            this.BV_pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_Hero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_bullet)).BeginInit();
            this.BV_Box1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives1)).BeginInit();
            this.BV_GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BV_pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // BV_timerLeft
            // 
            this.BV_timerLeft.Interval = 10;
            this.BV_timerLeft.Tick += new System.EventHandler(this.BV_timerLeft_Tick);
            // 
            // BV_timerRight
            // 
            this.BV_timerRight.Interval = 10;
            this.BV_timerRight.Tick += new System.EventHandler(this.BV_timerRight_Tick);
            // 
            // BV_timerUP
            // 
            this.BV_timerUP.Interval = 10;
            this.BV_timerUP.Tick += new System.EventHandler(this.BV_timerUP_Tick);
            // 
            // BV_timerDown
            // 
            this.BV_timerDown.Interval = 10;
            this.BV_timerDown.Tick += new System.EventHandler(this.BV_timerDown_Tick);
            // 
            // BV_u1
            // 
            this.BV_u1.Interval = 30;
            this.BV_u1.Tick += new System.EventHandler(this.BV_u1_Tick);
            // 
            // BV_ufo3
            // 
            this.BV_ufo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BV_ufo3.BackgroundImage")));
            this.BV_ufo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BV_ufo3.Enabled = false;
            this.BV_ufo3.Location = new System.Drawing.Point(870, 161);
            this.BV_ufo3.Name = "BV_ufo3";
            this.BV_ufo3.Size = new System.Drawing.Size(88, 74);
            this.BV_ufo3.TabIndex = 3;
            this.BV_ufo3.TabStop = false;
            this.BV_ufo3.Visible = false;
            // 
            // BV_btnStart
            // 
            this.BV_btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV_btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_btnStart.Location = new System.Drawing.Point(416, 238);
            this.BV_btnStart.Name = "BV_btnStart";
            this.BV_btnStart.Size = new System.Drawing.Size(123, 94);
            this.BV_btnStart.TabIndex = 5;
            this.BV_btnStart.Text = "Start";
            this.BV_btnStart.UseVisualStyleBackColor = true;
            this.BV_btnStart.Click += new System.EventHandler(this.BV_btnStart_Click);
            // 
            // BV_ufo2
            // 
            this.BV_ufo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BV_ufo2.BackgroundImage")));
            this.BV_ufo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BV_ufo2.Enabled = false;
            this.BV_ufo2.Location = new System.Drawing.Point(870, 288);
            this.BV_ufo2.Name = "BV_ufo2";
            this.BV_ufo2.Size = new System.Drawing.Size(88, 72);
            this.BV_ufo2.TabIndex = 4;
            this.BV_ufo2.TabStop = false;
            this.BV_ufo2.Visible = false;
            // 
            // BV_Hero1
            // 
            this.BV_Hero1.BackColor = System.Drawing.Color.Transparent;
            this.BV_Hero1.Enabled = false;
            this.BV_Hero1.Image = ((System.Drawing.Image)(resources.GetObject("BV_Hero1.Image")));
            this.BV_Hero1.Location = new System.Drawing.Point(3, 238);
            this.BV_Hero1.Name = "BV_Hero1";
            this.BV_Hero1.Size = new System.Drawing.Size(185, 94);
            this.BV_Hero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BV_Hero1.TabIndex = 0;
            this.BV_Hero1.TabStop = false;
            this.BV_Hero1.Visible = false;
            // 
            // BV_ufo1
            // 
            this.BV_ufo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BV_ufo1.BackgroundImage")));
            this.BV_ufo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BV_ufo1.Enabled = false;
            this.BV_ufo1.Location = new System.Drawing.Point(870, 384);
            this.BV_ufo1.Name = "BV_ufo1";
            this.BV_ufo1.Size = new System.Drawing.Size(88, 70);
            this.BV_ufo1.TabIndex = 1;
            this.BV_ufo1.TabStop = false;
            this.BV_ufo1.Visible = false;
            // 
            // BV_bullets
            // 
            this.BV_bullets.Interval = 10;
            this.BV_bullets.Tick += new System.EventHandler(this.BV_bullets_Tick);
            // 
            // BV_bullet
            // 
            this.BV_bullet.BackColor = System.Drawing.Color.Transparent;
            this.BV_bullet.Enabled = false;
            this.BV_bullet.Image = ((System.Drawing.Image)(resources.GetObject("BV_bullet.Image")));
            this.BV_bullet.Location = new System.Drawing.Point(148, 259);
            this.BV_bullet.Name = "BV_bullet";
            this.BV_bullet.Size = new System.Drawing.Size(67, 50);
            this.BV_bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BV_bullet.TabIndex = 6;
            this.BV_bullet.TabStop = false;
            this.BV_bullet.Visible = false;
            // 
            // BV_Box1
            // 
            this.BV_Box1.BackColor = System.Drawing.Color.DodgerBlue;
            this.BV_Box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BV_Box1.Controls.Add(this.BV_lives2);
            this.BV_Box1.Controls.Add(this.BV_lives3);
            this.BV_Box1.Controls.Add(this.BV_lives1);
            this.BV_Box1.Controls.Add(this.BV_txtpoint);
            this.BV_Box1.Controls.Add(this.BV_points);
            this.BV_Box1.Enabled = false;
            this.BV_Box1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_Box1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BV_Box1.Location = new System.Drawing.Point(0, 0);
            this.BV_Box1.Name = "BV_Box1";
            this.BV_Box1.Size = new System.Drawing.Size(980, 104);
            this.BV_Box1.TabIndex = 7;
            this.BV_Box1.TabStop = false;
            this.BV_Box1.Visible = false;
            // 
            // BV_lives2
            // 
            this.BV_lives2.BackColor = System.Drawing.Color.Transparent;
            this.BV_lives2.Image = ((System.Drawing.Image)(resources.GetObject("BV_lives2.Image")));
            this.BV_lives2.Location = new System.Drawing.Point(68, 48);
            this.BV_lives2.Name = "BV_lives2";
            this.BV_lives2.Size = new System.Drawing.Size(77, 50);
            this.BV_lives2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BV_lives2.TabIndex = 12;
            this.BV_lives2.TabStop = false;
            this.BV_lives2.Visible = false;
            // 
            // BV_lives3
            // 
            this.BV_lives3.BackColor = System.Drawing.Color.Transparent;
            this.BV_lives3.Image = ((System.Drawing.Image)(resources.GetObject("BV_lives3.Image")));
            this.BV_lives3.Location = new System.Drawing.Point(130, 48);
            this.BV_lives3.Name = "BV_lives3";
            this.BV_lives3.Size = new System.Drawing.Size(79, 50);
            this.BV_lives3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BV_lives3.TabIndex = 11;
            this.BV_lives3.TabStop = false;
            this.BV_lives3.Visible = false;
            // 
            // BV_lives1
            // 
            this.BV_lives1.BackColor = System.Drawing.Color.Transparent;
            this.BV_lives1.Image = ((System.Drawing.Image)(resources.GetObject("BV_lives1.Image")));
            this.BV_lives1.Location = new System.Drawing.Point(0, 48);
            this.BV_lives1.Name = "BV_lives1";
            this.BV_lives1.Size = new System.Drawing.Size(79, 50);
            this.BV_lives1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BV_lives1.TabIndex = 10;
            this.BV_lives1.TabStop = false;
            this.BV_lives1.Visible = false;
            // 
            // BV_txtpoint
            // 
            this.BV_txtpoint.AutoSize = true;
            this.BV_txtpoint.Location = new System.Drawing.Point(276, 41);
            this.BV_txtpoint.Name = "BV_txtpoint";
            this.BV_txtpoint.Size = new System.Drawing.Size(150, 41);
            this.BV_txtpoint.TabIndex = 9;
            this.BV_txtpoint.Text = "Points";
            // 
            // BV_points
            // 
            this.BV_points.BackColor = System.Drawing.Color.AliceBlue;
            this.BV_points.ForeColor = System.Drawing.Color.Red;
            this.BV_points.Location = new System.Drawing.Point(442, 35);
            this.BV_points.Name = "BV_points";
            this.BV_points.Size = new System.Drawing.Size(122, 53);
            this.BV_points.TabIndex = 8;
            this.BV_points.Text = "0";
            this.BV_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BV_GameOver
            // 
            this.BV_GameOver.BackColor = System.Drawing.Color.DodgerBlue;
            this.BV_GameOver.Controls.Add(this.BV_reload);
            this.BV_GameOver.Controls.Add(this.BV_pointsGO);
            this.BV_GameOver.Controls.Add(this.BV_pointsGO2);
            this.BV_GameOver.Controls.Add(this.BV_closeGame);
            this.BV_GameOver.Controls.Add(this.BV_lblGameOver);
            this.BV_GameOver.Enabled = false;
            this.BV_GameOver.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_GameOver.Location = new System.Drawing.Point(283, 145);
            this.BV_GameOver.Name = "BV_GameOver";
            this.BV_GameOver.Size = new System.Drawing.Size(406, 309);
            this.BV_GameOver.TabIndex = 13;
            this.BV_GameOver.Visible = false;
            // 
            // BV_reload
            // 
            this.BV_reload.BackColor = System.Drawing.Color.LimeGreen;
            this.BV_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV_reload.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_reload.Location = new System.Drawing.Point(229, 202);
            this.BV_reload.Name = "BV_reload";
            this.BV_reload.Size = new System.Drawing.Size(115, 78);
            this.BV_reload.TabIndex = 4;
            this.BV_reload.Text = "New Game";
            this.BV_reload.UseVisualStyleBackColor = false;
            this.BV_reload.Click += new System.EventHandler(this.BV_reload_Click);
            // 
            // BV_pointsGO
            // 
            this.BV_pointsGO.AutoSize = true;
            this.BV_pointsGO.Location = new System.Drawing.Point(126, 93);
            this.BV_pointsGO.Name = "BV_pointsGO";
            this.BV_pointsGO.Size = new System.Drawing.Size(172, 41);
            this.BV_pointsGO.TabIndex = 3;
            this.BV_pointsGO.Text = "Result:";
            // 
            // BV_pointsGO2
            // 
            this.BV_pointsGO2.ForeColor = System.Drawing.Color.Brown;
            this.BV_pointsGO2.Location = new System.Drawing.Point(136, 145);
            this.BV_pointsGO2.Name = "BV_pointsGO2";
            this.BV_pointsGO2.Size = new System.Drawing.Size(145, 42);
            this.BV_pointsGO2.TabIndex = 2;
            this.BV_pointsGO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BV_closeGame
            // 
            this.BV_closeGame.BackColor = System.Drawing.Color.Crimson;
            this.BV_closeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV_closeGame.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_closeGame.Location = new System.Drawing.Point(57, 202);
            this.BV_closeGame.Name = "BV_closeGame";
            this.BV_closeGame.Size = new System.Drawing.Size(115, 78);
            this.BV_closeGame.TabIndex = 1;
            this.BV_closeGame.Text = "Close Game";
            this.BV_closeGame.UseVisualStyleBackColor = false;
            this.BV_closeGame.Click += new System.EventHandler(this.BV_closeGame_Click);
            // 
            // BV_lblGameOver
            // 
            this.BV_lblGameOver.AutoSize = true;
            this.BV_lblGameOver.ForeColor = System.Drawing.Color.Brown;
            this.BV_lblGameOver.Location = new System.Drawing.Point(95, 40);
            this.BV_lblGameOver.Name = "BV_lblGameOver";
            this.BV_lblGameOver.Size = new System.Drawing.Size(216, 41);
            this.BV_lblGameOver.TabIndex = 0;
            this.BV_lblGameOver.Text = "Game Over";
            // 
            // BV_BossStart
            // 
            this.BV_BossStart.Tick += new System.EventHandler(this.BV_BossStart_Tick);
            // 
            // BV_pic1
            // 
            this.BV_pic1.Image = ((System.Drawing.Image)(resources.GetObject("BV_pic1.Image")));
            this.BV_pic1.Location = new System.Drawing.Point(207, 104);
            this.BV_pic1.Name = "BV_pic1";
            this.BV_pic1.Size = new System.Drawing.Size(203, 308);
            this.BV_pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BV_pic1.TabIndex = 5;
            this.BV_pic1.TabStop = false;
            // 
            // BV_pic2
            // 
            this.BV_pic2.Image = ((System.Drawing.Image)(resources.GetObject("BV_pic2.Image")));
            this.BV_pic2.Location = new System.Drawing.Point(545, 192);
            this.BV_pic2.Name = "BV_pic2";
            this.BV_pic2.Size = new System.Drawing.Size(189, 205);
            this.BV_pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BV_pic2.TabIndex = 8;
            this.BV_pic2.TabStop = false;
            // 
            // BV_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BV_GameOver);
            this.Controls.Add(this.BV_pic2);
            this.Controls.Add(this.BV_pic1);
            this.Controls.Add(this.BV_Box1);
            this.Controls.Add(this.BV_bullet);
            this.Controls.Add(this.BV_ufo2);
            this.Controls.Add(this.BV_ufo3);
            this.Controls.Add(this.BV_ufo1);
            this.Controls.Add(this.BV_Hero1);
            this.Controls.Add(this.BV_btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BV_Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.BV_Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BV_Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BV_Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BV_Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_Hero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_ufo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_bullet)).EndInit();
            this.BV_Box1.ResumeLayout(false);
            this.BV_Box1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_lives1)).EndInit();
            this.BV_GameOver.ResumeLayout(false);
            this.BV_GameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BV_pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BV_pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer BV_timerLeft;
        private System.Windows.Forms.Timer BV_timerRight;
        private System.Windows.Forms.Timer BV_timerUP;
        private System.Windows.Forms.Timer BV_timerDown;
        private System.Windows.Forms.Timer BV_u1;
        private System.Windows.Forms.PictureBox BV_ufo3;
        private System.Windows.Forms.Button BV_btnStart;
        private System.Windows.Forms.PictureBox BV_ufo2;
        private System.Windows.Forms.PictureBox BV_Hero1;
        private System.Windows.Forms.PictureBox BV_ufo1;
        private System.Windows.Forms.Timer BV_bullets;
        private System.Windows.Forms.PictureBox BV_bullet;
        private System.Windows.Forms.GroupBox BV_Box1;
        private System.Windows.Forms.Label BV_txtpoint;
        private System.Windows.Forms.Label BV_points;
        private System.Windows.Forms.PictureBox BV_lives2;
        private System.Windows.Forms.PictureBox BV_lives3;
        private System.Windows.Forms.PictureBox BV_lives1;
        private System.Windows.Forms.Panel BV_GameOver;
        private System.Windows.Forms.Button BV_closeGame;
        private System.Windows.Forms.Label BV_lblGameOver;
        private System.Windows.Forms.Label BV_pointsGO;
        private System.Windows.Forms.Label BV_pointsGO2;
        private System.Windows.Forms.Button BV_reload;
        private System.Windows.Forms.Timer BV_BossStart;
        private System.Windows.Forms.PictureBox BV_pic1;
        private System.Windows.Forms.PictureBox BV_pic2;
    }
}

