using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace FIGURAS_GEOMETRICAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CUADRADO_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void TRIANGULO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IMAGEN_Click(object sender, EventArgs e)
        {

        }

        private void RECTANGULO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados" + DATOS.Text, "Datos figura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CALC_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (POLIIRREC.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";

            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            INFORMACION.Clear();
            DATOS.Clear();
            CUADRADO.Checked = false;
            TRIANGULO.Checked = false;
            RECTANGULO.Checked = false;
            ESFERA.Checked = false;
            CIRCULO.Checked = false;
            CUBO.Checked = false;
            PRISMA.Checked = false;
            POLIIRREC.Checked = false;
            POLIREG.Checked = false;
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void EXPORT_Click(object sender, EventArgs e)
        {
            try //EXCEPCION
            {
                string filename = @"C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES DE FIGURAS GEOMETRICAS//datos//datos.txt";
                StreamWriter writer = File.AppendText(filename);
                writer.WriteLine("Datos: " + INFORMACION.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void INFO_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cuadrado, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Círculo, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Rectángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Triángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (POLIIRREC.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Polígono irregular, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Polígono regular, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cubo, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Esfera, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Prisma, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
        }

        private void DUBUJAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.CUADRADO);
            }
            else if (CUBO.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.CUBO);
            }
            else if (ESFERA.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.ESFERA);
            }
            else if (POLIIRREC.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.POLIGONO_IRREGULAR);
            }
            else if (CIRCULO.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.CIRCULO);
            }
            else if (PRISMA.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.PRISMA);
            }
            else if (POLIREG.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.POLIGONO_REGULAR);
            }
            else if (TRIANGULO.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.TRIANGULO);
            }
            else if (RECTANGULO.Checked)
            {
                IMAGEN.Image = (FIGURAS_GEOMETRICAS.Properties.Resources.RECTANGULO);
            }
        }

        private void POLIREG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void POLIIRREC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CIRCULO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CUBO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PRISMA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ESFERA_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}