namespace Ejercicio5_Huanguelen
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
            this.btnIngresarEmbarque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEstablecimiento = new System.Windows.Forms.TextBox();
            this.tbGuia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBuscarGuiaOEstablecimiento = new System.Windows.Forms.TextBox();
            this.rbEstablecimiento = new System.Windows.Forms.RadioButton();
            this.rbPorGuia = new System.Windows.Forms.RadioButton();
            this.BuscarPor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIngresarEmbarque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEstablecimiento);
            this.groupBox1.Controls.Add(this.tbGuia);
            this.groupBox1.Location = new System.Drawing.Point(26, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(637, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de embarque";
            // 
            // btnIngresarEmbarque
            // 
            this.btnIngresarEmbarque.Location = new System.Drawing.Point(430, 44);
            this.btnIngresarEmbarque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarEmbarque.Name = "btnIngresarEmbarque";
            this.btnIngresarEmbarque.Size = new System.Drawing.Size(174, 69);
            this.btnIngresarEmbarque.TabIndex = 4;
            this.btnIngresarEmbarque.Text = "Ingresar embarque";
            this.btnIngresarEmbarque.UseVisualStyleBackColor = true;
            this.btnIngresarEmbarque.Click += new System.EventHandler(this.btnIngresarEmbarque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número establecimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Guía";
            // 
            // tbEstablecimiento
            // 
            this.tbEstablecimiento.Location = new System.Drawing.Point(236, 90);
            this.tbEstablecimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEstablecimiento.Name = "tbEstablecimiento";
            this.tbEstablecimiento.Size = new System.Drawing.Size(148, 26);
            this.tbEstablecimiento.TabIndex = 0;
            // 
            // tbGuia
            // 
            this.tbGuia.Location = new System.Drawing.Point(236, 45);
            this.tbGuia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGuia.Name = "tbGuia";
            this.tbGuia.Size = new System.Drawing.Size(148, 26);
            this.tbGuia.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBuscarGuiaOEstablecimiento);
            this.groupBox2.Controls.Add(this.rbEstablecimiento);
            this.groupBox2.Controls.Add(this.rbPorGuia);
            this.groupBox2.Controls.Add(this.BuscarPor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(637, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // tbBuscarGuiaOEstablecimiento
            // 
            this.tbBuscarGuiaOEstablecimiento.Location = new System.Drawing.Point(45, 77);
            this.tbBuscarGuiaOEstablecimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscarGuiaOEstablecimiento.Name = "tbBuscarGuiaOEstablecimiento";
            this.tbBuscarGuiaOEstablecimiento.Size = new System.Drawing.Size(339, 26);
            this.tbBuscarGuiaOEstablecimiento.TabIndex = 5;
            // 
            // rbEstablecimiento
            // 
            this.rbEstablecimiento.AutoSize = true;
            this.rbEstablecimiento.Location = new System.Drawing.Point(53, 141);
            this.rbEstablecimiento.Name = "rbEstablecimiento";
            this.rbEstablecimiento.Size = new System.Drawing.Size(140, 24);
            this.rbEstablecimiento.TabIndex = 6;
            this.rbEstablecimiento.TabStop = true;
            this.rbEstablecimiento.Text = "Establecimiento";
            this.rbEstablecimiento.UseVisualStyleBackColor = true;
            // 
            // rbPorGuia
            // 
            this.rbPorGuia.AutoSize = true;
            this.rbPorGuia.Location = new System.Drawing.Point(53, 111);
            this.rbPorGuia.Name = "rbPorGuia";
            this.rbPorGuia.Size = new System.Drawing.Size(61, 24);
            this.rbPorGuia.TabIndex = 5;
            this.rbPorGuia.TabStop = true;
            this.rbPorGuia.Text = "Guía";
            this.rbPorGuia.UseVisualStyleBackColor = true;
            // 
            // BuscarPor
            // 
            this.BuscarPor.Location = new System.Drawing.Point(430, 47);
            this.BuscarPor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarPor.Name = "BuscarPor";
            this.BuscarPor.Size = new System.Drawing.Size(174, 69);
            this.BuscarPor.TabIndex = 4;
            this.BuscarPor.Text = "Buscar";
            this.BuscarPor.UseVisualStyleBackColor = true;
            this.BuscarPor.Click += new System.EventHandler(this.BuscarPor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número Guía/Número Establecimiento";
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(456, 343);
            this.btnListarTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(174, 69);
            this.btnListarTodos.TabIndex = 7;
            this.btnListarTodos.Text = "Listar todos los embarques";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 425);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Consignataria de Huanguelén";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresarEmbarque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGuia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuscarPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEstablecimiento;
        private System.Windows.Forms.RadioButton rbEstablecimiento;
        private System.Windows.Forms.RadioButton rbPorGuia;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.TextBox tbBuscarGuiaOEstablecimiento;
    }
}

