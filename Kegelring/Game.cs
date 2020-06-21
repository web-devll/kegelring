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
    public partial class Game : Form
    {
        static byte tactic = 1;
        static byte wheels = 1;
        static Color RobotColor = Color.Red;
        public Game() : this(1)
        {
            InitializeComponent();
        }
        public Game(byte t)
        {
            tactic = t;
        }
        public Game(byte t, byte w)
        {
            tactic = t;
            wheels = w;
        }
        public Game(byte t, byte w, Color RC)
        {
            tactic = t;
            wheels = w;
            RobotColor = RC;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            K2.Image = Properties.Resources.cc;
            Pen bl = new Pen(Color.Black);
            SolidBrush black_brush = new SolidBrush(Color.Black);
            SolidBrush white_brush = new SolidBrush(Color.White);
            SolidBrush robot_brush = new SolidBrush(RobotColor);

            Bitmap bmp = new Bitmap(Picture.Height, Picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            graph.FillEllipse(black_brush, 80, 80, Picture.Height-140, Picture.Height - 140);
            graph.FillEllipse(white_brush, 100, 100, Picture.Height - 180, Picture.Height - 180);
            Picture.Image = bmp;

            Robot.Size = new Size(60, 60);
            //Robot.Width = 60;
            //Robot.Height = 60;
            Bitmap rbmp = new Bitmap(60, 60);
            Graphics robot = Graphics.FromImage(rbmp);
            if(wheels == 1)
            {
                robot.FillRectangle(black_brush, 0, 0, 10, 15);
                robot.FillRectangle(black_brush, 0, 45, 10, 15);
                robot.FillRectangle(black_brush, 50, 0, 10, 15);
                robot.FillRectangle(black_brush, 50, 45, 10, 15);
            }
            else if(wheels == 2)
            {
                robot.FillRectangle(black_brush, 0, 0, 13, 20);
                robot.FillRectangle(black_brush, 0, 40, 13, 20);
                robot.FillRectangle(black_brush, 47, 0, 13, 20);
                robot.FillRectangle(black_brush, 47, 40, 13, 20);
            }
            else
            {
                robot.FillRectangle(black_brush, 0, 0, 16, 25);
                robot.FillRectangle(black_brush, 0, 35, 16, 25);
                robot.FillRectangle(black_brush, 44, 0, 16, 25);
                robot.FillRectangle(black_brush, 44, 35, 16, 25);
            }
            robot.FillRectangle(robot_brush, 10, 10, 40, 40);
            //Robot.Image = rbmp;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void заногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Start F1 = new Start();
            F1.Show();
        }

            static int m = 2;
            static int s = 0;
        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Robot.Location = new Point(313, 331);
            m = 2;
            s = 0;
            timer.Enabled = true;
            rtimer.Enabled = true;
        }

        private void Game_SizeChanged(object sender, EventArgs e)
        {
            Picture.Size = new Size(Picture.Size.Width+1, Picture.Size.Width);
        }

        async void timer_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if(s == 0)
                {
                    m--;
                    s = 60;
                }
                s--;
                time.Text = m.ToString() + ":" + s.ToString();
                if(m == 0 && s == 0)
                {
                    timer.Enabled = false;
                    rtimer.Enabled = false;
                    MessageBox.Show("Игра окончена", "Врёмя вышло");
                }
            });
        }

        private void rtimer_Tick(object sender, EventArgs e)
        {
            int H = Robot.Location.X;
            int W = Robot.Location.Y;
            Robot.Location = new Point(H + 1, W + 1);
        }

    }
}
//Обнаружение краёв поля и возвращение обратно
//Обнаружение кеглей В КРУГЕ
//выталкивание их, что бы они были на 1 слое