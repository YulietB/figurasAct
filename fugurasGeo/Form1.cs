using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fugurasGeo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lipiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void guardar_Click(object sender, EventArgs e)
        { 
          MessageBox.Show("los datos han sido guardados");
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\cuadrado.png";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (circulo.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\circulo.png";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (irregular.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\poligonoirregular.png";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (poligonoregular.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\poligonoregula.png";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (rectangulo.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\rectangulo.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (prisma.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\prisma.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (triangulo.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\triangulo.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (cubo.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\cubo.png";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }

            if (esfera.Checked)
            {
                string ruta = "D:\\figurasG-master\\figurasG-master\\imagenes\\esfera.jpg";
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
            }
        }
    }
}
