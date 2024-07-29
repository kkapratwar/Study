using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.LeetCode
{
    public class FloodFill
    {

        public FloodFill()
        {
            int[][] image = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,1,0},
                new int[] {1,0,1}
            };

            // int[][] image = new int[][]
            //{
            //     new int[] {0,0,0},
            //     new int[] {0,0,0},
            //};

            int sr = 1, sc = 1, color = 2;
            //int sr = 1, sc = 0, color = 2;

            FloodFillFunction(image, sr, sc, color);

        }

        public int[][] FloodFillFunction(int[][] image, int sr, int sc, int color)
        {
            int currentColor = image[sr][sc];
            FillColor(image, sr, sc, color, currentColor);

            return image;
        }

        void FillColor(int[][] image, int sr, int sc, int color, int currentColor)
        {
            if (sr >= 0 && sr < image.Length && sc >= 0 && sc < image[sr].Length && image[sr][sc] == currentColor)
            {

                image[sr][sc] = color;

                FillColor(image, sr + 1, sc, color, currentColor);
                FillColor(image, sr - 1, sc, color, currentColor);
                FillColor(image, sr, sc + 1, color, currentColor);
                FillColor(image, sr, sc - 1, color, currentColor);
            }
        }
    }
}
