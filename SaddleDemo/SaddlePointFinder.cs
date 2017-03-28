using System.Linq;
using System.Text;

namespace SaddleDemo
{
    public class SaddlePointFinder
    {
        public string GetSaddlePoints(int[,] input)
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < input.GetLength(1); y++)
            {
                for (int x = 0; x < input.GetLength(0); x++)
                {
                    if (IsLargest(input.Cast<int>().Skip(y*5).Take(5).ToArray(), input[y, x]) &&
                        IsSmallest(GetColumn(input, x), input[y, x]))
                        sb.AppendLine(y.ToString() + "," + x.ToString());
                }
            }

            if (sb.Length == 0) sb.Append("No saddle points found.");
            return sb.ToString().TrimEnd();
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
                result[x] = mx[x, columnIndex];
            return result;
        }
    }
}