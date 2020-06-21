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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.rtimer = new System.Windows.Forms.Timer(this.components);
            this.K1 = new System.Windows.Forms.PictureBox();
            this.Robot = new System.Windows.Forms.PictureBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.K8 = new System.Windows.Forms.PictureBox();
            this.K7 = new System.Windows.Forms.PictureBox();
            this.K6 = new System.Windows.Forms.PictureBox();
            this.K5 = new System.Windows.Forms.PictureBox();
            this.K4 = new System.Windows.Forms.PictureBox();
            this.K3 = new System.Windows.Forms.PictureBox();
            this.K2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K2)).BeginInit();
            this.SuspendLayout();
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
            // timer
            // 
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
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // rtimer
            // 
            this.rtimer.Interval = 1;
            this.rtimer.Tick += new System.EventHandler(this.rtimer_Tick);
            // 
            // K1
            // 
            this.K1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K1.Image = global::Kegelring.Properties.Resources.keglya;
            this.K1.Location = new System.Drawing.Point(495, 225);
            this.K1.Margin = new System.Windows.Forms.Padding(0);
            this.K1.Name = "K1";
            this.K1.Size = new System.Drawing.Size(60, 60);
            this.K1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K1.TabIndex = 6;
            this.K1.TabStop = false;
            // 
            // Robot
            // 
            this.Robot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Robot.Location = new System.Drawing.Point(480, 510);
            this.Robot.Name = "Robot";
            this.Robot.Size = new System.Drawing.Size(60, 60);
            this.Robot.TabIndex = 3;
            this.Robot.TabStop = false;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(0, 32);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1018, 1012);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // K8
            // 
            this.K8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K8.Image = global::Kegelring.Properties.Resources.keglya;
            this.K8.Location = new System.Drawing.Point(290, 320);
            this.K8.Margin = new System.Windows.Forms.Padding(0);
            this.K8.Name = "K8";
            this.K8.Size = new System.Drawing.Size(60, 60);
            this.K8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K8.TabIndex = 8;
            this.K8.TabStop = false;
            // 
            // K7
            // 
            this.K7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K7.Image = global::Kegelring.Properties.Resources.keglya;
            this.K7.Location = new System.Drawing.Point(200, 525);
            this.K7.Margin = new System.Windows.Forms.Padding(0);
            this.K7.Name = "K7";
            this.K7.Size = new System.Drawing.Size(60, 60);
            this.K7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K7.TabIndex = 9;
            this.K7.TabStop = false;
            // 
            // K6
            // 
            this.K6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K6.Image = global::Kegelring.Properties.Resources.keglya;
            this.K6.Location = new System.Drawing.Point(290, 750);
            this.K6.Margin = new System.Windows.Forms.Padding(0);
            this.K6.Name = "K6";
            this.K6.Size = new System.Drawing.Size(60, 60);
            this.K6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K6.TabIndex = 10;
            this.K6.TabStop = false;
            // 
            // K5
            // 
            this.K5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K5.Image = global::Kegelring.Properties.Resources.keglya;
            this.K5.Location = new System.Drawing.Point(495, 835);
            this.K5.Margin = new System.Windows.Forms.Padding(0);
            this.K5.Name = "K5";
            this.K5.Size = new System.Drawing.Size(60, 60);
            this.K5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K5.TabIndex = 11;
            this.K5.TabStop = false;
            // 
            // K4
            // 
            this.K4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K4.Image = global::Kegelring.Properties.Resources.keglya;
            this.K4.Location = new System.Drawing.Point(700, 750);
            this.K4.Margin = new System.Windows.Forms.Padding(0);
            this.K4.Name = "K4";
            this.K4.Size = new System.Drawing.Size(60, 60);
            this.K4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K4.TabIndex = 12;
            this.K4.TabStop = false;
            // 
            // K3
            // 
            this.K3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K3.Image = global::Kegelring.Properties.Resources.keglya;
            this.K3.Location = new System.Drawing.Point(790, 525);
            this.K3.Margin = new System.Windows.Forms.Padding(0);
            this.K3.Name = "K3";
            this.K3.Size = new System.Drawing.Size(60, 60);
            this.K3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K3.TabIndex = 13;
            this.K3.TabStop = false;
            // 
            // K2
            // 
            this.K2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.K2.Image = global::Kegelring.Properties.Resources.keglya;
            this.K2.Location = new System.Drawing.Point(700, 320);
            this.K2.Margin = new System.Windows.Forms.Padding(0);
            this.K2.Name = "K2";
            this.K2.Size = new System.Drawing.Size(60, 60);
            this.K2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.K2.TabIndex = 14;
            this.K2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 1044);
            this.Controls.Add(this.K2);
            this.Controls.Add(this.K3);
            this.Controls.Add(this.K4);
            this.Controls.Add(this.K5);
            this.Controls.Add(this.K6);
            this.Controls.Add(this.K7);
            this.Controls.Add(this.K8);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K3)).EndInit();
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
        private PictureBox K8;
        private PictureBox K7;
        private PictureBox K6;
        private PictureBox K5;
        private PictureBox K4;
        private PictureBox K3;
        private PictureBox K2;
    }
}