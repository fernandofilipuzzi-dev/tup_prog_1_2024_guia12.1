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
        public int [] Modelos = new int[1000];
        public bool[] SonElectricos = new bool[1000];
        public int Contador = 0;

        public void RegistrarVehículo(string patente, int tipo, int modelo, bool esElectrico)
        {
            Patentes[Contador] = patente;
            TiposVehículos[Contador] = tipo;
            Modelos[Contador] = modelo;
            SonElectricos[Contador] = esElectrico;           
            Contador++;
        }

        public string[] PatentesElectricos = new string[1000];
        public int[] TiposVehículosElectricos = new int[1000];
        public int[] ModelosElectricos = new int[1000];
        public int ContadorElectricos = 0;

        public void ListarElectricosOrdenadosPorModelo() 
        {
            ContadorElectricos = 0;//es importante poner en cero aquí

            for (int n = 0; n < Contador; n++) 
            {
                if (SonElectricos[n] == true)
                {
                    PatentesElectricos[ContadorElectricos] = Patentes[n];
                    ModelosElectricos[ContadorElectricos] = Modelos[n];
                    TiposVehículosElectricos[ContadorElectricos] = TiposVehículosElectricos[n];
                    ContadorElectricos++;//no olvidarse este detallito
                }
            }

            OrdenarElectricos();
        }

        public void OrdenarElectricos()
        {
            for (int n = 0; n < ContadorElectricos - 1; n++)
            {
                for (int m = n + 1; m < ContadorElectricos; m++)
                {
                    if (ModelosElectricos[n] > ModelosElectricos[m])
                    {
                        string patente = PatentesElectricos[m];
                        PatentesElectricos[m] = PatentesElectricos[n];
                        PatentesElectricos[n] = patente;

                        int modelo = ModelosElectricos[m];
                        ModelosElectricos[m] = ModelosElectricos[n];
                        ModelosElectricos[n] = modelo;

                        int tipoVehículomodelo = TiposVehículosElectricos[m];
                        TiposVehículosElectricos[m] = TiposVehículosElectricos[n];
                        TiposVehículosElectricos[n] = tipoVehículomodelo;
                    }
                }
            }
        }
    }
}
