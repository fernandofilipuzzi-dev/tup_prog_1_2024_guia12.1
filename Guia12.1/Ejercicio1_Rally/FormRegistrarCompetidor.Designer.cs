namespace Ejercicio1_Rally
{
    partial class FormRegistrarCompetidor
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
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarNumero.Location = new System.Drawing.Point(102, 78);
            this.btnAgregarNumero.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(127, 48);
            this.btnAgregarNumero.TabIndex = 2;
            this.btnAgregarNumero.Text = "Agregar";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(116, 27);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(6);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(196, 26);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // FormRegistrarCompetidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAgregarNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarCompetidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripción del compeetidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarNumero;
        public System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
    }
}