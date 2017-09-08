//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Threading;
using System.Windows.Forms;
//using System.Timers;
//using Tao.DevIl;
using Tao.FreeGlut;
using Tao.OpenGl;
//using Tao.Platform.Windows;
namespace Проект_по_физике
{
#region Чечевица
    class Lentil
    {
        private float Height;
        private float Massa;

        public Lentil(float Height, float Massa)
        {
            this.Height = Height;
            this.Massa = Massa;
            if(Massa<0 || Massa>100)
            {
                MessageBox.Show("Неккоректные данные, масса объекта по умолчанию будет 5 кг", "AHTUNG!!!", MessageBoxButtons.OK);
                this.Massa = 5;
            }
        }
        public float Get_Massa()
        {
            return this.Massa;
            
        }
        public float Get_Height()
        {
            return this.Height;
        }
        public void Set_Height(float Height)
        {
            this.Height = Height;
        }
        public void Drawobject()
        {
            Gl.glPushMatrix();            
                Gl.glTranslatef(0, 0, Height/10);
                Glut.glutSolidCone(0.08, 0.02, 200, 200);
                Gl.glRotatef(180, 1, 0, 0);
                Glut.glutSolidCone(0.08, 0.02, 200, 200);
            Gl.glPopMatrix();
        }
    }
#endregion
    class Binding
    {
        anModelLoader Binding_Render = null;
        private float Height;
        public Binding(float Height)
        {
            Binding_Render = new anModelLoader();
            Binding_Render.LoadModel("krep.ase");
            this.Height = Height;
            if (Height < 0 || Height > 10)
            {
                MessageBox.Show("Неккоректные данные, высота объекта по умолчанию будет 50 см", "AHTUNG!!!", MessageBoxButtons.OK);
                this.Height = 5;
            }
        }
        public float Get_Height()
        {
            return this.Height;
        }
        public void Set_Height(float Height)
        {
            this.Height = Height;
        }
        public void Drawobject(bool f)
        {
            
            Gl.glPushMatrix();
                Gl.glTranslatef(0, 0, Height/10);
                if (f == true)
                    Gl.glRotatef(180, 1, 0, 0);
                Binding_Render.DrawModel();
            Gl.glPopMatrix();
        }
    }

}
