namespace Ejercicio4_Torneo
{
    partial class FormPuntosTorneo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudTorneo = new System.Windows.Forms.NumericUpDown();
            this.lbInstancia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(292, 143);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 54);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puntos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Location = new System.Drawing.Point(48, 143);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 54);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // nudTorneo
            // 
            this.nudTorneo.Location = new System.Drawing.Point(231, 82);
            this.nudTorneo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudTorneo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTorneo.Name = "nudTorneo";
            this.nudTorneo.Size = new System.Drawing.Size(85, 26);
            this.nudTorneo.TabIndex = 8;
            // 
            // lbInstancia
            // 
            this.lbInstancia.AutoSize = true;
            this.lbInstancia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbInstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstancia.Location = new System.Drawing.Point(176, 29);
            this.lbInstancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInstancia.Name = "lbInstancia";
            this.lbInstancia.Size = new System.Drawing.Size(140, 24);
            this.lbInstancia.TabIndex = 9;
            this.lbInstancia.Text = "                          ";
            // 
            // FormPuntosTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 211);
            this.Controls.Add(this.lbInstancia);
            this.Controls.Add(this.nudTorneo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPuntosTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anotar Puntos de un jugador";
            ((System.ComponentModel.ISupportInitialize)(this.nudTorneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.NumericUpDown nudTorneo;
        public System.Windows.Forms.Label lbInstancia;
    }
}