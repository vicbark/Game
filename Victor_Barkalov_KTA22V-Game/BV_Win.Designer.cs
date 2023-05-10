namespace Victor_Barkalov_KTA22V_Game
{
    partial class BV_Win
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
            this.BV_win1 = new System.Windows.Forms.Panel();
            this.BV_reload3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BV_points = new System.Windows.Forms.Label();
            this.BV_closeGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BV_win1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BV_win1
            // 
            this.BV_win1.BackColor = System.Drawing.Color.DodgerBlue;
            this.BV_win1.Controls.Add(this.BV_reload3);
            this.BV_win1.Controls.Add(this.label1);
            this.BV_win1.Controls.Add(this.BV_points);
            this.BV_win1.Controls.Add(this.BV_closeGame);
            this.BV_win1.Controls.Add(this.label3);
            this.BV_win1.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_win1.Location = new System.Drawing.Point(212, 83);
            this.BV_win1.Name = "BV_win1";
            this.BV_win1.Size = new System.Drawing.Size(555, 376);
            this.BV_win1.TabIndex = 24;
            // 
            // BV_reload3
            // 
            this.BV_reload3.BackColor = System.Drawing.Color.LimeGreen;
            this.BV_reload3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV_reload3.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_reload3.Location = new System.Drawing.Point(331, 243);
            this.BV_reload3.Name = "BV_reload3";
            this.BV_reload3.Size = new System.Drawing.Size(115, 78);
            this.BV_reload3.TabIndex = 4;
            this.BV_reload3.Text = "New Game";
            this.BV_reload3.UseVisualStyleBackColor = false;
            this.BV_reload3.Click += new System.EventHandler(this.BV_reload3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            // 
            // BV_points
            // 
            this.BV_points.ForeColor = System.Drawing.Color.Brown;
            this.BV_points.Location = new System.Drawing.Point(110, 153);
            this.BV_points.Name = "BV_points";
            this.BV_points.Size = new System.Drawing.Size(342, 62);
            this.BV_points.TabIndex = 2;
            this.BV_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BV_closeGame
            // 
            this.BV_closeGame.BackColor = System.Drawing.Color.Crimson;
            this.BV_closeGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BV_closeGame.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BV_closeGame.Location = new System.Drawing.Point(117, 243);
            this.BV_closeGame.Name = "BV_closeGame";
            this.BV_closeGame.Size = new System.Drawing.Size(115, 78);
            this.BV_closeGame.TabIndex = 1;
            this.BV_closeGame.Text = "Close Game";
            this.BV_closeGame.UseVisualStyleBackColor = false;
            this.BV_closeGame.Click += new System.EventHandler(this.BV_closeGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(186, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "You win";
            // 
            // BV_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BV_win1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BV_Win";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BV_win1.ResumeLayout(false);
            this.BV_win1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BV_win1;
        private System.Windows.Forms.Button BV_reload3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BV_points;
        private System.Windows.Forms.Button BV_closeGame;
        private System.Windows.Forms.Label label3;
    }
}