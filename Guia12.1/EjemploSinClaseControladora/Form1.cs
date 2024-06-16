using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSinClaseControladora
{
    public partial class Form1 : Form
    {
        #region variables y metodos del dominio
        int[] Numeros = new int[1000];
        int Contador = 0;

        void AgregarNumero(int nro)
        {
            Numeros[Contador] = nro;
            Contador++;
        }

        double CalcularPromedio()
        {
            double acum = 0;
            double promedio = 0;
            for (int n = 0; n < Contador; n++)
            {
                acum += Numeros[n];
            }
            if (Contador > 0)
                promedio = acum / Contador;

            return promedio;
        }
        #endregion 

        public Form1()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            FormDato formDato = new FormDato();

            if (formDato.ShowDialog() == DialogResult.OK)
            {
                int numero = Convert.ToInt32(formDato.textBox1.Text);

                 AgregarNumero(numero);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();

            FormVer formVer = new FormVer();

            formVer.listBox1.Items.Add($"Promedio: {promedio:f2}");

            formVer.ShowDialog();
        }
    }
}
