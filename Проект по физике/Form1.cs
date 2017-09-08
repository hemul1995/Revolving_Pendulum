using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Text;
//using System.Threading;
using System.Windows.Forms;
using System.Timers;//&
//using Tao.DevIl;
using Tao.FreeGlut;
using Tao.OpenGl;
//using Tao.Platform.Windows;

namespace Проект_по_физике
{
    public partial class Form1 : Form
    {
        int Time = 0;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();

        }
                
        double[] X = new double[4810];
        double[] Y = new double[4810];
        double[] Z = new double[4810];
        int Increment=0;
        double Angle, Angle_W = 0;
        bool flag = false;
        int Correct_Width, Correct_Height;
        Lentil Object1 = null, Object2 = null;
        Binding Object3 = null, Object4 = null;
        anModelLoader Shtativ = null;
        PointF mouse1, mouse2;
        double camXRot = 0.0;
        double camYRot = 0.0;
        static double camXPos = 0;
        static double camYPos = 0;
        static double camZPos = 0;
        double M = 10000, G = 10, L = 10, I = 1;

        private double r(double value, int k)
        {
            return Math.Round((Math.Pow(10, k)*value)) / Math.Pow(10, k);
        }

        private double f(double xt, double yt, double zt)
        {            
            if(TopMount_radioButton.Checked==true)
            {
                float o1 = Object1.Get_Height() / 10;
                float o2 = Object2.Get_Height() / 10;
                float o3 = Object3.Get_Height() / 10;
                float o4 = Object4.Get_Height() / 10;
                
                L = o3 - (o1 + o2) / 2;
                I = 2  * 0.08 * 0.08 + M * Math.Pow((o1 - o3), 2) + M * Math.Pow((o2 - o3), 2);
                return -G * M * L * Math.Sin(yt) / I;
            }   
            else
            {
                float o1 = 1-Object1.Get_Height() / 10;
                float o2 = 1-Object2.Get_Height() / 10;
                float o3 = 1-Object3.Get_Height() / 10;
                float o4 = 1-Object4.Get_Height() / 10;
                L = o4 - (o1 + o2) / 2;
                I = 2 * 0.08 * 0.08 + Math.Pow((o1 - o4), 2) + Math.Pow((o2 - o4), 2);
                return -G *  L * Math.Sin(yt) / I;
            }
        }

        private double g(double xt, double yt, double zt)
        {
            return zt;
        }

        private void diffure(double X0, double Y0, double Z0)
        {
            double Z1, Y1;
            double k1, k2, k4, k3;
            double q1, q2, q4, q3;
            X0 = X0 / 1000.0;
            if (Y0 != 180.0d && Y0 != -180.0d)
            {
                Y0 = Y0 * Math.PI / 180.0;
                double h = 0.05;

                k1 = h * f(X0, Y0, Z0);
                q1 = h * g(X0, Y0, Z0);

                k2 = h * f(X0 + h / 2.0, Y0 + q1 / 2.0, Z0 + k1 / 2.0);
                q2 = h * g(X0 + h / 2.0, Y0 + q1 / 2.0, Z0 + k1 / 2.0);

                k3 = h * f(X0 + h / 2.0, Y0 + q2 / 2.0, Z0 + k2 / 2.0);
                q3 = h * g(X0 + h / 2.0, Y0 + q2 / 2.0, Z0 + k2 / 2.0);

                k4 = h * f(X0 + h, Y0 + q3, Z0 + k3);
                q4 = h * g(X0 + h, Y0 + q3, Z0 + k3);

                Z1 = Z0 + (k1 + 2.0 * k2 + 2.0 * k3 + k4) / 6.0;
                Y1 = Y0 + (q1 + 2.0 * q2 + 2.0 * q3 + q4) / 6.0;

                X[Increment] = X0;
                Y[Increment] = Y0;
                Z[Increment] = Z0;
                Z0 = Z1;
                Y0 = Y1 * 180.0 / Math.PI;
                Angle = Y0;
                Angle_W = Z0;
            }
            else
            {
                Y0 = Y0 * Math.PI / 180.0;
                X[Increment] = X0;
                Y[Increment] = Y0;
                Z[Increment] = Z0;
            }
        }

