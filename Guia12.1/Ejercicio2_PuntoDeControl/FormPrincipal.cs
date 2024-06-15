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
            bool esElectrico = cbkEsElectrico.Checked;

            controlador.RegistrarVehículo(patente,tipoVehículo, esElectrico);

            tbPatente.Clear();
            cbTipoVehiculo.SelectedIndex = -1;
            cbkEsElectrico.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormResultados fVer = new FormResultados();

            if (controlador.Contador > 0)
            {
                for (int n = 0; n < controlador.Contador; n++)
                {
                    string esElectrivo = "No es eléctrico";
                    if(controlador.EsElectrico[n]==true)
                    {
                        esElectrivo = "Es eléctrico";
                    }

                    fVer.lbxResultados.Items.Add($"{controlador.Patentes[n]} - {controlador.TiposVehículos[n]} - {esElectrivo}");
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
