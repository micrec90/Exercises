using System.Text;

namespace LeetCode.Problems
{
    public class ZigzagConversionSolution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length)
                return s;

            var rows = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
                rows[i] = new StringBuilder();

            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow].Append(c);
                if (currentRow == 0 || currentRow == numRows - 1)
                    goingDown = !goingDown;
                currentRow += goingDown ? 1 : -1;
            }

            var result = new StringBuilder();
            foreach (var row in rows)
                result.Append(row);

            return result.ToString();
        }
    }
}
