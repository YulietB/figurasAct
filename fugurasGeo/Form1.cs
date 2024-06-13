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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            info.Clear();
            IMAGEN.Image = (fugurasGeo.Properties.Resources.cuadrado);
            DATOS.Clear();
            cuadrado.Checked = false;
            triangulo.Checked = false;
            rectangulo.Checked = false;
            esfera.Checked = false;
            circulo.Checked = false;
            cubo.Checked = false;
            prisma.Checked = false;
            irregular.Checked = false;
            POLIREG.Checked = false;
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS" + DATOS.Text, "Datos de alumno",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dibujar_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.cuadrado);
            }
            else if (triangulo.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.triangulo);
            }
            else if (rectangulo.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.rectangulo);
            }
            else if (POLIREG.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.poligonoregula);
            }
            else if (irregular.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.poligonoirregular);
            }
            else if (circulo.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.circulo);
            }
            else if (cubo.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.cubo);
            }
            else if (prisma.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.prisma);
            }
            else if (esfera.Checked)
            {
                IMAGEN.Image = (fugurasGeo.Properties.Resources.esfera);
            }
        }

        private void informacion_Click(object sender, EventArgs e)
        {
            if (cuadrado.Checked)
            {
                info.Text = "Figura seleccionada: Cuadrado, " + "\n" +
                    "Sus datos son:" + "\n" +
                    "Longitud del lado: "
                    + DATOS.Text;
            }
            else if (triangulo.Checked)
            {
                info.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (rectangulo.Checked)
            {
                info.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIREG.Checked)
            {
                info.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (irregular.Checked)
            {
                info.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (circulo.Checked)
            {
                info.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (cubo.Checked)
            {
                info.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (prisma.Checked)
            {
                info.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (esfera.Checked)
            {
                info.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                    @"D:\figurasG-master\figurasG-master\fugurasGeo\datos\info.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + info.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar los Datos", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("¿Quieres salir de la aplicacion?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            float area;
            
            if (cuadrado.Checked)
            { 
                Cuadrado cuadrado = new Cuadrado(5);
                 area = cuadrado.area();
                info.Text = info.Text + "\n" + "Area= " + area + "\n" + "Perimetro= " + cuadrado.perimetro()+ "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (triangulo.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (rectangulo.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (POLIREG.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (irregular.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (circulo.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (cubo.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
            else if (prisma.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                  + "\n";
            }
            else if (esfera.Checked)
            {
                info.Text = info.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
        }
    }
}
