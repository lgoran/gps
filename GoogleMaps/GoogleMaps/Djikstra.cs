using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMaps
{
    public class Djikstra
    {
        private static readonly int NO_PARENT = -1;
        public double[] dist;
        int V;
        public List<int> path;

        public Djikstra(int brojVrhova)
        {
            path = new List<int>();
            V = brojVrhova;
            dist = new double[brojVrhova];
            for (int i = 0; i < brojVrhova; i++)
                dist[i] = Double.MaxValue;
        }
    
        private int Distance (bool[] Visited)
        {
            int index = -1;
            double minValue = double.MaxValue;

            for (int i = 0; i < V; i++)          
                if (Visited[i] == false && dist[i] < minValue)
                {
                    minValue = dist[i];
                    index = i;
                }
            
            return index;
        }

        private void RekreirajPut (int [] parent, int end)
        {
            if (parent[end] == -1)
                return;

            RekreirajPut(parent, parent[end]);
            path.Add(end);

        }
        public bool djikstraAlgorithm (List< List<double> > Graph, int start, int end)
        {
            bool[] visited = new bool[V];
            // svakom cvoru spremamo njegovog "roditelja" da bi mogli rekreirati put
            int[] parent = new int[V];

            for (int i = 0; i < V; i++)
                visited[i] = false;

            parent[start] = NO_PARENT;
            dist[start] = 0;

            for (int i = 0; i < V - 1; i++)
            {
                int cvor = Distance(visited);
                if(cvor==-1)
                {
                    return false;
                }
                visited[cvor] = true;

                for (int v = 0; v < V; v++)
                    // Update dist[v] only if is not 
                    // visited, there is an edge from u 
                    // to v, and total weight of path 
                    // from start to v through u is smaller 
                    // than current value of dist[v] 
                    if (!visited[v] && Graph[cvor][v] != 0 && dist[cvor] != double.MaxValue &&
                        dist[cvor] + Graph[cvor][v] < dist[v])
                    {
                        dist[v] = dist[cvor] + Graph[cvor][v];
                        parent[v] = cvor;
                    }
            }

            path.Add(start);
            RekreirajPut(parent, end);
            return true;
        }
    }
}
