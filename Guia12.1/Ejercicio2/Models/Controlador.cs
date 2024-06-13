using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Controlador
    {
        public string[] Patentes=new string[1000];
        public int [] TiposVehículos = new int[1000];
        public bool[] EsElectrico = new bool[1000];
        public int Contador = 0;

        public void RegistrarVehículo(string patente, int tipo, bool esElectrico)
        {
            Patentes[Contador] = patente;
            TiposVehículos[Contador] = tipo;
            EsElectrico[Contador] = esElectrico;
            Contador++;
        }

        public void ListarElectricosOrdenados() 
        {
        }
    }
}
