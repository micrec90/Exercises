namespace LeetCode.Problems
{
    public class SubstringWithConcatenationOfAllWordsSolution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();
            if (s == null || words == null || words.Length == 0)
                return result;

            int wordLen = words[0].Length;
            int numWords = words.Length;
            int totalLen = wordLen * numWords;
            int n = s.Length;

            if (n < totalLen)
                return result;

            var wordCount = new Dictionary<string, int>();
            foreach (var w in words)
            {
                if (!wordCount.ContainsKey(w))
                    wordCount[w] = 0;
                wordCount[w]++;
            }

            for (int i = 0; i < wordLen; i++)
            {
                int left = i;
                int count = 0;
                var currentCount = new Dictionary<string, int>();

                for (int j = i; j <= n - wordLen; j += wordLen)
                {
                    string word = s.Substring(j, wordLen);

                    if (wordCount.ContainsKey(word))
                    {
                        if (!currentCount.ContainsKey(word))
                            currentCount[word] = 0;
                        currentCount[word]++;
                        count++;

                        while (currentCount[word] > wordCount[word])
                        {
                            string leftWord = s.Substring(left, wordLen);
                            currentCount[leftWord]--;
                            left += wordLen;
                            count--;
                        }

                        if (count == numWords)
                        {
                            result.Add(left);
                            string leftWord = s.Substring(left, wordLen);
                            currentCount[leftWord]--;
                            left += wordLen;
                            count--;
                        }
                    }
                    else
                    {
                        currentCount.Clear();
                        count = 0;
                        left = j + wordLen;
                    }
                }
            }

            return result;
        }
    }
}