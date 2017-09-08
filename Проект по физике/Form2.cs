using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Text;
using System.Windows.Forms;

namespace Проект_по_физике
{
    public partial class Form2 : Form
    {
        int Increment = 0;
        double[] X = new double[4810];
        double[] Y = new double[4810];
        int R = 100;
        PointF Center;
        PaintEventArgs f;

        public Form2()
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(Mouse_Down);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            Center.X = 10;
            Center.Y = panel1.Height / 2;
            KeyUp += new KeyEventHandler(Key_Up);
        }

        private void Key_Up(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                if (R > 60)
                    R-=5;
            }
            if (e.KeyCode == Keys.E)
            {
                if (R < 140)
                    R += 5;
            }
            if (e.KeyCode == Keys.S)
            {
                Center.Y = Center.Y - R;
            }
            if (e.KeyCode == Keys.W)
            {
                Center.Y = Center.Y + R;
            }
            if (e.KeyCode == Keys.A)
            {
                Center.X = Center.X + R;
            }
            if (e.KeyCode == Keys.D)
            {
                Center.X = Center.X - R;
            }
            panel1.Invalidate();
            this.panel1_Paint(sender, f);
        }
      
        private float invert_x(float x)
        {
            return (x*R + Center.X);
        }

        private float invert_y(float y)
        {
            return (-y*R + Center.Y);
        }

        public void SetParam( double[] X, double[] Y, int Increment)
        {
            this.Increment = Increment;
            this.X = X;
            this.Y = Y;
        }

        PointF mouse;

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            Graphics gr = panel1.CreateGraphics();
            gr.FillRectangle(new SolidBrush(Color.White), 0, 0, panel1.Width, panel1.Height);
            panel1_Paint(sender, f);
            gr.DrawLine(new Pen(Color.Red), Center.X, mouse.Y, mouse.X, mouse.Y);
            gr.DrawLine(new Pen(Color.Red), mouse.X, mouse.Y, mouse.X, Center.Y);
            String drawString = "t: " + Convert.ToString((mouse.X - Center.X) / R) + "\n" + "Θ(t): " + Convert.ToString((-mouse.Y + Center.Y) / R);

            Font drawFont = new Font("Times new roman", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            PointF drawPoint = new PointF(mouse.X, mouse.Y);
            gr.DrawString(drawString, drawFont, drawBrush, drawPoint);
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            f = e;
            Graphics gr = panel1.CreateGraphics();
            for (float i = Center.X; i >= -R; i -= R)
            {
                gr.DrawLine(new Pen(Color.LightGray), i, 0, i, panel1.Height);
                for (float j = 0; j < 10; j++)
                {
                    if (j == 5 || j == 0)
                        gr.DrawLine(new Pen(Color.Black), i + j * R / 10, Center.Y - 8, i + j * R / 10, Center.Y + 8);
                    else
                        gr.DrawLine(new Pen(Color.Black), i + j * R / 10, Center.Y - 4, i + j * R / 10, Center.Y + 4);
                }
            }

            for (float i = Center.X; i <= panel1.Width + R; i += R)
            {
                gr.DrawLine(new Pen(Color.LightGray), i, 0, i, panel1.Height);
                for (float j = 0; j < 10; j++)
                {
                    if (j == 5 || j == 0)
                        gr.DrawLine(new Pen(Color.Black), i + j * R / 10, Center.Y - 8, i + j * R / 10, Center.Y + 8);
                    else
                        gr.DrawLine(new Pen(Color.Black), i + j * R / 10, Center.Y - 4, i + j * R / 10, Center.Y + 4);
                }
            }

            for (float i = Center.Y; i >= -R; i -= R)
            {
                gr.DrawLine(new Pen(Color.LightGray), 0, i, panel1.Width, i);
                for (float j = 0; j < 10; j++)
                {
                    if (j == 5 || j == 0)
                        gr.DrawLine(new Pen(Color.Black), Center.X - 8, i + j * R / 10, Center.X + 8, i + j * R / 10);
                    else
                        gr.DrawLine(new Pen(Color.Black), Center.X - 4, i + j * R / 10, Center.X + 4, i + j * R / 10);
                }
            }
            for (float i = Center.Y; i <= panel1.Height + R; i += R)
            {
                gr.DrawLine(new Pen(Color.LightGray), 0, i, panel1.Width, i);
                for (float j = 0; j < 10; j++)
                {
                    if (j == 5 || j == 0)
                        gr.DrawLine(new Pen(Color.Black), Center.X - 8, i + j * R / 10, Center.X + 8, i + j * R / 10);
                    else
                        gr.DrawLine(new Pen(Color.Black), Center.X - 4, i + j * R / 10, Center.X + 4, i + j * R / 10);
                }
            }
            gr.DrawLine(new Pen(Color.Black), 0, Center.Y, panel1.Width, Center.Y);
            gr.DrawLine(new Pen(Color.Black), Center.X, 0, Center.X, panel1.Height);
            //*****************************************************************************************************************************
            for(int i=0; i<Increment; i++)
                gr.DrawLine(new Pen(Color.Green, 2), invert_x(Convert.ToSingle(X[i])), invert_y(Convert.ToSingle(Y[i])), invert_x(Convert.ToSingle(X[i+1])), invert_y(Convert.ToSingle(Y[i+1])));
            String drawString = "t, c";

            Font drawFont = new Font("Times new roman", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            PointF drawPoint = new PointF(panel1.Width - 35, Center.Y);
            gr.DrawString(drawString, drawFont, drawBrush, drawPoint);
            drawPoint = new PointF(Center.X, 5);
            drawString = "Θ(t), рад";
            gr.DrawString(drawString, drawFont, drawBrush, drawPoint);

            for (float i = Center.X % R; i < panel1.Width; i += R)
            {
                drawBrush = new SolidBrush(Color.FromArgb(42, 82, 190));
                if (Center.Y < 0)
                {
                    drawPoint = new PointF(i - 5, 0);
                    if (Math.Round((i - Center.X) / R) != 0)
                    {
                        gr.DrawString(Convert.ToString(Math.Round((i - Center.X) / R)), drawFont, drawBrush, drawPoint);
                    }
                }
                else
                {
                    if (Center.Y > panel1.Height)
                    {
                        drawPoint = new PointF(i - 5, panel1.Height - 30);
                        if (Math.Round((i - Center.X) / R) != 0)
                        {
                            gr.DrawString(Convert.ToString(Math.Round((i - Center.X) / R)), drawFont, drawBrush, drawPoint);
                        }
                    }
                    else
                    {
                        drawPoint = new PointF(i - 5, Center.Y + 300 / R);
                        if (Math.Round((i - Center.X) / R) != 0)
                        {
                            gr.DrawString(Convert.ToString(Math.Round((i - Center.X) / R)), drawFont, drawBrush, drawPoint);
                        }
                    }
                }

            }
            for (float i = Center.Y % R; i < panel1.Height; i += R)
            {
                drawBrush = new SolidBrush(Color.FromArgb(250, 73, 0));
                if (Center.X < 0)
                {
                    drawPoint = new PointF(0, i - 10);
                    if (Math.Round((Center.Y - i) / R) != 0)
                    {
                        gr.DrawString(" " + Convert.ToString(Math.Round((Center.Y - i) / R)), drawFont, drawBrush, drawPoint);
                    }
                }
                else
                {
                    if (Center.X > panel1.Width)
                    {
                        drawPoint = new PointF(panel1.Width - 30, i - 10);
                        if (Math.Round((Center.Y - i) / R) != 0)
                        {
                            gr.DrawString(" " + Convert.ToString(Math.Round((Center.Y - i) / R)), drawFont, drawBrush, drawPoint);
                        }
                    }
                    else
                    {
                        drawPoint = new PointF(Center.X + 300 / R, i - 10);
                        if (Math.Round((Center.Y - i) / R) != 0)
                        {
                            gr.DrawString(" " + Convert.ToString(Math.Round((Center.Y - i) / R)), drawFont, drawBrush, drawPoint);
                        }
                        else
                        {
                            drawPoint = new PointF(Center.X + 300 / R, Center.Y + 300 / R);
                            gr.DrawString(" " + Convert.ToString(Math.Round((Center.Y - i) / R)), drawFont, drawBrush, drawPoint);
                        }
                    }
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Назначение клавиш:\nW - Смещать график вниз\nS - Смещать график вверх\nA - Смещать график влево\nD - Смещать график вправо\nQ - Увеличить масштаб\nE - Уменьшить масштаб\n");
        }
    }
}
