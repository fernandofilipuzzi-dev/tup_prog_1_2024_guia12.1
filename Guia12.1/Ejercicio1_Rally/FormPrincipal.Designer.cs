namespace Ejercicio1_Rally
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
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.btnCargarTiempos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(68, 27);
            this.btnAgregarCompetidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(202, 52);
            this.btnAgregarCompetidor.TabIndex = 2;
            this.btnAgregarCompetidor.Text = "Agregar Competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(68, 151);
            this.btnVerResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(202, 52);
            this.btnVerResultados.TabIndex = 2;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // btnCargarTiempos
            // 
            this.btnCargarTiempos.Location = new System.Drawing.Point(68, 89);
            this.btnCargarTiempos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargarTiempos.Name = "btnCargarTiempos";
            this.btnCargarTiempos.Size = new System.Drawing.Size(202, 52);
            this.btnCargarTiempos.TabIndex = 2;
            this.btnCargarTiempos.Text = "Cargar Tiempos de competidores";
            this.btnCargarTiempos.UseVisualStyleBackColor = true;
            this.btnCargarTiempos.Click += new System.EventHandler(this.btnCargarTiempos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 225);
            this.Controls.Add(this.btnAgregarCompetidor);
            this.Controls.Add(this.btnCargarTiempos);
            this.Controls.Add(this.btnVerResultados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnCargarTiempos;
    }
}

