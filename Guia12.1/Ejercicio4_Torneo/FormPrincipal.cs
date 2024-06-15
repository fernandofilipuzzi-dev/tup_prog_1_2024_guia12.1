using Ejercicio4;
using Ejercicio4_Torneo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Torneo
{
    public partial class FormPrincipal : Form
    {
        Controlador controlador = new Controlador();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            FormInscribirCompetidor fAgregar = new FormInscribirCompetidor();

            if (fAgregar.ShowDialog() == DialogResult.OK)
            {
                string nombre = fAgregar.tbNombre.Text;

                controlador.InscribirJugador(nombre);

                gbCargaPuntosPartido.Enabled = true;

                nudJugador.Maximum = controlador.ContadorJugadores - 1;
            }

            gbCargaPuntosPartido.Text = $"No se han cargado partidos aún";
        }

        private void btnCargarPuntos_Click(object sender, EventArgs e)
        {
            btnInscripcion.Enabled = false;

            FormPuntosTorneo fPuntosTorneo = new FormPuntosTorneo();
                        
            for (int jugador = 0; jugador < controlador.ContadorJugadores; jugador++)
            {
                fPuntosTorneo.lbInstancia.Text = $"Jugador: {jugador} - {controlador.Nombres[jugador]}";

                fPuntosTorneo.ShowDialog();
                int punto = Convert.ToInt32(fPuntosTorneo.nudTorneo.Value);

                controlador.AnotarResultadosPartido(jugador, punto);
            }
            controlador.FinalizarPartido();

            nudPartido.Maximum = controlador.ContadorPartidos-1;

            gbCargaPuntosPartido.Text = $"Último partido cargado: {controlador.ContadorPartidos}";
        }

        private void btnListarPorJugador_Click(object sender, EventArgs e)
        {
            int nroJugador = Convert.ToInt32(nudJugador.Value);

            FormResultados fVer = new FormResultados();

            #region inicialización de ventana
            int[] Puntos=controlador.ListarPuntosPorJugador(nroJugador);

            fVer.lbxResultados.Items.Add($"Jugador: {controlador.Nombres[nroJugador]}");
            for (int partido = 0; partido < controlador.ContadorPartidos; partido++)
            {
                int puntos = Puntos[partido];
                fVer.lbxResultados.Items.Add($"Partido: {partido} - puntos: {puntos}");
            }
            #endregion

            fVer.ShowDialog();
        }

        private void btnListarPorPartido_Click(object sender, EventArgs e)
        {
            int nroPartido = Convert.ToInt32(nudPartido.Value);

            FormResultados fVer = new FormResultados();

            int[] puntos = controlador.ListarPuntosPorJugador(nroPartido);

            #region inicialización ventana
            fVer.lbxResultados.Items.Add($"Partido: {nroPartido}");

            for (int jugador = 0; jugador < controlador.ContadorJugadores; jugador++)
            {
                string nombre = controlador.Nombres[jugador];
                int punto = puntos[jugador];

                fVer.lbxResultados.Items.Add($"Jugador: {nombre} - puntos: {punto}");
            }
            #endregion

            fVer.ShowDialog();
        }
    }
}
