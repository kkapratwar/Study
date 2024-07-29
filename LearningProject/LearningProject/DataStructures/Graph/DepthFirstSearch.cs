namespace LearningProject.DataStructures.Graph
{
    public class DepthFirstSearch
    {
        public DepthFirstSearch()
        {
            DFSTraversal();
        }

        public void DFSTraversal()
        {
            int n = 8;
            bool[] visited = new bool[n+1];

            List<List<int>> adjacency = new List<List<int>>()
            {
                new List<int> { 0,1,2 },
                new List<int> { 1, 3, 4 },
                new List<int> { 0, 3 },
                new List<int> { 1, 4 },
                new List<int> {  },
                new List<int> { 6},
                new List<int> { 7},
                new List<int> { },
            };

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    DFSRec(adjacency, i, visited);
                }
            }
        }

        public void DFSRec(List<List<int>> adjacency, int s, bool[] visited)
        {
            visited[s] = true;

            Console.WriteLine(s);

            for (int i = 0; i < adjacency[s].Count; i++)
            {
                if (!visited[adjacency[s][i]])
                {
                    DFSRec(adjacency, adjacency[s][i], visited);
                }
            }
        }

    }
}
