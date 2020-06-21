using System.Windows.Forms;

namespace Kegelring
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Robot = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.rtimer = new System.Windows.Forms.Timer(this.components);
            this.K1 = new System.Windows.Forms.PictureBox();
            this.K2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K2)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(0, 32);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1018, 1012);
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.заногоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1018, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(75, 32);
            this.стартToolStripMenuItem.Text = "Старт";
            this.стартToolStripMenuItem.Click += new System.EventHandler(this.стартToolStripMenuItem_Click);
            // 
            // заногоToolStripMenuItem
            // 
            this.заногоToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.заногоToolStripMenuItem.Name = "заногоToolStripMenuItem";
            this.заногоToolStripMenuItem.Size = new System.Drawing.Size(133, 32);
            this.заногоToolStripMenuItem.Text = "Переиграть";
            this.заногоToolStripMenuItem.Click += new System.EventHandler(this.заногоToolStripMenuItem_Click);
            // 
            // Robot
            // 
            this.Robot.BackColor = System.Drawing.Color.Tan;
            this.Robot.Location = new System.Drawing.Point(470, 510);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(60, 60);
            this.Robot.TabIndex = 3;
            this.Robot.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.time.Location = new System.Drawing.Point(474, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(71, 32);
            this.time.TabIndex = 4;
            this.time.Text = "0:00";
            // 
            // rtimer
            // 
            this.rtimer.Interval = 1;
            this.rtimer.Tick += new System.EventHandler(this.rtimer_Tick);
            // 
            // K1
            // 
            this.K1.BackColor = System.Drawing.Color.Transparent;
            this.K1.Location = new System.Drawing.Point(304, 84);
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(101, 78);
            this.K1.TabIndex = 5;
            this.K1.TabStop = false;
            // 
            // K2
            // 
            this.K2.BackColor = System.Drawing.Color.Transparent;
            this.K2.Location = new System.Drawing.Point(657, 190);
            this.K2.Name = "K2";
            this.K2.Size = new System.Drawing.Size(476, 926);
            this.K2.TabIndex = 6;
            this.K2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 1044);
            this.Controls.Add(this.K2);
            this.Controls.Add(this.K1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Robot);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заногоToolStripMenuItem;
        private System.Windows.Forms.PictureBox Robot;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer rtimer;
        private System.Windows.Forms.PictureBox K1;
        private System.Windows.Forms.PictureBox K2;
    }
}