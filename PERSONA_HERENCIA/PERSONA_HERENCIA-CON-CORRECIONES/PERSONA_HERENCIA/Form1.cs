namespace PERSONA_HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void validar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {

                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else
            {
                if (radioempleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radiodocente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            }
        }

        private void radioalumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES PARA PERSONA_HERENCIA//ALUMNO.png";
            radioalumno.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES PARA PERSONA_HERENCIA//PERSONA.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioempleado_CheckedChanged(object sender, EventArgs e)
        {

            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES PARA PERSONA_HERENCIA//EMPLEADO.avif";
            radioempleado.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radiodocente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES PARA PERSONA_HERENCIA//DOCENTE.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text);
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text);
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox3.Text);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            radioalumno.Checked = false;
            radioButton1.Checked = false;
            radiodocente.Checked = false;
            radioempleado.Checked = false;

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            string rutaImagen = "C://TRABAJOS DE POO I 3er SEMESTRE//IMAGENES PARA PERSONA_HERENCIA//PERSONA.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label2.Visible = true;
            textBox1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}