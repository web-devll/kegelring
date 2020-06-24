using System;
using System.Diagnostics;
using System.Drawing;
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
                speed = 1;
            }
            else if(wheels == 2)
            {
                robot.FillRectangle(black_brush, 0, 0, 13, 20);
                robot.FillRectangle(black_brush, 0, 40, 13, 20);
                robot.FillRectangle(black_brush, 47, 0, 13, 20);
                robot.FillRectangle(black_brush, 47, 40, 13, 20);
                speed = 2;
            }
            else
            {
                robot.FillRectangle(black_brush, 0, 0, 16, 25);
                robot.FillRectangle(black_brush, 0, 35, 16, 25);
                robot.FillRectangle(black_brush, 44, 0, 16, 25);
                robot.FillRectangle(black_brush, 44, 35, 16, 25);
                speed = 3;
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
            стартToolStripMenuItem_Click(стартToolStripMenuItem, null);
            F1.Show();
        }

        static int m = 2;
        static int s = 0;
        static string sec;
    
        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            in1 = true;
            in2 = true;
            in3 = true;
            in4 = true;
            in5 = true;
            in6 = true;
            in7 = true;
            in8 = true;
            gocenter = false;
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
                if (in8 == false & in1 == false & in2 == false & in3 == false & in4 == false & in5 == false & in6 == false & in7 == false)
                {
                    timer.Enabled = false;
                    rtimer.Enabled = false;
                    MessageBox.Show($"Поздравляю, твой робот вытолкнул все кегли, твоё время 0:{60 - Convert.ToDouble(sec)}", "Игра окончена");
                }
                if (s == 0)
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
                    MessageBox.Show("К сожалению время кончилось, попобуй заново", "Врёмя вышло");
                }
            });
        }

        static int X;
        static int Y;
        static int XR;
        static int YB;
        static int speed = 2;
        static bool gocenter = false;
        private void rtimer_Tick(object sender, EventArgs e)
        {
            X = Robot.Location.X;
            Y = Robot.Location.Y;
            XR = X + 60;
            YB = Y + 60;
            if (Y < 334 & Y > 326 & X > 315 & X < 323)
                gocenter = false;
            if (gocenter == true)
            {
                if (X < 316)
                    X += speed;
                if (X > 322)
                    X -= speed;
                if (Y < 327)
                    Y += speed;
                if (Y > 333)
                    Y -= speed;
            }
            if (in1 == true & gocenter == false & Y > 85)
            {
                Y -= speed;
            }
            if(in1 == false & in2 == true & gocenter == false)
            {
                X += speed;
                Y -= speed;
            }
            if (in2 == false & in3 == true & gocenter == false)
            {
                X += speed;
            }
            if (in3 == false & in4 == true & gocenter == false)
            {
                X += speed;
                Y += speed;
            }
            if (in4 == false & in5 == true & gocenter == false)
            {
                Y += speed;
            }
            if (in5 == false & in6 == true & gocenter == false)
            {
                X -= speed;
                Y += speed;
            }
            if (in6 == false & in7 == true & gocenter == false)
            {
                X -= speed;
            }
            if (in7 == false & in8 == true & gocenter == false)
            {
                X -= speed;
                Y -= speed;
            }                    
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
        }


        private void K8_Move(object sender, EventArgs e)
        {
            if (K8.Location.X < 255 && K8.Location.Y < 265 && K8.Location.X > 110 && K8.Location.Y > 110)
                in8 = true;
            else
            {
                in8 = false;
                gocenter = true;
            }
        }

        private void K7_Move(object sender, EventArgs e)
        {
            if (K7.Location.X < 195 && K7.Location.Y < 400 && K7.Location.X > 40 && K7.Location.Y > 320)
                in7 = true;
            else
            {
                in7 = false;
                gocenter = true;
            }
        }

        private void K6_Move(object sender, EventArgs e)
        {
            if (K6.Location.X < 255 && K6.Location.X > 100 && K6.Location.Y > 465 && K6.Location.Y < 565)
                in6 = true;
            else
            {
                in6 = false;
                gocenter = true;
            }
        }

        private void K5_Move(object sender, EventArgs e)
        {
            if (K5.Location.Y > 530 && K5.Location.Y < 630 && K5.Location.X > 315 && K5.Location.X < 415)
                in5 = true;
            else
            {
                in5 = false;
                gocenter = true;
            }
        }

        private void K4_Move(object sender, EventArgs e)
        {
            if (K4.Location.X > 450 && K4.Location.Y > 470 && K4.Location.X < 550 && K4.Location.Y < 570)
                in4 = true;
            else
            {
                in4 = false;
                gocenter = true;
            }
        }

        private void K3_Move(object sender, EventArgs e)
        {
            if (K3.Location.X > 520 && K3.Location.X < 620 && K3.Location.Y > 300 && K3.Location.Y < 400)
                in3 = true;
            else
            {
                in3 = false;
                gocenter = true;
            }
        }

        private void K2_Move(object sender, EventArgs e)
        {
            if (K2.Location.X > 450 && K2.Location.X < 550 && K2.Location.Y < 220 && K2.Location.Y > 120)
                in2 = true;
            else
            {
                in2 = false;
                gocenter = true;
            }
        }

        private void K1_Move(object sender, EventArgs e)
        {
            if (K1.Location.Y > 55 && K1.Location.Y < 165 && K1.Location.X > 300 && K1.Location.X < 400)
                in1 = true;
            else
            {
                in1 = false;
                gocenter = true;
            }
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
            if (in2 == true && XR > 467 && Y < 245)
            {
                K2.Location = new Point(K2.Location.X + speed, K2.Location.Y - speed);
            }
            if (in3 == true && XR > 530 && YB > 335 && Y < 380)
            {
                K3.Location = new Point(K3.Location.X + speed, K3.Location.Y);
            }
            if (in4 == true && XR > 467 && YB > 485)
            {
                K4.Location = new Point(K4.Location.X + speed, K4.Location.Y + speed);
            }
            if (in5 == true && XR > 330 && X < 370 && YB > 550)
            {
                K5.Location = new Point(K5.Location.X, K5.Location.Y + speed);
            }
            if (in6 == true && X < 230 && YB > 492)
            {
                K6.Location = new Point(K6.Location.X - speed, K6.Location.Y + speed);
            }
            if (in7 == true && X < 170 && Y < 380 && Y > 285)
            {
                K7.Location = new Point(K7.Location.X - speed, K7.Location.Y);
            }
            if (in8 == true && X < 235 && Y < 245)
            {
                K8.Location = new Point(K8.Location.X - speed, K8.Location.Y - speed);
            }
        }
    }
}