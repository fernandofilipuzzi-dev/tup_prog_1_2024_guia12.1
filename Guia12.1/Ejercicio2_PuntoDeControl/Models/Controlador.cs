using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_PuntoDeControl.Models
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

        public string[] PatentesElectricos = new string[1000];
        public int[] TiposVehículosElectricos = new int[1000];
        public int ContadorElectricos = 0;
        public void ListarElectricosOrdenados() 
        {
            ContadorElectricos = 0;//es importante poner en cero aquí
            for (int n = 0; n < Contador; n++) 
            {
                if (EsElectrico[n] == true)
                {
                    PatentesElectricos[ContadorElectricos] = Patentes[n];
                    TiposVehículosElectricos[ContadorElectricos] = TiposVehículosElectricos[n];
                    ContadorElectricos++;//no olvidarse este detallito
                }
            }
        }
    }
}
