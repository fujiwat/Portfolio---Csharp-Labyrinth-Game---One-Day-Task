using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace midterm2
{

    public partial class Form1 : Form
    {
        static readonly string fileNameWithoutExtention = "scores";
        static readonly string SAVE_TXT_FILE_NAME = System.Reflection.Assembly.GetEntryAssembly().Location + @"\..\..\" + fileNameWithoutExtention + ".txt";
        Point StartPos;
        Boolean gameoverFlag = true;
        Stopwatch stopWatch = new Stopwatch();
        private Point[] labyPoint =
        {
            new Point {X=50,Y=50 },
            new Point {X=50, Y=500},
            new Point {X=500, Y=500},
            new Point {X=500, Y=50 },
            new Point {X=100, Y=50},
            new Point {X=100, Y=450},
            new Point {X=450, Y=450},
            new Point {X=450, Y=100},
            new Point {X=150, Y=100},
            new Point {X=150, Y=400},
            new Point {X=400, Y=400},
            new Point {X=400, Y=150},
            new Point {X=200, Y=150},
            new Point {X=200, Y=350},
            new Point {X=350, Y=350}
        };
        public void DrawLaby(Graphics f)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            //            PicSmile.Visible = false;
            f.DrawLines(blackPen, labyPoint);
            stopWatch.Start();
            PicSmile.Visible = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics f = this.CreateGraphics();
            StartPos.X = PicSmile.Left;
            StartPos.Y = PicSmile.Top;
            LblYourName.Visible = false;
            TxtYourName.Visible = false;
            lblTimer.Text = "";
            BtnOk.Visible = false;
            //            DrawLaby(f);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawLaby(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x, y;
            x = PicSmile.Location.X;
            y = PicSmile.Location.Y;
            int pitch = 10;

            if (gameoverFlag==true )
            {
               if ( e.KeyCode == Keys.Space)
               {   // game start
                    PicSmile.Top = StartPos.Y;
                    PicSmile.Left = StartPos.X;
                    timer1.Enabled = true;
                    gameoverFlag = false;
                    lblGameOver.Visible = false;
                    lblStart.Visible = false;
                    stopWatch.Stop();
                    stopWatch.Reset();
                    Stopwatch.StartNew();
               }
                return;
            }


            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (x < this.Size.Width - PicSmile.Width * 2 - pitch)
                    {
                        x += pitch;
                    }
                    PicSmile.Location = new System.Drawing.Point(x, y);
                    break;
                case Keys.Left:
                    if (x > pitch)
                    {
                        x -= pitch;
                    }
                    PicSmile.Location = new System.Drawing.Point(x, y);
                    break;
                case Keys.Up:
                    if (y > pitch)
                    {
                        y -= pitch;
                    }
                    PicSmile.Location = new System.Drawing.Point(x, y);
                    break;
                case Keys.Down:
                    if (y < this.Size.Height - PicSmile.Height * 3 - pitch)
                    {
                        y += pitch;
                    }
                    PicSmile.Location = new System.Drawing.Point(x, y);
                    break;
                default:
                    break;
            }
            this.Refresh();
            for (int i=0; i< labyPoint.Length-1; i++)
            {
                int x0 = Math.Min(labyPoint[i].X, labyPoint[i + 1].X);
                int x1 = Math.Max(labyPoint[i].X, labyPoint[i + 1].X);
                int y0 = Math.Min(labyPoint[i].Y, labyPoint[i + 1].Y);
                int y1 = Math.Max(labyPoint[i].Y, labyPoint[i + 1].Y);
                if ( ((x0 == x1) && (PicSmile.Left < x0) && (x1 < PicSmile.Right  && y0 < PicSmile.Top  && PicSmile.Bottom < y1)) 
                ||   ((y0 == y1) && (PicSmile.Top  < y0) && (y1 < PicSmile.Bottom && x0 < PicSmile.Left && PicSmile.Right  < x1)) )
                {   // Touched the line
                    gameOver();
                    break;
                }
            }
            if (PicGoal.Left < PicSmile.Left && PicSmile.Right < PicGoal.Right
            &&  PicGoal.Top  < PicSmile.Top  && PicSmile.Bottom < PicGoal.Bottom)
            {
                goal();
            }

        }

        private void gameOver()
        {
            lblGameOver.Text = "Game Over.";
            gameoverFlag = true;
            lblGameOver.Visible = true;
            lblStart.Visible = true; ;
            stopWatch.Stop();
            timer1.Enabled = false;
        }
        private void goal()
        {
            lblGameOver.Text = "GOAL!";
            gameoverFlag = true;
            lblGameOver.Visible = true;
            lblStart.Visible = true;
            stopWatch.Stop();
            timer1.Enabled = false;
            LblYourName.Visible = true;
            TxtYourName.Visible = true;
            BtnOk.Enabled = true;
            BtnOk.Visible = true;
            TxtYourName.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10).Trim();
            lblTimer.Text = elapsedTime;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            StreamWriter swTxtFile;
            if (File.Exists(SAVE_TXT_FILE_NAME))
            { // file exist -- appendmode
                swTxtFile = new StreamWriter(SAVE_TXT_FILE_NAME, true, Encoding.UTF8);
            }
            else
            { // new
                swTxtFile = new StreamWriter(SAVE_TXT_FILE_NAME, false, Encoding.UTF8);
            }
            swTxtFile.WriteLine(TxtYourName.Text + "," + lblTimer.Text);

            swTxtFile.Close();
            LblYourName.Visible = false;
            TxtYourName.Visible = false;
            BtnOk.Enabled = false;
            BtnOk.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SAVE_TXT_FILE_NAME);
        }
    }
}
