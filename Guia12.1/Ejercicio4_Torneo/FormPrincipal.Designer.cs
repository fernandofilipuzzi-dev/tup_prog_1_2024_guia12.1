namespace Ejercicio4_Torneo
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.gbCargaPuntosPartido = new System.Windows.Forms.GroupBox();
            this.btnCargarPuntos = new System.Windows.Forms.Button();
            this.Estadistica = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudJugador = new System.Windows.Forms.NumericUpDown();
            this.btnListarPorJugador = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPartido = new System.Windows.Forms.NumericUpDown();
            this.btnListarPorPartido = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCargaPuntosPartido.SuspendLayout();
            this.Estadistica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJugador)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInscripcion);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(281, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso de inscripción";
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Location = new System.Drawing.Point(35, 73);
            this.btnInscripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(201, 58);
            this.btnInscripcion.TabIndex = 0;
            this.btnInscripcion.Text = "Inscribir a Torneo";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // gbCargaPuntosPartido
            // 
            this.gbCargaPuntosPartido.Controls.Add(this.btnCargarPuntos);
            this.gbCargaPuntosPartido.Enabled = false;
            this.gbCargaPuntosPartido.Location = new System.Drawing.Point(13, 189);
            this.gbCargaPuntosPartido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaPuntosPartido.Name = "gbCargaPuntosPartido";
            this.gbCargaPuntosPartido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaPuntosPartido.Size = new System.Drawing.Size(281, 156);
            this.gbCargaPuntosPartido.TabIndex = 1;
            this.gbCargaPuntosPartido.TabStop = false;
            this.gbCargaPuntosPartido.Text = "Carga de los puntos";
            // 
            // btnCargarPuntos
            // 
            this.btnCargarPuntos.Location = new System.Drawing.Point(35, 72);
            this.btnCargarPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarPuntos.Name = "btnCargarPuntos";
            this.btnCargarPuntos.Size = new System.Drawing.Size(201, 62);
            this.btnCargarPuntos.TabIndex = 0;
            this.btnCargarPuntos.Text = "Cargar puntos ";
            this.btnCargarPuntos.UseVisualStyleBackColor = true;
            this.btnCargarPuntos.Click += new System.EventHandler(this.btnCargarPuntos_Click);
            // 
            // Estadistica
            // 
            this.Estadistica.Controls.Add(this.label1);
            this.Estadistica.Controls.Add(this.nudJugador);
            this.Estadistica.Controls.Add(this.btnListarPorJugador);
            this.Estadistica.Location = new System.Drawing.Point(302, 14);
            this.Estadistica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Estadistica.Name = "Estadistica";
            this.Estadistica.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Estadistica.Size = new System.Drawing.Size(356, 165);
            this.Estadistica.TabIndex = 2;
            this.Estadistica.TabStop = false;
            this.Estadistica.Text = "Estadistica por jugador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Jugador";
            // 
            // nudJugador
            // 
            this.nudJugador.Location = new System.Drawing.Point(157, 39);
            this.nudJugador.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudJugador.Name = "nudJugador";
            this.nudJugador.Size = new System.Drawing.Size(51, 26);
            this.nudJugador.TabIndex = 1;
            // 
            // btnListarPorJugador
            // 
            this.btnListarPorJugador.Location = new System.Drawing.Point(61, 73);
            this.btnListarPorJugador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarPorJugador.Name = "btnListarPorJugador";
            this.btnListarPorJugador.Size = new System.Drawing.Size(219, 79);
            this.btnListarPorJugador.TabIndex = 0;
            this.btnListarPorJugador.Text = "Listar resultados en un jugador  de todos los partidos";
            this.btnListarPorJugador.UseVisualStyleBackColor = true;
            this.btnListarPorJugador.Click += new System.EventHandler(this.btnListarPorJugador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudPartido);
            this.groupBox2.Controls.Add(this.btnListarPorPartido);
            this.groupBox2.Location = new System.Drawing.Point(302, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(356, 156);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadistica por partido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Partido";
            // 
            // nudPartido
            // 
            this.nudPartido.Location = new System.Drawing.Point(157, 41);
            this.nudPartido.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPartido.Name = "nudPartido";
            this.nudPartido.Size = new System.Drawing.Size(51, 26);
            this.nudPartido.TabIndex = 2;
            // 
            // btnListarPorPartido
            // 
            this.btnListarPorPartido.Location = new System.Drawing.Point(61, 83);
            this.btnListarPorPartido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarPorPartido.Name = "btnListarPorPartido";
            this.btnListarPorPartido.Size = new System.Drawing.Size(219, 63);
            this.btnListarPorPartido.TabIndex = 0;
            this.btnListarPorPartido.Text = "Listar Puntos Jugadores de un partido";
            this.btnListarPorPartido.UseVisualStyleBackColor = true;
            this.btnListarPorPartido.Click += new System.EventHandler(this.btnListarPorPartido_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Estadistica);
            this.Controls.Add(this.gbCargaPuntosPartido);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Torneo";
            this.groupBox1.ResumeLayout(false);
            this.gbCargaPuntosPartido.ResumeLayout(false);
            this.Estadistica.ResumeLayout(false);
            this.Estadistica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJugador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPartido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.GroupBox gbCargaPuntosPartido;
        private System.Windows.Forms.Button btnCargarPuntos;
        private System.Windows.Forms.GroupBox Estadistica;
        private System.Windows.Forms.Button btnListarPorJugador;
        private System.Windows.Forms.NumericUpDown nudJugador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudPartido;
        private System.Windows.Forms.Button btnListarPorPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

