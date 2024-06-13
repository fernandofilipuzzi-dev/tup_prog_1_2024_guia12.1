using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Controlador controlador = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            int tipoVehículo=cbTipoVehiculo.SelectedIndex;
            bool esElectrico = checkBox1.Checked;

            controlador.RegistrarVehículo(patente,tipoVehículo, esElectrico);
        }
    }
}
