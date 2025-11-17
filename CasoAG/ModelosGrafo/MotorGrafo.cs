using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoAG.ModelosGrafo
{
    public class MotorGrafo
    {
        public Dictionary<string, Dictionary<string, int>> miGrafo;

       public MotorGrafo()
        {
            miGrafo = new Dictionary<string, Dictionary<string, int>>();
        }

        public void AgregarNodo(string nodo)
        {
            if(!miGrafo.ContainsKey(nodo))
            {
                miGrafo.Add(nodo, new Dictionary<string, int>());
            }
        }

        public void AgregarArista(string nodo1, string nodo2, int distancia)
        {
            if(miGrafo.ContainsKey(nodo1) && miGrafo.ContainsKey(nodo2))
            {
                miGrafo[nodo1].Add(nodo2, distancia);
                miGrafo[nodo2].Add(nodo1, distancia);
            }
        }

        public Dictionary<string, int> Adyacencias(string nodo)
        {
            if(miGrafo.ContainsKey(nodo))
            {
                return miGrafo[nodo];
            }
            return new Dictionary<string, int>();
        }

        public List<string> RutaCorta(string inicio, string fin)
        {
            Dictionary<string, int> distancias = new Dictionary<string, int>();

            Dictionary<string, string> anteriores = new Dictionary<string, string>();

            List<string> rutaCercana = new List<string>();

            foreach (string nodo in miGrafo.Keys)
            {
                distancias[nodo] = int.MaxValue;  
                anteriores[nodo] = null;       
                rutaCercana.Add(nodo);            
            }
            distancias[inicio] = 0;

            while (rutaCercana.Count > 0)
            {
                string nodoActual = null;
                int distanciaMasCorta = int.MaxValue;

                foreach (string nodo in rutaCercana)
                {
                    if (distancias[nodo] < distanciaMasCorta)
                    {
                        distanciaMasCorta = distancias[nodo];
                        nodoActual = nodo;
                    }
                }
                rutaCercana.Remove(nodoActual);


                if (nodoActual == fin)
                {
                    break; 
                }

                
                foreach (var vecino in Adyacencias(nodoActual))
                {
                   
                    int distanciaAlVecino = vecino.Value;
                    int nuevaDistancia = distancias[nodoActual] + distanciaAlVecino;

                    if (nuevaDistancia < distancias[vecino.Key])
                    {
                       
                        distancias[vecino.Key] = nuevaDistancia;
                        anteriores[vecino.Key] = nodoActual;
                    }
                }

                

            }
            var ruta = new List<string>();
            var actual = fin;


            while (actual != null && anteriores.ContainsKey(actual))
            {
                ruta.Add(actual);
                actual = anteriores[actual];
            }


            if (actual == inicio)
            {
                ruta.Add(inicio);
            }


            ruta.Reverse();


            if (ruta[0] == inicio)
            {
                return ruta;
            }
            else
            {

                return new List<string>();
            }

        }


        public List<string> ObtenerTodosLosNodos()
        {
            return new List<string>(miGrafo.Keys);
        }

        public bool EsConexo()
        {
            
            if (miGrafo.Count <= 1)
            {
                return true;
            }

            
            string nodoInicial = miGrafo.Keys.First(); 

           
            var visitados = new HashSet<string>();
            var cola = new Queue<string>();

            cola.Enqueue(nodoInicial);
            visitados.Add(nodoInicial);

           
            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();

              
                if (miGrafo.ContainsKey(actual))
                {
                    foreach (var vecino in miGrafo[actual].Keys)
                    {
                        if (!visitados.Contains(vecino))
                        {
                            visitados.Add(vecino);
                            cola.Enqueue(vecino);
                        }
                    }
                }
            }
            return visitados.Count == miGrafo.Count;
        }
    }
}
