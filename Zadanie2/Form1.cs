using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point;
            point = label1.Location;
            point.Offset(label1.Width / 2, label1.Height / 2);
            Cursor.Position = PointToScreen (point);
        }

        private void finish_game()
        {
            DialogResult dr =MessageBox.Show("Вы проиграли, попробуете снова?", "проигрыш",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            { 
                start_game();
                Application.Restart();
            }
            else
            {
                Environment.Exit(0);
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            start_game();
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ты прошел игру");
            this.Hide();
        }



        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {

        }

        private void coin1_MouseEnter(object sender, EventArgs e)
        {
            coin1.Visible = false;
            door1.Visible = false;
        }

        private void coin2_MouseEnter(object sender, EventArgs e)
        {
            coin2.Visible = false;
            door2.Visible = false;
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
