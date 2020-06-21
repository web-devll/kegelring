using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kegelring
{
    public partial class Tactics : Form
    {
        public Tactics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form F1 = new Start();
            F1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form F3 = new Сustomization(3);
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form F3 = new Сustomization(2);
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form F3 = new Сustomization(1);
            F3.Show();
        }
    }
}
