using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_ControlEmbarque.Models
{
    public class Controlador
    {
        public int [] IDs=new int[1000];
        public string[] Origenes = new string[1000];
        public double[] Pesos = new double[1000];
        public int Contador = 0;

        public void AgregarContenedor(int Id, string pais, double peso) 
        {
            IDs[Contador] = Id;
            Origenes[Contador] = pais;
            Pesos[Contador] = peso;
            Contador++;
        }

        #region relativo a la búsqueda
        public int[] IDsBusqueda = new int[1000];
        public string[] OrigenesBusqueda = new string[1000];
        public double[] PesosBusqueda = new double[1000];
        public int ContadorBusqueda;
        public void BuscarPorOrigen(string pais)
        {
            ContadorBusqueda = 0;//importante poner a cero aquí
            for (int n = 0; n < Contador; n++)
            {
                if (pais == Origenes[n])
                {
                    IDsBusqueda[ContadorBusqueda] = IDs[n];
                    OrigenesBusqueda[ContadorBusqueda] = OrigenesBusqueda[n];
                    PesosBusqueda[ContadorBusqueda] = PesosBusqueda[n];
                    ContadorBusqueda++;
                }
            }
        }
        #endregion
    }
}
