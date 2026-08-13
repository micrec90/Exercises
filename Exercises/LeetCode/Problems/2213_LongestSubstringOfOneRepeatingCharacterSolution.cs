namespace LeetCode.Problems
{
    public class LongestSubstringOfOneRepeatingCharacterSolution
    {
        private char[] arr;
        private int[] segLen, prefLen, sufLen, maxLen;
        private int n;

        public int[] LongestRepeating(string s, string queryCharacters, int[] queryIndices)
        {
            n = s.Length;
            arr = s.ToCharArray();
            int size = 4 * n;
            segLen = new int[size];
            prefLen = new int[size];
            sufLen = new int[size];
            maxLen = new int[size];

            Build(1, 0, n - 1);

            int k = queryCharacters.Length;
            int[] result = new int[k];

            for (int i = 0; i < k; i++)
            {
                int idx = queryIndices[i];
                char c = queryCharacters[i];
                arr[idx] = c;
                Update(1, 0, n - 1, idx, c);
                result[i] = maxLen[1];
            }

            return result;
        }

        private void Build(int node, int l, int r)
        {
            if (l == r)
            {
                segLen[node] = 1;
                prefLen[node] = 1;
                sufLen[node] = 1;
                maxLen[node] = 1;
                return;
            }
            int mid = (l + r) / 2;
            int left = 2 * node, right = 2 * node + 1;
            Build(left, l, mid);
            Build(right, mid + 1, r);
            Merge(node, left, right, l, mid, r);
        }

        private void Update(int node, int l, int r, int idx, char c)
        {
            if (l == r)
            {
                segLen[node] = 1;
                prefLen[node] = 1;
                sufLen[node] = 1;
                maxLen[node] = 1;
                return;
            }
            int mid = (l + r) / 2;
            int left = 2 * node, right = 2 * node + 1;
            if (idx <= mid)
                Update(left, l, mid, idx, c);
            else
                Update(right, mid + 1, r, idx, c);
            Merge(node, left, right, l, mid, r);
        }

        private void Merge(int node, int left, int right, int l, int mid, int r)
        {
            int leftLen = mid - l + 1;
            int rightLen = r - mid;

            segLen[node] = leftLen + rightLen;

            char leftEndChar = arr[mid];
            char rightStartChar = arr[mid + 1];

            prefLen[node] = prefLen[left];
            if (prefLen[left] == leftLen && leftEndChar == rightStartChar)
                prefLen[node] += prefLen[right];

            sufLen[node] = sufLen[right];
            if (sufLen[right] == rightLen && leftEndChar == rightStartChar)
                sufLen[node] += sufLen[left];

            maxLen[node] = Math.Max(maxLen[left], maxLen[right]);
            if (leftEndChar == rightStartChar)
                maxLen[node] = Math.Max(maxLen[node], sufLen[left] + prefLen[right]);
        }
    }
}