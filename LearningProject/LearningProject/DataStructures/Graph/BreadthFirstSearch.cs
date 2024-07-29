using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.DataStructures.Graph
{
    public class BreadthFirstSearch
    {
        public BreadthFirstSearch()
        {
            IsValidPath();
        }

        public void BFSRun()
        {
            List<List<int>> adjacency = new List<List<int>>()
            {
                new List<int> { 1,2 },
                new List<int> { 0, 2 , 3 },
                new List<int> { 0, 1,3, 4 },
                new List<int> { 1, 2, 4 },
                new List<int> { 2, 3 }
            };

            BFS(adjacency, 5, 0);
        }

        public void IsValidPath()
        {
            //int[][] edges = new int[][]
            //{
            //    new int[]{ 0, 1 },
            //    new int[] { 1, 2 },
            //    new int[] { 2, 0 } };

            //var result = ValidPath(3, edges, 0, 2);

            int[][] edges = new int[][]
            {
                new int[]{ 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 5 },
                new int[] { 5, 4 },
                new int[] { 4, 3 }
            };

            var result = ValidPath(6, edges, 0, 5);
        }

        public void BFS(List<List<int>> adjacency, int v, int s)
        {
            bool[] visited = new bool[5];
            Queue<int> queue = new Queue<int>();

            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count > 0)
            {
                int i = queue.Dequeue();

                Console.WriteLine(i);

                foreach (int j in adjacency[i])
                {
                    if (visited[j] == false)
                    {
                        visited[j] = true;
                        queue.Enqueue(j);
                    }
                }
            }
        }

        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            List<List<int>> adjacency = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                adjacency.Add(new List<int>());
            }

            int length = edges.Length;
            for (int i = 0; i < length; i++)
            {
                int u = edges[i][0];
                int v = edges[i][1];

                adjacency[u].Add(v);
                adjacency[v].Add(u);
            }

            bool[] visited = new bool[n];
            Queue<int> queue = new Queue<int>();

            visited[source] = true;
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                int i = queue.Dequeue();

                Console.WriteLine(i);

                foreach (int j in adjacency[i])
                {
                    if (visited[j] == false)
                    {
                        visited[j] = true;
                        queue.Enqueue(j);
                    }
                }
            }

            return visited[destination];
        }
    }
}
