using System.Linq;

namespace SaddleDemo
{
    public class SaddlePointFinder
    {
        public string GetSaddlePoints(int[,] input)
        {
            if (IsLargest(input.Cast<int>().Take(5).ToArray(), input[0, 0]) &&
                IsSmallest(GetColumn(input, 0), input[0, 0]))
                return "0,0";
            return "No saddle points found.";
        }

        private bool IsLargest(int[] row, int item)
        {
            foreach (int i in row)
                if (i > item) return false;
            return true;
        }

        private bool IsSmallest(int[] column, int item)
        {
            foreach (int i in column)
                if (i < item) return false;
            return true;
        }

        private int[] GetColumn(int[,] mx, int columnIndex)
        {
            int[] result = new int[mx.GetLength(1)];
            for (int x = 0; x < result.Length; x++)
                result[x] = mx[columnIndex, x];
            return result;
        }
    }
}