using Ejercicio5_Huanguelen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_Huanguelen
{
    public partial class FormPrincipal : Form
    {
        Controlador c=new Controlador();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresarEmbarque_Click(object sender, EventArgs e)
        {

            FormRegistroCategoria formRegistroCategoria = new FormRegistroCategoria();

            int guia = Convert.ToInt32(tbGuia.Text);
            int establecimiento = Convert.ToInt32(tbEstablecimiento.Text);

            int vacas = 0;
            int toros = 0;
            int novillos = 0;
            int vaquillonas = 0;

            int embarque = c.BuscarPorNumeroGuia(guia);
            if (embarque < 0) //verifico si existe
            {

                int cate = 0;
                while (cate < 4 && formRegistroCategoria.ShowDialog() == DialogResult.OK)
                {
                    switch (cate)
                    {
                        case 0:
                            {
                                vacas = Convert.ToInt32(formRegistroCategoria.nudCantidad.Value);
                            }
                            break;
                        case 1:
                            {
                                toros = Convert.ToInt32(formRegistroCategoria.nudCantidad.Value);
                            }
                            break;
                        case 2:
                            {
                                novillos = Convert.ToInt32(formRegistroCategoria.nudCantidad.Value);
                            }
                            break;
                        case 3:
                            {
                                vaquillonas = Convert.ToInt32(formRegistroCategoria.nudCantidad.Value);
                            }
                            break;
                    }
                    cate++;
                }

                if (cate == 4)
                {
                    c.RegistrarGuia(guia, establecimiento, vacas, toros, novillos, vaquillonas);
                    MessageBox.Show("Registro agregado");
                }
                else
                {
                    MessageBox.Show("Registro Cancelado");
                }
            }
            else
            {
                MessageBox.Show($"El embarque con guía {guia} existe!");
            }

            tbGuia.Clear();
            tbEstablecimiento.Clear();
        }

        private void BuscarPor_Click(object sender, EventArgs e)
        {

            FormResultados formVer = new FormResultados();

            if (rbPorGuia.Checked == true)
            {
                //falta ordenar

                int guia = Convert.ToInt32(tbBuscarGuiaOEstablecimiento.Text);
                int idx = c.BuscarPorNumeroGuia(guia);

                if (idx > -1)
                {
                    #region datos del embarque encontrado
                    int establecimiento = c.NumerosEstablecimiento[idx];

                    int vacas = c.CantidadesVacas[idx];
                    int toros = c.CantidadesToros[idx];
                    int novillos = c.CantidadesNovillo[idx];
                    int vaquillonas = c.CantidadesVaquillona[idx];
                    #endregion

                    formVer.listBox1.Items.Add($"Embarque(Guía de traslado):{guia}");
                    formVer.listBox1.Items.Add($"Establecimiento: {establecimiento}");
                    formVer.listBox1.Items.Add($"\tVacas: {vacas}");
                    formVer.listBox1.Items.Add($"\tToros: {toros}");
                    formVer.listBox1.Items.Add($"\tVacas: {novillos}");
                    formVer.listBox1.Items.Add($"\tVaquillonas: {vaquillonas}");
                }
                else
                {
                    formVer.listBox1.Items.Add($"No encontró el registro para la guía de embarque ingresada: {guia}");
                }

            }
            else if (rbEstablecimiento.Checked == true)
            {
                int establecimiento = Convert.ToInt32(tbBuscarGuiaOEstablecimiento.Text);
                int coincidencias = 0;
                int[] idxS = c.BuscarPorNumeroEstablecimiento(establecimiento, ref coincidencias);

                if (coincidencias > 0)
                {
                    for (int n = 0; n < coincidencias; n++)
                    {
                        int idx = idxS[n];

                        #region datos del embarque encontrado
                        int guia = c.NumerosGuia[idx];
                        int vacas = c.CantidadesVacas[idx];
                        int toros = c.CantidadesToros[idx];
                        int novillos = c.CantidadesNovillo[idx];
                        int vaquillonas = c.CantidadesVaquillona[idx];
                        #endregion

                        formVer.listBox1.Items.Add($"Embarque(Guía de traslado):{guia}");
                        formVer.listBox1.Items.Add($"Establecimiento: {establecimiento}");
                        formVer.listBox1.Items.Add($"\tVacas: {vacas}");
                        formVer.listBox1.Items.Add($"\tToros: {toros}");
                        formVer.listBox1.Items.Add($"\tVacas: {novillos}");
                        formVer.listBox1.Items.Add($"\tVaquillonas: {vaquillonas}");
                    }
                }
                else 
                {
                    formVer.listBox1.Items.Add($"No hubo coincidencias con el Establecimiento: {establecimiento}");
                }
            }
            else 
            {
                formVer.listBox1.Items.Add("seleccione una opción");
            }

            formVer.ShowDialog();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            FormResultados formVer = new FormResultados();

            if (c.ContadorEmbarques > 0)
            {
                for (int n = 0; n < c.ContadorEmbarques; n++)
                {
                    
                    #region datos del embarque encontrado
                    int guia = c.NumerosGuia[n];
                    int establecimiento = c.NumerosEstablecimiento[n];
                    int vacas = c.CantidadesVacas[n];
                    int toros = c.CantidadesToros[n];
                    int novillos = c.CantidadesNovillo[n];
                    int vaquillonas = c.CantidadesVaquillona[n];
                    #endregion

                    formVer.listBox1.Items.Add(
$"Embarque(Guía de traslado):{guia}, Establecimiento: {establecimiento} - Vacas:({vacas}) - Toros ({toros}) - Novillos({novillos})- Vaquillonas({vaquillonas})"
                        );
                }
            }
            else
            {
                formVer.listBox1.Items.Add("No se han cargado registros.");
            }

            formVer.ShowDialog(); 
        }
    }
}
