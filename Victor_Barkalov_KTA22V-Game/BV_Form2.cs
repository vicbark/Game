using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victor_Barkalov_KTA22V_Game
{
    public partial class BV_Form2 : Form

    {
        int lives = 3; //zizni geroja
        int Blives = 0; //zizhi bossa
        
        bool bulletHit = false; //chtob] korrektno schitalo urovni zhizni bossa
        Form F2 = new BV_Win(); //dlja perehoda na formu vijgrisha

        public BV_Form2(string labelValue)
        {

            InitializeComponent();


            BV_points.Text = labelValue; // perenos kol-va ochkov s pervogo polja
            BV_pointsGO2.Text = labelValue; //kol-vo ochkov na tablicu pri proirishe
            BV_bossMove.Start(); //dvizenie bossa

            BV_boom.Start();
        }
        public BV_Form2()
        {
            InitializeComponent();



        }
        private void BV_boom_Tick(object sender, EventArgs e)
        {
            if (BV_bullet2.Left < 0) //esli pulja bossa uletela za krai, to letit zanovo ot bossa
            {
                {
                    BV_bullet2.Location = new Point(BV_Boss1.Location.X - 55, BV_Boss1.Location.Y + 40);

                }
            }

        }
        private void BV_timerLeft_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Left > 10) // ogranichenie, chtob geroj ne viletal za kroja
            {
                BV_Hero1.Left -= 5;
            }
        }

        private void BV_timerRight_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Left < 600)
            {
                BV_Hero1.Left += 5;
            }
        }

        private void BV_timerUP_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Top > 90)
            {
                BV_Hero1.Top -= 5;
            }
        }

        private void BV_timerDown_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Top < 370)
            {
                BV_Hero1.Top += 5;
            }
        }

        private void BV_Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // pri nazatii strelki kuda budet dvigatjsja geroj
            {
                BV_timerLeft.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                BV_timerRight.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                BV_timerUP.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                BV_timerDown.Start();
            }
        }

        private void BV_Form2_KeyUp(object sender, KeyEventArgs e)
        {
            BV_timerLeft.Stop(); //esli strelku otpuskaeshj, to geroj perestaet dvigatjsja
            BV_timerRight.Stop();
            BV_timerUP.Stop();
            BV_timerDown.Stop();
        }

        private void BV_Form2_MouseClick(object sender, MouseEventArgs e)
        {

            if ((BV_bullet.Enabled == false)) //esli pulja ne letit, chtobi ne obnovljatj letjwuju
            {
                BV_bullets.Enabled = true;

                BV_bullet.Enabled = true;
                BV_bullet.Visible = true;
                BV_bullet.Location = new Point(BV_Hero1.Location.X + 0, BV_Hero1.Location.Y + 18); //otkuda letit raketa
            }
        }

        private void BV_bullets_Tick(object sender, EventArgs e)
        {
            BV_bullet.Left = BV_bullet.Left + 16; //dvizenie puli


            if (BV_bullet.Location.X > 600) //esli pulja geroja uletela za kraj
            {
                BV_bullet.Enabled = false;
            }

            if (BV_bullet.Bounds.IntersectsWith(BV_Boss1.Bounds) && !bulletHit) //eli pulja geroja popala v bossa
            {
                BV_bullet.Location = new Point(BV_Hero1.Location.X + 0, BV_Hero1.Location.Y + 18); 
                BV_bullet.Visible = false;
                BV_bullet.Enabled = false;
                Blives = Blives + 1; //+1 v zhiznjah bossa za popadanie, schitaem ot 0

                bulletHit = true;
                    if (Blives==3)
                {
                    BV_livesB3.Visible = false;
                }
                    if (Blives == 6)
                {
                    BV_livesB2.Visible = false;
                }
                    if (Blives >= 9) //pri poslednih popadanijah v bossa
                {
                    this.Hide(); //prjachem formu

                    F2.Visible = true; //otkritie formi vijgrisha
                    F2 = new BV_Win(BV_points.Text); //perenosim kolichestvo ochkov na formu vijgrisha

                    F2.Visible = true;
                    F2.Activate();
                }
            }

            }

        private void BV_bossMove_Tick(object sender, EventArgs e)
        {
            BV_Boss1.Top += 5; //dvizenie bossa k kraju po Y
            if (BV_Boss1.Location.Y > 350)
            {
                BV_Boss1.Top -= 5;
                BV_bossMove.Stop();
                BV_bossMove2.Start();

            }


    }

        private void BV_bossMove2_Tick(object sender, EventArgs e)
        {
            BV_Boss1.Top -= 10; //boss ottalkivaetsja i dvizetsja k dr. kraju po Y
            if (BV_Boss1.Location.Y < 100)
            {

                BV_bossMove2.Stop();
                BV_bossMove.Start();
                bulletHit = false;
            }
        }

        private void BV_bullets2_Tick(object sender, EventArgs e) // boss streljaet
        {

            BV_bullet2.Left = BV_bullet2.Left - 5; //polet puli bossa

            if ((BV_Hero1.Bounds.IntersectsWith(BV_bullet2.Bounds)) || (BV_Hero1.Bounds.IntersectsWith(BV_Boss1.Bounds))) 
                //geroj stolknulsja s pulej bossa ili samim bossom, to umenjshaetsja kol-vo zhiznej geroja
            {
                BV_Hero1.Location = new Point(0, 200);
                BV_bullet2.Location = new Point(BV_Boss1.Location.X - 55, BV_Boss1.Location.Y + 40);

                lives = lives - 1;

                if (lives == 2)
                {
                    BV_lives3.Visible = false;
                }
                if (lives == 1)
                {
                    BV_lives2.Visible = false;
                }
                if (lives <= 0) //zhiznej u geroja ne ostalosj
                {
                    BV_lives1.Visible = false;
                    BV_GameOver.Enabled = true;
                    BV_GameOver.Visible = true;
                    BV_Boss1.Visible= false;
                    BV_Boss1.Enabled = false;
                    BV_Hero1.Visible= false;
                    BV_Hero1.Visible = false;
                    BV_bullet.Visible = false;
                    BV_bullet2.Visible= false;
                    BV_bossMove2.Stop();
                    BV_bossMove.Stop();
                    BV_bullets.Stop();
                    BV_bullets2.Stop();


                }

            }
    }

        private void BV_closeGame_Click(object sender, EventArgs e)//pri proigrishe knopka zakritj igru
        {
            Application.Exit();
        }

        private void BV_reload_Click(object sender, EventArgs e) //pri proigrishe knopka perezapustitj igru
        {
            BV_Form1 form = new BV_Form1();
            form.Show();
            this.Hide();

        }


    }
}

