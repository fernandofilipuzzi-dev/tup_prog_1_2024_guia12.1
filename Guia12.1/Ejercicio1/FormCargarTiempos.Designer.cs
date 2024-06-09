namespace Ejemplo1
{
    partial class FormCargarTiempos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHH = new System.Windows.Forms.TextBox();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.tbMM = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número Competidor";
            // 
            // tbHH
            // 
            this.tbHH.Location = new System.Drawing.Point(171, 54);
            this.tbHH.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbHH.Name = "tbHH";
            this.tbHH.Size = new System.Drawing.Size(48, 22);
            this.tbHH.TabIndex = 6;
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarNumero.Location = new System.Drawing.Point(101, 90);
            this.btnAgregarNumero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(107, 36);
            this.btnAgregarNumero.TabIndex = 7;
            this.btnAgregarNumero.Text = "Agregar";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // tbMM
            // 
            this.tbMM.Location = new System.Drawing.Point(235, 54);
            this.tbMM.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbMM.Name = "tbMM";
            this.tbMM.Size = new System.Drawing.Size(48, 22);
            this.tbMM.TabIndex = 10;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNumero.Location = new System.Drawing.Point(168, 23);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(66, 16);
            this.lbNumero.TabIndex = 11;
            this.lbNumero.Text = "lbNumero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // FormCargarTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 134);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbMM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHH);
            this.Controls.Add(this.btnAgregarNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCargarTiempos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carga de tiempo del competidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbHH;
        private System.Windows.Forms.Button btnAgregarNumero;
        public System.Windows.Forms.TextBox tbMM;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbNumero;
    }
}