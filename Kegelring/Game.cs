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
            Robot.Image = rbmp;
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
        static string sec;
    
        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Robot.Location = new Point(320, 331);
            K1.Location = new Point(330, 146);
            K2.Location = new Point(467, 208);
            K3.Location = new Point(527, 341);
            K4.Location = new Point(467, 487);
            K5.Location = new Point(330, 543);
            K6.Location = new Point(193, 487);
            K7.Location = new Point(133, 341);
            K8.Location = new Point(193, 208);
            m = 2;
            s = 0;
            timer.Enabled = true;
            rtimer.Enabled = true;
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
                if (s < 10)
                    sec = "0" + s.ToString();
                else
                    sec = s.ToString();
                time.Text = m.ToString() + ":" + sec;
                if(m == 0 && s == 0)
                {
                    timer.Enabled = false;
                    rtimer.Enabled = false;
                    MessageBox.Show("Игра окончена", "Врёмя вышло");
                }
            });
        }

        static int X;
        static int Y;
        static int XR;
        static int YB;
        static int speed = 5;
        private void rtimer_Tick(object sender, EventArgs e)
        {
            X = Robot.Location.X;
            Y = Robot.Location.Y;
            if(X > 500)
                X = 101;
            else if(X > 100 && X < 501)
                //X += speed;
            if (X > 500)
                Y = 101;
            else if (Y > 100 && Y < 501)
                Y -= speed;
            Robot.Location = new Point(X, Y);
        }

        private void time_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Robot.Location.ToString());
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                стартToolStripMenuItem_Click(стартToolStripMenuItem, null);
            }
            if (e.KeyCode == Keys.Up)
            {
                //speed++;
                Robot.Location = new Point(Robot.Location.X, Robot.Location.Y - speed);
            }
            if (e.KeyCode == Keys.Down)
            {
                Robot.Location = new Point(Robot.Location.X, Robot.Location.Y + speed);
                //speed--;
            }
            if (e.KeyCode == Keys.Left)
            {
                Robot.Location = new Point(Robot.Location.X - speed, Robot.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                Robot.Location = new Point(Robot.Location.X + speed, Robot.Location.Y);
            }
            if (e.KeyCode == Keys.Space)
            {
                timer.Enabled = false;
                rtimer.Enabled = false;
                Clipboard.SetText(Robot.Location.X.ToString() + ", " + Robot.Location.Y.ToString());
                MessageBox.Show(Robot.Location.X.ToString() + "; " + Robot.Location.Y.ToString() + "\n" + in2);
                //MessageBox.Show($"Робот: {X} ; {Y}\n" +
                //                $"Кегля: {K4.Location.X.ToString()} ; {K4.Location.Y.ToString()}");
            }
        }

        static int x1, x2, x3, x4, x5, x6, x7, x8, y1, y2, y3, y4, y5, y6, y7, y8;

        private void K8_Move(object sender, EventArgs e)
        {
            if (K8.Location.X > 220 && K8.Location.Y > 260)
                in8 = true;
            else
                in8 = false;
        }

        private void K7_Move(object sender, EventArgs e)
        {
            if (K7.Location.X < 94)
                in7 = true;
            else
                in7 = false;
        }

        private void K6_Move(object sender, EventArgs e)
        {
            if (K6.Location.X < 250 && K6.Location.Y > 475)
                in6 = true;
            else
                in6 = false;
        }

        private void K5_Move(object sender, EventArgs e)
        {
            if (K5.Location.Y > 620)
                in5 = true;
            else
                in5 = false;
        }

        private void K4_Move(object sender, EventArgs e)
        {
            if (K4.Location.X > 450 && K4.Location.Y > 470 && K4.Location.X < 550 && K4.Location.Y < 570)
                in4 = true;
            else
                in4 = false;
        }

        private void K3_Move(object sender, EventArgs e)
        {
            if (K3.Location.X > 520 && K3.Location.X < 620 && K3.Location.Y > 300 && K3.Location.Y < 400)
                in3 = true;
            else
                in3 = false;
        }

        private void K2_Move(object sender, EventArgs e)
        {
            if (K2.Location.X > 450 && K2.Location.X < 550 && K2.Location.Y < 220 && K2.Location.Y > 120)
                in2 = true;
            else
                in2 = false;
        }

        private void K1_Move(object sender, EventArgs e)
        {
            if (K1.Location.Y > 65 && K1.Location.Y < 165 && K1.Location.X > 300 && K1.Location.X < 400)
                in1 = true;
            else
                in1 = false;
        }

        static bool in1 = true, in2 = true, in3 = true, in4 = true, in5 = true, in6 = true, in7 = true, in8 = true;
        private void Robot_Move(object sender, EventArgs e)
        {
            X = Robot.Location.X;
            Y = Robot.Location.Y;
            XR = X + 60;
            YB = Y + 60;
            if (in1 == true && Y < 180 && X > 260 && X < 380)
            {
                K1.Location = new Point(K1.Location.X, K1.Location.Y - speed);
            }
            if (in2 == true && XR > 470 && Y < 245)
            {
                K2.Location = new Point(K2.Location.X + speed, K2.Location.Y - speed);
            }
            if (in3 == true && XR > 530 && YB > 335 && Y < 380)
            {
                K3.Location = new Point(K3.Location.X + speed, K3.Location.Y);
            }
            if (in4 == true && XR > 467 && YB > 487)
            {
                K4.Location = new Point(K4.Location.X + speed, K4.Location.Y + speed);
            }
        }
    }
}
//Обнаружение краёв поля и возвращение обратно
//Обнаружение кеглей В КРУГЕ
//выталкивание их, что бы они были на 1 слое

