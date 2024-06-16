using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Huanguelen.Models
{
    public class Controlador
    {
        public int[] NumerosGuia = new int[1000];
        public int[] NumerosEstablecimiento = new int[1000];
        public int[] CantidadesVacas = new int[1000];
        public int[] CantidadesToros = new int[1000];
        public int[] CantidadesNovillo = new int[1000];
        public int[] CantidadesVaquillona = new int[1000];
        public int ContadorEmbarques = 0;

        public void RegistrarGuia(int nroGuia, int nroEstablecimiento, int vacas, 
                                        int toros, int novillos, int vaquillonas)
        {
            NumerosGuia[ContadorEmbarques] = nroGuia;
            NumerosEstablecimiento[ContadorEmbarques] = nroEstablecimiento;
            CantidadesVacas[ContadorEmbarques] = vacas;
            CantidadesToros[ContadorEmbarques] = toros;
            CantidadesNovillo[ContadorEmbarques] = novillos;
            CantidadesVaquillona[ContadorEmbarques] = vaquillonas;

            ContadorEmbarques++;
        }

        public int BuscarPorNumeroGuia(int guia)
        {
            int idx = -1;
            int emb = 0;//recorro embarques
            while (emb < ContadorEmbarques)
            {
                if (NumerosGuia[emb] == guia)
                {
                    idx = emb;
                }

                emb++;
            }
            return idx;
        }

        public int[] BuscarPorNumeroEstablecimiento(int establecimiento, ref int coincidencias)
        {
            int[] idxs = new int[1000];
            coincidencias = 0;
            
            int establIdx = 0;
            while (establIdx < ContadorEmbarques)
            {
                if (NumerosEstablecimiento[establIdx] == establecimiento)
                {
                    
                    idxs[coincidencias] = establIdx;
                    coincidencias++;
                }

                establIdx++;
            }
           
            return idxs;
        }
    }
}
