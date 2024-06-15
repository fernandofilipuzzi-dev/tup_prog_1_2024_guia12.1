namespace Ejercicio3_ControlEmbarque
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
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VerListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(20, 22);
            this.btnAgregarCompetidor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(212, 80);
            this.btnAgregarCompetidor.TabIndex = 3;
            this.btnAgregarCompetidor.Text = "Agregar Contenedor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(243, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 80);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(20, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(465, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver información Contenedor";
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Argentina",
            "China",
            "Alemania",
            "Japón",
            "España",
            "Portugal"});
            this.cbBuscar.Location = new System.Drawing.Point(30, 82);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(180, 28);
            this.cbBuscar.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "País Origen";
            // 
            // VerListado
            // 
            this.VerListado.Location = new System.Drawing.Point(273, 22);
            this.VerListado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.VerListado.Name = "VerListado";
            this.VerListado.Size = new System.Drawing.Size(212, 80);
            this.VerListado.TabIndex = 7;
            this.VerListado.Text = "Ver Listado";
            this.VerListado.UseVisualStyleBackColor = true;
            this.VerListado.Click += new System.EventHandler(this.VerListado_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 309);
            this.Controls.Add(this.VerListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarCompetidor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VerListado;
        public System.Windows.Forms.ComboBox cbBuscar;
    }
}

