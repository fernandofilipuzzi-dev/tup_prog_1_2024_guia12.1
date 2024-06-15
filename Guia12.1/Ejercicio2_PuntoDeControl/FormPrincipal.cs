using Ejercicio2_PuntoDeControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2_PuntoDeControl;
using System.Reflection;

namespace Ejercicio2_PuntoDeControl
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
            int modeloVehículo = Convert.ToInt32( tbModelo.Text );
            bool esElectrico = cbkEsElectrico.Checked;

            controlador.RegistrarVehículo(patente, tipoVehículo, modeloVehículo, esElectrico);

            tbPatente.Clear();
            tbModelo.Clear();
            cbTipoVehiculo.SelectedIndex = -1;
            cbkEsElectrico.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResultados fVer = new FormResultados();

            controlador.ListarElectricosOrdenadosPorModelo();

            if (controlador.ContadorElectricos > 0)
            {
                fVer.lbxResultados.Items.Add("Vehículos eléctricos: ");

                for (int n = 0; n < controlador.ContadorElectricos; n++)
                {
                    string patente = controlador.PatentesElectricos[n];
                    int modelo=controlador.ModelosElectricos[n];
                    int tipo=controlador.TiposVehículos[n];

                    fVer.lbxResultados.Items.Add($"\t{patente} - {modelo} - {tipo}");
                }
            }
            else
            {
                fVer.lbxResultados.Items.Add($"Aún no se registraron vehículos");
            }

            fVer.ShowDialog();
        }
    }
}
