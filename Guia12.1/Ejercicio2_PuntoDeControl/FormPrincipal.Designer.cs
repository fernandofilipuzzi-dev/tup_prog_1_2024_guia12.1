namespace Ejercicio2_PuntoDeControl
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
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkEsElectrico = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Automóvil",
            "Motocicleta",
            "Camioneta",
            "Camión"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(213, 108);
            this.cbTipoVehiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(180, 28);
            this.cbTipoVehiculo.TabIndex = 0;
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(213, 54);
            this.tbPatente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(181, 26);
            this.tbPatente.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(170, 205);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 75);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkEsElectrico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoVehiculo);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(446, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Ingreso";
            // 
            // cbkEsElectrico
            // 
            this.cbkEsElectrico.AutoSize = true;
            this.cbkEsElectrico.Location = new System.Drawing.Point(218, 158);
            this.cbkEsElectrico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbkEsElectrico.Name = "cbkEsElectrico";
            this.cbkEsElectrico.Size = new System.Drawing.Size(128, 24);
            this.cbkEsElectrico.TabIndex = 5;
            this.cbkEsElectrico.Text = "¿Es eléctrico?";
            this.cbkEsElectrico.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Vehículo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Estadista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Control de paso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.TextBox tbPatente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbkEsElectrico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

