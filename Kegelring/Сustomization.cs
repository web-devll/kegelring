using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Kegelring
{
    public partial class Сustomization : Form
    {
        static byte tactic = 1;
        static byte wheels = 1;
        static Color RobotColor = Color.Black;
        public Сustomization() : this(1)
        {
        }
        public Сustomization(byte t)
        {
            tactic = t;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form F4 = new Game(tactic, wheels, RobotColor);
            F4.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            RobotColor = colorDialog1.Color;
            button3.BackColor = RobotColor;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Маленький")
                wheels = 1;
            if (comboBox1.Text == "Средний")
                wheels = 2;
            if (comboBox1.Text == "Большой")
                wheels = 3;
        }
    }
}
