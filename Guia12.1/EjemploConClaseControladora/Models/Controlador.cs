using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConClaseControladora.Models
{
    public class Controlador
    {
        public int[] Numeros = new int[1000];
        public int Contador = 0;

        public void AgregarNumero(int nro)
        {
            Numeros[Contador] = nro;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double acum = 0;
            double promedio = 0;
            for (int n = 0; n < Contador; n++)
            {
                acum += Numeros[n];
            }
            if (Contador > 0)
                promedio = acum / Contador;

            return promedio;
        }
    }
}
