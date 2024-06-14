using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];
        public int[,] Puntos = new int[1000,100];
        public int ContadorJugadores = 0;
        public int ContadorPartidos = 0;

        public void InscribirJugador(string nombre)
        {
            Nombres[ContadorJugadores] = nombre;
            ContadorJugadores++;
        }

        public void AnotarResultadosPartido(int numeroJugador, int resultado)
        {
            Puntos[numeroJugador, ContadorPartidos] =resultado;
            ContadorPartidos++;
        }
    }
}
