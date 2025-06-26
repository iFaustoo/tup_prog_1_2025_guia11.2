using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Servicio
    {
        public int[] Lista = new int[1000];
        public int Contador = 0;

        public Servicio()
        {
            Contador = 0;
            Lista = new int[1000];
        }

        public void RegistrarValor(int valor)
        {
            Lista[Contador] = valor;
            Contador++;
        }

        public double CalcularPromedio()
        {
            int acumulador = 0;
            double promedio = 0;

            for (int i = 0; i < Contador; i++)
            {
                acumulador += Lista[i];
            }
            if (Contador > 0)
            {
                promedio = (double)1.0 * (acumulador / Contador);
            }
            return promedio;
        }

        public double CalcularMaximo()
        {
            int maximo = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (i == 0 || Lista[i] > maximo)
                {
                    maximo = Lista[i];
                }
            }
            return maximo;
        }

        public double CalcularMinimo()
        {
            int minimo = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (i == 0 || Lista[i] < minimo)
                {
                    minimo = Lista[i];
                }
            }
            return minimo;
        }

        public void OrdenarLista()
        {
            for (int i = 0; i < Lista.Length; i++)
            {
                for (int j = i; j < Lista.Length; j++)
                {
                    Intercambiar(i, j);
                }
            }
        }

        public void Intercambiar(int i, int j)
        {
            int aux = Lista[i];
            Lista[i] = Lista[j];
            Lista[j] = aux;
        }

        public int BuscarValor(int buscado)
        {
            int idx = -1;
            int n = 0;
            while (n < Contador && idx == -1)
            {
                if (Lista[n] == buscado)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        public int[] ListaSuperioresAlPromedio(out int contadorSuperiores)
        {
            double promedio = CalcularPromedio();

            int[] superiores = new int[Contador];
            contadorSuperiores = 0;
            for (int i = 0; i < Contador; i++)
            {
                if (Lista[i] > promedio)
                {
                    superiores[contadorSuperiores] = Lista[i];
                    contadorSuperiores++;
                }
            }
            return superiores;
        }
    }
}
