using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Text;
//using System.Threading;
using System.Windows.Forms;
//using System.Timers;

namespace Проект_по_физике
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            if(e.NewValue<e.OldValue)
            {
                pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 14 * (e.OldValue - e.NewValue));
                label1.Location = new System.Drawing.Point(label1.Location.X, label1.Location.Y + 14 * (e.OldValue - e.NewValue));
                label2.Location = new System.Drawing.Point(label2.Location.X, label2.Location.Y + 14 * (e.OldValue - e.NewValue));
                label3.Location = new System.Drawing.Point(label3.Location.X, label3.Location.Y + 14 * (e.OldValue - e.NewValue));
                label4.Location = new System.Drawing.Point(label4.Location.X, label4.Location.Y + 14 * (e.OldValue - e.NewValue));
                label5.Location = new System.Drawing.Point(label5.Location.X, label5.Location.Y + 14 * (e.OldValue - e.NewValue));
                pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, pictureBox2.Location.Y + 14 * (e.OldValue - e.NewValue));
            }
            else
            {
                if (e.NewValue >e.OldValue)
                {
                    pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y - 14 * (e.NewValue - e.OldValue));
                    label1.Location = new System.Drawing.Point(label1.Location.X, label1.Location.Y - 14 * (e.NewValue - e.OldValue));
                    label2.Location = new System.Drawing.Point(label2.Location.X, label2.Location.Y - 14 * (e.NewValue - e.OldValue));
                    label3.Location = new System.Drawing.Point(label3.Location.X, label3.Location.Y - 14 * (e.NewValue - e.OldValue));
                    label4.Location = new System.Drawing.Point(label4.Location.X, label4.Location.Y - 14 * (e.NewValue - e.OldValue));
                    label5.Location = new System.Drawing.Point(label5.Location.X, label5.Location.Y - 14 * (e.NewValue - e.OldValue));
                    pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, pictureBox2.Location.Y - 14 * (e.NewValue - e.OldValue));
                }
                
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Image.FromFile("Безымянный1.jpg"), pictureBox1.Size);
            pictureBox2.Image = new Bitmap(Image.FromFile("Безымянный2.jpg"), pictureBox2.Size);            
        }
    }
}
