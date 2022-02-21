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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uroven uus_aken = new uroven();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 uus_aken = new Form1();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь ты должен пройти лабиринт. Но не все так просто чтобы дайти до финиша ты должен открывать двери. Двери ты сможешь открыть с помощью ключа, ключи находятся в самом лабиринте P.S(они выглядят как желтые квадратики)", "информация о игре");
        }
    }
}
