namespace LearningProject.LeetCode
{
    public class CourseSchedule
    {
        public CourseSchedule()
        {
            int numCourses = 5;
            int[][] prerequisites = new int[][]
            {
                new int[] {0,1},
                new int[] {1,2},
                new int[] {2,0},
                new int[] {2,3},
                new int[] {3,4},
            };

            var result = CanFinish(numCourses, prerequisites);
        }

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            bool[] visited = new bool[numCourses];

            List<List<int>> adjacency = new List<List<int>>();
            int length = numCourses;

            for (int i = 0; i < length; i++)
            {
                adjacency.Add(new List<int>());
            }

            for (int i = 0; i < prerequisites.Length; i++)
            {
                int u = prerequisites[i][0];
                int v = prerequisites[i][1];

                adjacency[u].Add(v);
                adjacency[v].Add(u);
            }

            var result = DFSRec(adjacency, 0, visited, -1);

            return result;
        }

        bool DFSRec(List<List<int>> adjacency, int node, bool[] visited, int parent)
        {
            visited[node] = true;

            foreach (int i in adjacency[node])
            {
                if (visited[i] == false)
                {
                    if (DFSRec(adjacency, i, visited, node))
                    {
                        return true;
                    }
                }
                else if (i != parent)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
