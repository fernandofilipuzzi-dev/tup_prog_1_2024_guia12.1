using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.Models
{
    public class Competencia
    {
        public string[] Nombres = new string[100];
        public int [] Tiempos= new int[100];
        public int Contador = 0;

        public void AgregarCompetidor(string nombre)
        {
            Nombres[Contador] = nombre;
            Contador++;
        }

        public void CargarTiempo(int numeroCompetidor, int HH, int MM)
        {
            Tiempos[numeroCompetidor] = HH*60+MM;
        }

        public void OrderListadoPorTiempo()
        {
            for (int act = 0; act < Contador-1; act++)
            {
                for (int sig = act+1; sig < Contador; sig++)
                {
                    if (Tiempos[act] > Tiempos[sig])
                    {
                        string nombre = Nombres[act];
                        Nombres[act] = Nombres[sig];
                        Nombres[sig] = nombre;

                        int tiempo = Tiempos[act];
                        Tiempos[act] = Tiempos[sig];
                        Tiempos[sig] = tiempo;
                    }
                }
            }
        }
    }
}
