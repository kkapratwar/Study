namespace LearningProject.LeetCode
{
    internal class CountBlobsInBinaryImage
    {
        /*
        We will count the number of blobs in a binary image. A blob is a set of connected "1" pixels in the image; we will ignore "0"s.
        Our rule for defining blobs is that they are made up of pixels that are touching in cardinal directions (left, right, up, or down), not diagonally.
        Goals:
        - Fix bugs and count blobs (unit tests 1-7)
        - Support minimumSize (unit test 8)

        Depth-first search algorithm
        - Scan the image (e.g. top to bottom, left to right)
        - When we find a pixel, immediately stop scanning and "visit" the pixel.
        - Every time we visit a pixel, mark it visited so we don't visit it again.
        - When visiting a pixel, also visit all of the pixel's cardinally-connected neighbors.

         * Example grid containing 3 blobs (labels are for ease of reading only)
         * grid = [
         *     "00010", # | | | |A| |
         *     "01101", # | |B|B| |B|
         *     "00111", # | | |B|B|B|
         *     "11010", # |C|C| |B| |
         *     "11000"  # |C|C| | | |
         * ]
         */

        public int solution(string[] grid, int minimumSize)
        {
            int n = 0;

            bool[][] visits = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                visits[i] = new bool[grid[i].Length];
            }

            for (int i = 0; i < visits.Length; i++)
            {
                for (int j = 0; j < visits[i].Length; j++)
                {
                    if (visits[i][j] == true)
                        continue;

                    if (grid[i][j] == '1')
                    {
                        n += 1;
                        f(grid, i, j, visits);
                    }
                }
            }

            return n;
        }

        void f(string[] grid, int i, int j, bool[][] visits)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
                return;

            if (visits[i][j])
                return;

            grid[i] = grid[i].Remove(j, 1);
            grid[i] = grid[i].Insert(j, "0");

            f(grid, i + 1, j, visits);
            f(grid, i - 1, j, visits);
            f(grid, i, j + 1, visits);
            f(grid, i, j - 1, visits);

            visits[i][j] = true;
        }
    }
}
