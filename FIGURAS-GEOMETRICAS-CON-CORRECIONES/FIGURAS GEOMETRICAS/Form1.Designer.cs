namespace FIGURAS_GEOMETRICAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CALC = new Button();
            LIMPIAR = new Button();
            label2 = new Label();
            ESFERA = new RadioButton();
            PRISMA = new RadioButton();
            CUBO = new RadioButton();
            CIRCULO = new RadioButton();
            DATOS = new TextBox();
            POLIIRREC = new RadioButton();
            POLIREG = new RadioButton();
            RECTANGULO = new RadioButton();
            TRIANGULO = new RadioButton();
            CUADRADO = new RadioButton();
            label1 = new Label();
            EXPORT = new Button();
            DUBUJAR = new Button();
            INFO = new Button();
            GUARDAR = new Button();
            IMAGEN = new PictureBox();
            INFORMACION = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMAGEN).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CALC);
            groupBox1.Controls.Add(LIMPIAR);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ESFERA);
            groupBox1.Controls.Add(PRISMA);
            groupBox1.Controls.Add(CUBO);
            groupBox1.Controls.Add(CIRCULO);
            groupBox1.Controls.Add(DATOS);
            groupBox1.Controls.Add(POLIIRREC);
            groupBox1.Controls.Add(POLIREG);
            groupBox1.Controls.Add(RECTANGULO);
            groupBox1.Controls.Add(TRIANGULO);
            groupBox1.Controls.Add(CUADRADO);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EXPORT);
            groupBox1.Controls.Add(DUBUJAR);
            groupBox1.Controls.Add(INFO);
            groupBox1.Controls.Add(GUARDAR);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(544, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // CALC
            // 
            CALC.Location = new Point(416, 148);
            CALC.Margin = new Padding(4);
            CALC.Name = "CALC";
            CALC.Size = new Size(88, 26);
            CALC.TabIndex = 16;
            CALC.Text = "CALCULAR";
            CALC.UseVisualStyleBackColor = true;
            CALC.Click += CALC_Click;
            // 
            // LIMPIAR
            // 
            LIMPIAR.Location = new Point(323, 148);
            LIMPIAR.Margin = new Padding(4);
            LIMPIAR.Name = "LIMPIAR";
            LIMPIAR.Size = new Size(88, 26);
            LIMPIAR.TabIndex = 15;
            LIMPIAR.Text = "LIMPIAR";
            LIMPIAR.UseVisualStyleBackColor = true;
            LIMPIAR.Click += LIMPIAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(264, 15);
            label2.TabIndex = 14;
            label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO ETC";
            // 
            // ESFERA
            // 
            ESFERA.AutoSize = true;
            ESFERA.Location = new Point(429, 81);
            ESFERA.Margin = new Padding(4);
            ESFERA.Name = "ESFERA";
            ESFERA.Size = new Size(64, 19);
            ESFERA.TabIndex = 13;
            ESFERA.TabStop = true;
            ESFERA.Text = "ESFERA";
            ESFERA.UseVisualStyleBackColor = true;
            ESFERA.CheckedChanged += ESFERA_CheckedChanged;
            // 
            // PRISMA
            // 
            PRISMA.AutoSize = true;
            PRISMA.Location = new Point(345, 81);
            PRISMA.Margin = new Padding(4);
            PRISMA.Name = "PRISMA";
            PRISMA.Size = new Size(67, 19);
            PRISMA.TabIndex = 12;
            PRISMA.TabStop = true;
            PRISMA.Text = "PRISMA";
            PRISMA.UseVisualStyleBackColor = true;
            PRISMA.CheckedChanged += PRISMA_CheckedChanged;
            // 
            // CUBO
            // 
            CUBO.AutoSize = true;
            CUBO.Location = new Point(280, 81);
            CUBO.Margin = new Padding(4);
            CUBO.Name = "CUBO";
            CUBO.Size = new Size(57, 19);
            CUBO.TabIndex = 12;
            CUBO.TabStop = true;
            CUBO.Text = "CUBO";
            CUBO.UseVisualStyleBackColor = true;
            CUBO.CheckedChanged += CUBO_CheckedChanged;
            // 
            // CIRCULO
            // 
            CIRCULO.AutoSize = true;
            CIRCULO.Location = new Point(189, 81);
            CIRCULO.Margin = new Padding(4);
            CIRCULO.Name = "CIRCULO";
            CIRCULO.Size = new Size(74, 19);
            CIRCULO.TabIndex = 11;
            CIRCULO.TabStop = true;
            CIRCULO.Text = "CÍRCULO";
            CIRCULO.UseVisualStyleBackColor = true;
            CIRCULO.CheckedChanged += CIRCULO_CheckedChanged;
            // 
            // DATOS
            // 
            DATOS.Location = new Point(323, 118);
            DATOS.Margin = new Padding(4);
            DATOS.Name = "DATOS";
            DATOS.Size = new Size(86, 23);
            DATOS.TabIndex = 10;
            // 
            // POLIIRREC
            // 
            POLIIRREC.AutoSize = true;
            POLIIRREC.Location = new Point(10, 81);
            POLIIRREC.Margin = new Padding(4);
            POLIIRREC.Name = "POLIIRREC";
            POLIIRREC.Size = new Size(148, 19);
            POLIIRREC.TabIndex = 9;
            POLIIRREC.TabStop = true;
            POLIIRREC.Text = "POLÍGONO IRREGULAR";
            POLIIRREC.UseVisualStyleBackColor = true;
            POLIIRREC.CheckedChanged += POLIIRREC_CheckedChanged;
            // 
            // POLIREG
            // 
            POLIREG.AutoSize = true;
            POLIREG.Location = new Point(345, 54);
            POLIREG.Margin = new Padding(4);
            POLIREG.Name = "POLIREG";
            POLIREG.Size = new Size(138, 19);
            POLIREG.TabIndex = 8;
            POLIREG.TabStop = true;
            POLIREG.Text = "POLÍGONO REGULAR";
            POLIREG.UseVisualStyleBackColor = true;
            POLIREG.CheckedChanged += POLIREG_CheckedChanged;
            // 
            // RECTANGULO
            // 
            RECTANGULO.AutoSize = true;
            RECTANGULO.Location = new Point(223, 54);
            RECTANGULO.Margin = new Padding(4);
            RECTANGULO.Name = "RECTANGULO";
            RECTANGULO.Size = new Size(99, 19);
            RECTANGULO.TabIndex = 7;
            RECTANGULO.TabStop = true;
            RECTANGULO.Text = "RECTÁNGULO";
            RECTANGULO.UseVisualStyleBackColor = true;
            RECTANGULO.CheckedChanged += RECTANGULO_CheckedChanged;
            // 
            // TRIANGULO
            // 
            TRIANGULO.AutoSize = true;
            TRIANGULO.Location = new Point(117, 54);
            TRIANGULO.Margin = new Padding(4);
            TRIANGULO.Name = "TRIANGULO";
            TRIANGULO.Size = new Size(89, 19);
            TRIANGULO.TabIndex = 6;
            TRIANGULO.TabStop = true;
            TRIANGULO.Text = "TRIÁNGULO";
            TRIANGULO.UseVisualStyleBackColor = true;
            TRIANGULO.CheckedChanged += TRIANGULO_CheckedChanged;
            // 
            // CUADRADO
            // 
            CUADRADO.AutoSize = true;
            CUADRADO.Location = new Point(10, 54);
            CUADRADO.Margin = new Padding(4);
            CUADRADO.Name = "CUADRADO";
            CUADRADO.Size = new Size(89, 19);
            CUADRADO.TabIndex = 5;
            CUADRADO.TabStop = true;
            CUADRADO.Text = "CUADRADO";
            CUADRADO.UseVisualStyleBackColor = true;
            CUADRADO.CheckedChanged += CUADRADO_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 18);
            label1.TabIndex = 4;
            label1.Text = "CONSTRUCTOR DE FIGURAS GEOMÉTRICAS";
            // 
            // EXPORT
            // 
            EXPORT.Location = new Point(223, 148);
            EXPORT.Margin = new Padding(4);
            EXPORT.Name = "EXPORT";
            EXPORT.Size = new Size(88, 26);
            EXPORT.TabIndex = 3;
            EXPORT.Text = "EXPORTAR";
            EXPORT.UseVisualStyleBackColor = true;
            EXPORT.Click += EXPORT_Click;
            // 
            // DUBUJAR
            // 
            DUBUJAR.Location = new Point(128, 148);
            DUBUJAR.Margin = new Padding(4);
            DUBUJAR.Name = "DUBUJAR";
            DUBUJAR.Size = new Size(88, 26);
            DUBUJAR.TabIndex = 2;
            DUBUJAR.Text = "DIBUJAR";
            DUBUJAR.UseVisualStyleBackColor = true;
            DUBUJAR.Click += DUBUJAR_Click;
            // 
            // INFO
            // 
            INFO.Location = new Point(13, 148);
            INFO.Margin = new Padding(4);
            INFO.Name = "INFO";
            INFO.Size = new Size(108, 26);
            INFO.TabIndex = 1;
            INFO.Text = "INFORMACIÓN";
            INFO.UseVisualStyleBackColor = true;
            INFO.Click += INFO_Click;
            // 
            // GUARDAR
            // 
            GUARDAR.Location = new Point(416, 114);
            GUARDAR.Margin = new Padding(4);
            GUARDAR.Name = "GUARDAR";
            GUARDAR.Size = new Size(88, 26);
            GUARDAR.TabIndex = 0;
            GUARDAR.Text = "GUARDAR";
            GUARDAR.UseVisualStyleBackColor = true;
            GUARDAR.Click += GUARDAR_Click;
            // 
            // IMAGEN
            // 
            IMAGEN.Image = Properties.Resources.CUBO;
            IMAGEN.Location = new Point(15, 215);
            IMAGEN.Margin = new Padding(4);
            IMAGEN.Name = "IMAGEN";
            IMAGEN.Size = new Size(301, 291);
            IMAGEN.SizeMode = PictureBoxSizeMode.StretchImage;
            IMAGEN.TabIndex = 1;
            IMAGEN.TabStop = false;
            IMAGEN.Click += IMAGEN_Click;
            // 
            // INFORMACION
            // 
            INFORMACION.Location = new Point(323, 215);
            INFORMACION.Margin = new Padding(4);
            INFORMACION.Name = "INFORMACION";
            INFORMACION.Size = new Size(235, 290);
            INFORMACION.TabIndex = 2;
            INFORMACION.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 574);
            Controls.Add(INFORMACION);
            Controls.Add(IMAGEN);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "BIENVENID@";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IMAGEN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CALC;
        private Button LIMPIAR;
        private Label label2;
        private RadioButton ESFERA;
        private RadioButton PRISMA;
        private RadioButton CUBO;
        private RadioButton CIRCULO;
        private TextBox DATOS;
        private RadioButton POLIIRREC;
        private RadioButton POLIREG;
        private RadioButton RECTANGULO;
        private RadioButton TRIANGULO;
        private RadioButton CUADRADO;
        private Label label1;
        private Button EXPORT;
        private Button DUBUJAR;
        private Button INFO;
        private Button GUARDAR;
        private PictureBox IMAGEN;
        private RichTextBox INFORMACION;
    }
}