using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Victor_Barkalov_KTA22V_Game
{
    public partial class BV_Win : Form
    {
        public BV_Win(string labelValue)
        {
            InitializeComponent();
            BV_points.Text = labelValue; // perenos kol-va ochkov s pervogo polja
        }
        public BV_Win()
        {
            InitializeComponent();

        }
        private void BV_closeGame_Click(object sender, EventArgs e) // knopka zakritj igru
        { 
                Application.Exit();     
        }

        private void BV_reload3_Click(object sender, EventArgs e) //knopra perezapuska igri
        {
            BV_Form1 form = new BV_Form1();
            form.Show();
            this.Hide();
        }
    }
}
