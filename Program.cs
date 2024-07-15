using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo test = new Grafo(9);
            /*
            test.matriz = new int[,]{
                                      { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };*/

            test.CrearArista(0, 1, 4, false);
            test.CrearArista(0, 7, 8, false);            
            test.CrearArista(1, 2, 8, false);
            test.CrearArista(1, 7, 11, false);
            test.CrearArista(2, 3,7, false);
            test.CrearArista(2, 5, 4, false);
            test.CrearArista(2, 8, 2, false);
            test.CrearArista(3,4,9,false);
            test.CrearArista(3,5,14,false);
            test.CrearArista(4, 5, 10, false);
            test.CrearArista(5, 6, 2, false);
            test.CrearArista(6,7,1,false);
            test.CrearArista(6, 8, 6, false);
            test.CrearArista(7, 8, 7, false);

            test.Dijkstra(0);
        }
    }
}
