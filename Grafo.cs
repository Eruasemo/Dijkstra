using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Grafo
    {
        private int vertices;
        private int[,] matriz;

        public Grafo (int vertices)
        {
            this.vertices = vertices;
            this.matriz = new int[vertices, vertices];
        }

        public void CrearArista(int origen, int destino, int costo, bool orden)
        {
            matriz[origen, destino] = costo;
            if (!orden)
            {
                matriz[destino,origen] = costo;
            }
        }

        private int distanciaMin(int[] distancia,
                   bool[] nodos)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int i = 0; i < vertices; i++)
                if (nodos[i] == false && distancia[i] <= min)
                {
                    min = distancia[i];
                    min_index = i;
                }

            return min_index;
        }

        private void imprimir(int[] distancia)
        {
            Console.WriteLine("Vertice \t Distancia desde origen");
            for (int i = 0; i < vertices; i++)
                Console.WriteLine(i + "\t\t" + distancia[i]);
        }

        public void Dijkstra(int origen)
        {
            bool[] nodos = new bool[vertices];
            int[] distancia = new int[vertices];

            for(int i = 0; i < vertices; i++)
            {
                distancia[i] = int.MaxValue;
                nodos[i] = false;
            }

            distancia[origen] = 0;

            for(int i = 0; i < vertices-1; i++)
            {
                int u = distanciaMin(distancia, nodos);

                nodos[u] = true;

                for(int j = 0; j < vertices; j++)
                {
                    if (!nodos[j] && matriz[u,j] != 0&&
                        distancia[u] != int.MaxValue && distancia[u]+ matriz[u,j] < distancia[j])
                    {
                        distancia[j] = distancia[u] + matriz[u,j];
                    }
                }
            }
            imprimir(distancia);

        }
    }
}
