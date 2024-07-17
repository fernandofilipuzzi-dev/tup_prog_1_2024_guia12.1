using Ejercicio6_Factura.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_Factura
{
    public partial class FormPrincipal : Form
    {
        Controlador c = new Controlador();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            FormFactura formFactura = new FormFactura();
            double total=0;
            while (formFactura.ShowDialog()==DialogResult.Retry)
            {
                int codigo = Convert.ToInt32(formFactura.tbCodigo.Text);
                int cantidad = Convert.ToInt32(formFactura.tbCantidad.Text);

                int idx = c.BuscarProducto(codigo);
                if (idx == -1)
                {
                    MessageBox.Show("no encontrado");
                }
                else 
                {
                    double ud = c.PreciosUd[idx];
                    formFactura.lbPrecioUd.Text = ud.ToString("0.00");

                    double precioTotalItems = ud * cantidad;
                    
                    listBox1.Items.Add($"{codigo} {cantidad} {ud} {precioTotalItems}");

                    total += precioTotalItems;
                }
            }

            if (formFactura.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add($"Total a pagar: ${total}");

                c.RecaudacionTotal += total;
            }
            else
                listBox1.Items.Clear();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            c.AgregarProducto(234, 20.2);
            c.AgregarProducto(236, 23.2);
            c.AgregarProducto(237, 10.2);
        }

        private void btnRecaudacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Recaudación total: ${c.RecaudacionTotal:f2}");
        }
    }
}
