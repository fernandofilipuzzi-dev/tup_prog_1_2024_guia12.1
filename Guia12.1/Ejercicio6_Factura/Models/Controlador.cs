using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Factura.Models
{
    public class Controlador
    {
        public int[] Productos = new int[1000];
        public double[] PreciosUd = new double[1000];
        public int contador=0;

        public double RecaudacionTotal = 0;

        public void AgregarProducto(int codigo, double ud)
        {
            Productos[contador] = codigo;
            PreciosUd[contador] = ud;
            contador++;
        }

        public int BuscarProducto(int codigo)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < contador)
            {
                if (Productos[n] == codigo)
                    idx = n;
                n++;
            }
            return idx;
        }
    }
}
