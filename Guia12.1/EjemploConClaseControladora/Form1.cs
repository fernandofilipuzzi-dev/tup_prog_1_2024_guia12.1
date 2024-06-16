
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EjemploConClaseControladora.Models;

namespace EjemploConClaseControladora
{
    public partial class Form1 : Form
    {
        #region variables y metodos del dominio
        Controlador c = new Controlador();
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDato formDato = new FormDato();

            if (formDato.ShowDialog() == DialogResult.OK)
            {
                int numero = Convert.ToInt32(formDato.textBox1.Text);

                c.AgregarNumero(numero);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double promedio = c.CalcularPromedio();

            FormVer formVer = new FormVer();

            formVer.listBox1.Items.Add($"Promedio: {promedio:f2}");

            formVer.ShowDialog();
        }
    }
}
