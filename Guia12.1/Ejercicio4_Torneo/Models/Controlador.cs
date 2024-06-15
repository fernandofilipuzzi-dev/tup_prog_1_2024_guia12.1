using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Torneo.Models
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];

        //fila : es el numero de jugador ; columna el número de partido
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
        }

        public void FinalizarPartido()
        {
            ContadorPartidos++;
        }

        public int[] ListarPuntosPorJugador(int numeroJugador)
        {
            int[] puntos = new int[ContadorPartidos];
            for (int partido = 0; partido < ContadorPartidos; partido++)
            {
                puntos[partido]= Puntos[numeroJugador,partido ];//fila : es el numero de jugador ; columna el número de partido
            }
            return puntos;
        }


        public int[] ListarPuntosPorPartido(int numeroPartido)
        {
            int[] puntos = new int[ContadorJugadores];
            for (int jugador = 0; jugador < ContadorJugadores; jugador++)
            {
                puntos[jugador] = Puntos[jugador, numeroPartido];//fila : es el numero de jugador ; columna el número de partido
            }
            return puntos;
        }
    }
}