        private void Key_Down(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                double z_end = 0.05;
                camZPos += z_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Sin(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
                camXPos += -z_end * Math.Sin(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Sin(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
                camYPos += -z_end * Math.Cos(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
            }

            if (e.KeyCode == Keys.S)
            {
                double z_end = -0.05;
                camZPos += z_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Sin(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
                camXPos += -z_end * Math.Sin(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Sin(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
                camYPos += -z_end * Math.Cos(Convert.ToDouble(camXRot + 90) * Math.PI / 180);
            }

            if (e.KeyCode == Keys.A)
            {
                double x_end = -0.05;
                camXPos += -x_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180);
                camZPos += -x_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Tan(Convert.ToDouble(camYRot) * Math.PI / 180);
            }

            if (e.KeyCode == Keys.D)
            {
                double x_end = 0.05;
                camXPos += -x_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180);
                camZPos += -x_end * Math.Cos(Convert.ToDouble(camYRot) * Math.PI / 180) * Math.Tan(Convert.ToDouble(camYRot) * Math.PI / 180);
            } 
        }

        private void Mouse_Down(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouse1 = e.Location;
        }

        private void Mouse_Move(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse2 = e.Location;

                float vertMouseSensitivity = 10.0f;
                float horizMouseSensitivity = 10.0f;

                float horizMovement = mouse2.X - mouse1.X;
                float vertMovement = mouse2.Y - mouse1.Y;

                camXRot += vertMovement / vertMouseSensitivity;
                camYRot += horizMovement / horizMouseSensitivity;

                if (camXRot < -90.0f)
                {
                    camXRot = -90.0f;
                }

                if (camXRot > 90.0f)
                {
                    camXRot = 90.0f;
                }

                if (camYRot < -180.0f)
                {
                    camYRot += 360.0f;
                }

                if (camYRot > 180.0f)
                {
                    camYRot -= 360.0f;
                }
            }
            mouse1 = mouse2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            AnT.KeyDown += new System.Windows.Forms.KeyEventHandler(Key_Down);
            RenderTimer.Tick += new EventHandler(RenderTimer_Tick);
            AnT.MouseDown += new System.Windows.Forms.MouseEventHandler(Mouse_Down);
            AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(Mouse_Move);
            TopMount_radioButton.Checked = true;
            label1.Text = "Угол:     0";
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            DrawAllMatrix();
            AngleValue_Label.Text = Convert.ToString(ChangeAngle_TrackBar.Value) + "°";
            if (TopMount_radioButton.Checked == true)
            {
                label2.Text = Convert.ToString(Object1.Get_Height() / 10)+" м";
                label3.Text = Convert.ToString(Object2.Get_Height() / 10) + " м";
                label4.Text = Convert.ToString(Object3.Get_Height() / 10) + " м";
                label5.Text = Convert.ToString(Object4.Get_Height() / 10) + " м";

            }
            else
            {
                label2.Text = Convert.ToString(1 - Object1.Get_Height() / 10) + " м";
                label3.Text = Convert.ToString(1 - Object2.Get_Height() / 10) + " м";
                label4.Text = Convert.ToString(1 - Object3.Get_Height() / 10) + " м";
                label5.Text = Convert.ToString(1 - Object4.Get_Height() / 10) + " м";
            }
        }

        private void DrawGround()
        {
            Gl.glColor3d(1.06, 1.92, 4.84);

            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(-1.5f, -1.5f, -0.15f);
                Gl.glVertex3f(-1.5f, 1.5f, -0.15f);
                Gl.glVertex3f(1.5f, 1.5f, -0.15f);
                Gl.glVertex3f(1.5f, -1.5f, -0.15f);        
            Gl.glEnd();

            Gl.glColor3d(0, 0, 0);
            Gl.glLineWidth(3); 
            Gl.glBegin(Gl.GL_LINES);            
                for (float i = -1.5f; i <= 1.5f; i += 0.5f)
                {
                    Gl.glVertex3f(i, -1.5f, -0.15f + 0.001f);
                    Gl.glVertex3f(i, 1.5f, -0.15f + 0.001f);
                    Gl.glVertex3f(-1.5f, i, -0.15f + 0.001f);
                    Gl.glVertex3f(1.5f, i, -0.15f + 0.001f);                
                }            
            Gl.glEnd();
        }

        private void DrawAllMatrix()
        {
            if (Correct_Height != AnT.Size.Height || Correct_Width != AnT.Size.Width)
            {
                if (Correct_Height != AnT.Size.Height)
                    Correct_Height = AnT.Size.Height;
                if (Correct_Width != AnT.Size.Width)
                    Correct_Width = AnT.Size.Width;
                Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            }

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glClearColor(0.7f * 1.2f, 0.999f * 1.2f, 0.568f * 1.2f, 1.0f);//фон редактить здесь
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);

            Gl.glColor3d(0.31, 0.31, 0.31);
            Gl.glRotated(-90, 1, 0, 0);
            Gl.glRotated(90, 0, 0, 1);

            Shtativ.DrawModel();
            DrawGround();//КАТЯ, СТОЛ УБИРАЕТСЯ ЗДЕСЬ!!!
            Gl.glRotated(-90, 0, 0, 1);
            Gl.glRotated(90, 1, 0, 0);
            Gl.glColor3d(0.31, 0.31, 0.31);
            Gl.glPushMatrix();
                Gl.glRotatef(-90, 1, 0, 0);
                Gl.glTranslatef(0, 0, 1);
                Gl.glRotated(Angle, 0, -1, 0);
                Gl.glTranslatef(0, 0, -1);

                if(TopMount_radioButton.Checked==true)
                {
                    Gl.glTranslatef(0, 0, 1 - Object3.Get_Height()/10);
                    Glut.glutSolidCylinder(0.01d, 1, 200, 1);
                    Gl.glColor3d(0, 0.0, 0.0);
                    for (int i = 1; i < 20; i++)
                    { 
                        Gl.glTranslatef(0, 0, 0.05f);
                        Glut.glutSolidCylinder(0.0101d, 0.002, 200, 1);
                    }
                    Gl.glTranslatef(0, 0, -0.95f);
                    Gl.glColor3d(0.75, 0, 0);
                    Glut.glutSolidCylinder(0.0120d, 0.025, 200, 1);
                    Gl.glColor3d(0.31, 0.31, 0.31);
                }
                if (BottomMount_radioButton.Checked == true)
                {
                    Gl.glTranslatef(0, 0, 1 + Object4.Get_Height()/10);
                    Gl.glRotatef(-180, 1, 0, 0);
                    Glut.glutSolidCylinder(0.01d, 1, 200, 1);
                    Gl.glColor3d(0, 0.0, 0.0);
                    for (int i = 1; i < 20; i++)
                    {
                        Gl.glTranslatef(0, 0, 0.05f);
                        Glut.glutSolidCylinder(0.0101d, 0.002, 200, 1);

                    }
                    Gl.glColor3d(0.75, 0, 0);
                    Gl.glTranslatef(0, 0, 0.025f);
                    Glut.glutSolidCylinder(0.0120d, 0.025, 200, 1);
                    Gl.glTranslatef(0, 0, -0.975f);    
                    Gl.glColor3d(0.31, 0.31, 0.31);
                }

                Gl.glColor3d(0.31, 0.31, 0.31);
                Gl.glDisable(Gl.GL_COLOR_MATERIAL);
                Gl.glPushMatrix();


                    Object1.Drawobject();
                    Object2.Drawobject();
                    Object3.Drawobject(false);
                    Object4.Drawobject(true);
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            Gl.glDisable(Gl.GL_DEPTH_TEST);
            Gl.glDisable(Gl.GL_LIGHTING);
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glLoadIdentity();
            
            Gl.glRotated(camXRot, 1, 0, 0);
            Gl.glRotated(camYRot, 0, 1, 0);
            Gl.glTranslated(camXPos, camYPos, camZPos);
            Gl.glTranslated(0, -0.5, -2.5);
            Gl.glFlush();//?
            AnT.Invalidate();
        }
        
        private void Form1_Activated(object sender, EventArgs e)
        {
            if(!flag)
            {
                Shtativ = new anModelLoader();
                Shtativ.LoadModel("shtativ.ase");
                Object1 = new Lentil(2, 6);
                Object2 = new Lentil(7, 6);
                Object3 = new Binding(8);
                Object4 = new Binding(3);

                RenderTimer.Enabled = true;
                RenderTimer.Interval = 50;
                Correct_Height = AnT.Size.Height;
                Correct_Width = AnT.Size.Width;

                Glut.glutInit();
                Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

                Gl.glEnable(Gl.GL_DITHER);
                Gl.glClearColor(192, 181, 0, 10);
                Gl.glViewport(0, 0, AnT.Width, AnT.Height);

                Gl.glMatrixMode(Gl.GL_PROJECTION);
                Gl.glLoadIdentity();

                Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
                Gl.glEnable(Gl.GL_DITHER);
                Gl.glMatrixMode(Gl.GL_MODELVIEW);
                Gl.glLoadIdentity();

                pictureBox1.Image = new Bitmap(Image.FromFile("X9qxn1viHXo.jpg"), pictureBox1.Size);
                flag = true;
            }                
        }

        private void ChangeAngle_TrackBar_Scroll(object sender, EventArgs e)
        {
            Angle = ChangeAngle_TrackBar.Value;
            label1.Text = "Угол:    " + Convert.ToString(Angle) + "°";
        }

        private void TopMount_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Lentil2_Label.Text = "Дальний груз:";
            Lentil1_Label.Text = "Ближний груз:";
            Binding2_Label.Text = "Ближнее крепление:";
            Binding1_Label.Text = "Дальнее крепление:";
        }

        private void BottomMount_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Lentil2_Label.Text = "Ближний груз:";
            Lentil1_Label.Text = "Дальний груз:";
            Binding2_Label.Text = "Дальнее крепление:";
            Binding1_Label.Text = "Ближнее крепление:";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time <= 240000)
            {
                Increment++;
                int tmp = Convert.ToInt32(Time * 1.25);
                diffure(tmp, Angle, Angle_W);
                Time = Time + 50;

                if (tmp % 1 == 0)
                {
                    
                    label1.Text = "Угол:    " + Convert.ToString(r(Angle, 2))+"°";
                    label6.Text = "Время:   " + Convert.ToString((tmp / 60000)) + ":" + Convert.ToString((tmp / 1000) % 60) + ":" + Convert.ToString((tmp % 1000) / 100) + " c";// +Convert.ToString();
                }
            }
            else
            {                
                timer1.Stop();
                button4_Click(sender, e);
                MessageBox.Show("Ваше время вышло! Начните сначала.\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button3.Enabled = false;
            
            X[0] = 0;
            Y[0] = Convert.ToSingle(ChangeAngle_TrackBar.Value) * Math.PI/180;
            Z[0] = 0;
            button3.Text = "Продолжить эксперимент";
            timer1.Interval = 50;
            ChangeAngle_TrackBar.Enabled = false;
            DecBinding1_Button.Enabled = false;
            DecBinding2_Button.Enabled = false;
            IncBinding1_Button.Enabled = false;
            IncBinding2_Button.Enabled = false;
            DecLentil1_Button.Enabled = false;
            DecLentil2_Button.Enabled = false;
            IncLentil1_Button.Enabled = false;
            IncLentil2_Button.Enabled = false;
            TopMount_radioButton.Enabled = false;
            BottomMount_radioButton.Enabled = false;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            timer1.Stop();
            Increment = 0;
            Time = 0;
            Angle_W = 0;
            Angle = ChangeAngle_TrackBar.Value;
            ChangeAngle_TrackBar.Enabled = true;
            DecBinding1_Button.Enabled = true;
            DecBinding2_Button.Enabled = true;
            IncBinding1_Button.Enabled = true;
            IncBinding2_Button.Enabled = true;
            DecLentil1_Button.Enabled = true;
            DecLentil2_Button.Enabled = true;
            IncLentil1_Button.Enabled = true;
            IncLentil2_Button.Enabled = true;
            TopMount_radioButton.Enabled = true;
            BottomMount_radioButton.Enabled = true;
            button3.Text = "Начать эксперимент";
            label6.Text = "Время:   0.0";
            label1.Text = "Угол:    "+Convert.ToString(Angle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Enabled = true;
        }

        private void DecLentil1_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object1.Get_Height() - 0.5f >= 0)
                    Object1.Set_Height(Object1.Get_Height() - 0.5f);
            }
            else
            {
                if (Object1.Get_Height() + 0.5f < Object4.Get_Height())
                    Object1.Set_Height(Object1.Get_Height() + 0.5f);
            }
        }

        private void DecLentil2_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object2.Get_Height() - 0.5f > Object4.Get_Height())
                    Object2.Set_Height(Object2.Get_Height() - 0.5f);
            }
            else
            {
                if (Object2.Get_Height() + 0.5f < Object3.Get_Height())
                    Object2.Set_Height(Object2.Get_Height() + 0.5f);
            }
        }

        private void DecBinding1_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object3.Get_Height() - 0.5f > Object2.Get_Height())
                    Object3.Set_Height(Object3.Get_Height() - 0.5f);
            }
            else
            {
                if (Object3.Get_Height() + 0.5f <= 10)
                    Object3.Set_Height(Object3.Get_Height() + 0.5f);
            }
        }

        private void DecBinding2_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object4.Get_Height() - 0.5f > Object1.Get_Height())
                    Object4.Set_Height(Object4.Get_Height() - 0.5f);
            }
            else
            {
                if (Object4.Get_Height() + 0.5f < Object2.Get_Height())
                    Object4.Set_Height(Object4.Get_Height() + 0.5f);
            }
        }

        private void IncLentil1_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object1.Get_Height() + 0.5f < Object4.Get_Height())
                    Object1.Set_Height(Object1.Get_Height() + 0.5f);
            }
            else
            {
                if (Object1.Get_Height() - 0.5f >= 0)
                    Object1.Set_Height(Object1.Get_Height() - 0.5f);
            }
        }

        private void IncLentil2_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object2.Get_Height() + 0.5f < Object3.Get_Height())
                    Object2.Set_Height(Object2.Get_Height() + 0.5f);
            }
            else
            {
                if (Object2.Get_Height() - 0.5f > Object4.Get_Height())
                    Object2.Set_Height(Object2.Get_Height() - 0.5f);
            }
        }

        private void IncBinding1_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object3.Get_Height() + 0.5f <= 10)
                    Object3.Set_Height(Object3.Get_Height() + 0.5f);
            }
            else
            {
                if (Object3.Get_Height() - 0.5f > Object2.Get_Height())
                    Object3.Set_Height(Object3.Get_Height() - 0.5f);
            }
        }

        private void IncBinding2_Button_Click(object sender, EventArgs e)
        {
            if (TopMount_radioButton.Checked == true)
            {
                if (Object4.Get_Height() + 0.5f < Object2.Get_Height())
                    Object4.Set_Height(Object4.Get_Height() + 0.5f);
            }
            else
            {
                if (Object4.Get_Height() - 0.5f > Object1.Get_Height())
                    Object4.Set_Height(Object4.Get_Height() - 0.5f);
            }
        }

        private void графикToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 Graphic1_Form = new Form2();
            Graphic1_Form.SetParam(X, Y, Increment);
            Graphic1_Form.Show();
        }

        private void графикΘtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Graphic2_Form = new Form3();
            Graphic2_Form.SetParam(X, Z, Increment);
            Graphic2_Form.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void информацияОРазработчикахToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("В разработке участвовали:\nРазработчики:\no     Червонецкий Дмитрий Николаевич, ПМИ-31, e-mail: dimacher1995@gmail.com\no     Милякина Екатерина Олеговна, ПМИ-31, e-mail: foxrina21@mail.ru\no     Соловьёв Борислав Сергеевич, ПМИ-31, e-mail: Sbs@s-telecom.ru\no     Махнёва Елена Андреевна, ПМИ-31, e-mail: MEF95@mail.ru\nРуководитель: \no     Баранов Александр Викторович, кафедра Общей физики, e-mail: baranovav@ngs.ru");
        }

        private void справкаПоПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Graphic_Form = new Form4();
            Graphic_Form.Show();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


 
