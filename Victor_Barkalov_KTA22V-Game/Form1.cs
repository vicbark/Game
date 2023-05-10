using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Victor_Barkalov_KTA22V_Game
{

    public partial class BV_Form1 : Form
    {
        int playerSpeed;
        int points;
        int lives;

        Random rnd = new Random();
        Form F1 = new BV_Form2(); //dlja perehoda na vtoruju formu s bossom




        public BV_Form1()
        {
            InitializeComponent();


            // Создание таймера
            BV_BossStart = new Timer();
            BV_BossStart.Interval = 35000; // vkljuchaem taimer, posle chego vkljuchitsja boss
            BV_BossStart.Tick += new EventHandler(BV_BossStart_Tick);

        }

        private void BV_Form1_Load(object sender, EventArgs e)
        {

            playerSpeed = 5; // skorostj dvizenija samoleta pri nazatii strelki
            points = 0; // iznachaljnoe kolichestvo ochkov
            lives = 3; //kolichestvo zhiznej geroja

        }


        private void BV_timerLeft_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Left > 10) // ogranichenie, chtob ne viletal za kroja
            {
                BV_Hero1.Left -= playerSpeed;
            }
        }

        private void BV_timerRight_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Left < 600)
            {
                BV_Hero1.Left += playerSpeed;
            }
        }

        private void BV_timerUP_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Top > 90)
            {
                BV_Hero1.Top -= playerSpeed;
            }
        }

        private void BV_timerDown_Tick(object sender, EventArgs e)
        {
            if (BV_Hero1.Top < 370)
            {
                BV_Hero1.Top += playerSpeed;
            }
        }

        private void BV_Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // pri nazatii strelki kuda budet dvigatjsja
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

        private void BV_Form1_KeyUp(object sender, KeyEventArgs e)
        {
            BV_timerLeft.Stop(); //esli strelku otpuskaeshj, to perestaet dvigatjsja
            BV_timerRight.Stop();
            BV_timerUP.Stop();
            BV_timerDown.Stop();
        }


        private void BV_btnStart_Click(object sender, EventArgs e) //posle nazhatija knopki start
        {


            BV_ufo1.Location = new Point(rnd.Next(830, 830), rnd.Next(90, 160));//randomnaja visota ufo v predlah 90-160
            BV_ufo1.Enabled = true;
            BV_ufo1.Visible = true;

            BV_ufo2.Location = new Point(rnd.Next(830, 830), rnd.Next(200, 280));
            BV_ufo2.Enabled = true;
            BV_ufo2.Visible = true;

            BV_ufo3.Location = new Point(rnd.Next(830, 830), rnd.Next(320, 380));
            BV_ufo3.Enabled = true;
            BV_ufo3.Visible = true;



            BV_btnStart.Visible = false;
            BV_btnStart.Enabled = false;
            BV_pic1.Visible = false;
            BV_pic1.Enabled = false;
            BV_pic2.Visible = false;
            BV_pic2.Enabled = false;
            BV_Hero1.Visible = true;
            BV_Hero1.Enabled = true;
            BV_u1.Enabled = true;
            BV_lives1.Visible = true;
            BV_lives2.Visible = true;
            BV_lives3.Visible = true;
            BV_Box1.Enabled = true;
            BV_Box1.Visible = true;
            BV_BossStart.Start();
            BV_BossStart.Enabled = true;
        }

        private void BV_u1_Tick(object sender, EventArgs e)

        {
            int uSpeed = rnd.Next(3, 8); //randomnaja skorostj ufo
            PictureBox[] pictureBoxes = new PictureBox[] { BV_ufo1, BV_ufo2, BV_ufo3, }; //massiv kartinok ufo
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Left -= uSpeed;//skorostj poleta dlja ufo
            }
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if ((pictureBox.Left < 0) || BV_Hero1.Bounds.IntersectsWith(pictureBox.Bounds)) //esli ufo uletelo za krai ili stolknulosj s geroem
                {
                    points = points - 1; //esli ufo proletelo, to minus ochko
                    BV_points.Text = Convert.ToString(points); //novoe kolichestvo ochkov

                }
                if (BV_Hero1.Bounds.IntersectsWith(pictureBox.Bounds)) //posle stolknovenija geroja i ufo umenjshaetsja kol-vo zhiznej
                {
                    lives = lives - 1;
                    if (lives == 2)
                    { BV_lives3.Visible = false; }
                    if (lives == 1)
                    { BV_lives2.Visible = false; }
                    if (lives == 0) //esli zhiznej ostalosj 0
                    {
                        BV_ufo1.Enabled = false;
                        BV_ufo1.Visible = false;
                        BV_ufo2.Enabled = false;
                        BV_ufo2.Visible = false;
                        BV_ufo3.Enabled = false;
                        BV_ufo3.Visible = false;
                        BV_lives1.Visible = false;
                        BV_GameOver.Enabled = true;
                        BV_GameOver.Visible = true;
                        BV_Box1.Visible = false;
                        BV_Box1.Enabled = false;

                        BV_BossStart.Stop(); // otkljuchaem taimer starta bossa
                        BV_Hero1.Visible = false;
                        BV_Hero1.Enabled = false;
                        BV_u1.Enabled = false;
                        BV_bullet.Enabled = false;
                        BV_bullet.Visible = false;
                        BV_pointsGO2.Text = Convert.ToString(points); // otobrazaem kolichaestvo nabrannih ochkov
                    }
                }

            }

            if ((BV_ufo1.Left < 0) || (BV_Hero1.Bounds.IntersectsWith(BV_ufo1.Bounds)))//esli ufo doletel do kraja ili stolknulsja s geroem, to pojavljaetsja zanovo
            {
                BV_ufo1.Location = new Point(rnd.Next(830, 830), rnd.Next(90, 160));
            }

            if ((BV_ufo2.Left < 0) || (BV_Hero1.Bounds.IntersectsWith(BV_ufo2.Bounds)))
            {
                BV_ufo2.Location = new Point(rnd.Next(830, 830), rnd.Next(200, 280));

            }

            if ((BV_ufo3.Left < 0) || (BV_Hero1.Bounds.IntersectsWith(BV_ufo3.Bounds)))//esli ufo doletel do kraja ili stolknulsja s geroem, to pojavljaetsja zanovo
            {
                BV_ufo3.Location = new Point(rnd.Next(830, 830), rnd.Next(320, 380));
            }


        }

        private void BV_bullets_Tick(object sender, EventArgs e)
        {


            BV_bullet.Left = BV_bullet.Left + 16; //dvizenie puli



                if (BV_bullet.Bounds.IntersectsWith(BV_ufo1.Bounds)) // esli pulja popala v ufo
                {
                    BV_ufo1.Location = new Point(rnd.Next(830, 830), rnd.Next(90, 160)); //nachinaet letetj zanovo s randomnoj tochki
                    BV_bullet.Enabled = false;
                    BV_bullet.Visible = false;
                    BV_bullets.Enabled = false;

                    points = points + 1; //za sbitij ufo +ocko
                    BV_points.Text = Convert.ToString(points);  //otobrazaem novoe kolichestvo ochkov
                }

            if (BV_bullet.Bounds.IntersectsWith(BV_ufo2.Bounds)) // pri stolknovenii puli i ufo2
            {
                BV_ufo2.Location = new Point(rnd.Next(830, 830), rnd.Next(200, 280)); //nachinaet letetj zanovo s randomnoj tochki
                BV_bullet.Enabled = false;
                BV_bullet.Visible = false;
                BV_bullets.Enabled = false;

                    points = points + 1;//za sbitij ufo +ocko
                    BV_points.Text = Convert.ToString(points);//novoe kolichestvo ochkov

            }
            if (BV_bullet.Bounds.IntersectsWith(BV_ufo3.Bounds)) // pri stolknovenii puli i ufo3
            {
                BV_ufo3.Location = new Point(rnd.Next(830, 830), rnd.Next(320, 380)); //nachinaet letetj zanovo s randomnoj tochki
                BV_bullet.Enabled = false;
                BV_bullet.Visible = false;
                BV_bullets.Enabled = false;

                 
                points = points + 1; //za sbitij ufo +ocko
                BV_points.Text = Convert.ToString(points);//novoe kolichestvo ochkov// Код, который увеличивает значение счетчика

            }

            if (BV_bullet.Location.X > 600) //esli pulja uletela
            {
                BV_bullet.Enabled = false;
            }

        }

        private void BV_Form1_MouseClick(object sender, MouseEventArgs e) 
        {
            if ((BV_bullet.Enabled == false) & (BV_btnStart.Enabled == false) & (BV_GameOver.Enabled == false)) //esli pulja ne letit, knopka start nazata i gameover ne aktivno

            {
                BV_bullets.Enabled = true;

                BV_bullet.Enabled = true;
                BV_bullet.Visible = true;
                BV_bullet.Location = new Point(BV_Hero1.Location.X, BV_Hero1.Location.Y + 18); //otkuda letit raketa
            }

        }

        private void BV_reload_Click(object sender, EventArgs e) //novaja igra - zapuskaem zanovo formu
        {
            BV_Form1 form = new BV_Form1(); //perezagruzaem formu
            form.Show();
            this.Hide();

        }
        private void BV_closeGame_Click(object sender, EventArgs e)// zakrivaem polnostju, tak kak,esli nazimalasj
                                                                   // novaja igra, to starie formi bili sprjatani i  ih nado
                                                                   //toze zakritj
        {
            Application.Exit();
        }

        private void BV_BossStart_Tick(object sender, EventArgs e) //pojavlenie bosa (novaja forma)
        {
            BV_u1.Stop();

            this.Hide();
            F1 = new BV_Form2(BV_points.Text); //perenosim kolichestvo ochkov na pole s bossom
            
            F1.Visible = true;

            F1.Activate();
            BV_BossStart.Stop(); // ostanavlivaem taimer, chtobi pojavilasj toljko odna forma


        }
    }
}
