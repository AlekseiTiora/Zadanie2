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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("здесь ты должен пройти лабиринты их здесь всего 2. Чтобы их пройти ты должен открывать двери, а открыть ты их можешь с помощью ключа(они выглядят как желтые квадратики)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 uus_aken = new Form1();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }
    }
}
