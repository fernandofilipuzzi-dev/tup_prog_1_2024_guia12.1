using Ejercicio3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        Controlador controlador=new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            FormAgregar fAgregar = new FormAgregar();

            if (fAgregar.ShowDialog() == DialogResult.OK) 
            {
                int id = Convert.ToInt32(fAgregar.numericUpDown1.Value);
                string origen = fAgregar.comboBox1.Text;
                double peso = Convert.ToDouble(fAgregar.numericUpDown2.Value);

                controlador.AgregarContenedor(id , origen, peso);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormVer fVer = new FormVer();

            string pais = cbBuscar.Text;

            controlador.BuscarPorOrigen(pais);

            if (controlador.ContadorBusqueda > 0)
            {
                for (int n = 0; n < controlador.ContadorBusqueda; n++)
                {
                    fVer.lbxResultados.Items.Add($"{controlador.IDsBusqueda} - {controlador.OrigenesBusqueda}- {controlador.PesosBusqueda:f2}");
                }
            }
            else
            {
                fVer.lbxResultados.Items.Add($"No se encontró un registro para el origen: {pais}");
            }
            

            fVer.ShowDialog();
        }

        private void VerListado_Click(object sender, EventArgs e)
        {
            FormVer fVer = new FormVer();

            if (controlador.Contador > 0)
            {
                for (int n = 0; n < controlador.Contador; n++)
                {
                    fVer.lbxResultados.Items.Add($"{controlador.IDs[n]} - {controlador.Origenes[n]}- {controlador.Pesos[n]:f2}");
                }
            }
            else
            {
                fVer.lbxResultados.Items.Add($"No aún registro de contenedores");
            }


            fVer.ShowDialog();
        }
    }
}
