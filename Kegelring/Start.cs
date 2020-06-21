using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kegelring
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F4 = new Game();
            F4.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F2 = new Tactics();
            F2.Show();
            Hide();
        }
    }
}
