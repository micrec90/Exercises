namespace LeetCode.Problems
{
    public class MaximizeActiveSectionWithTradeSolution
    {
        public int MaxActiveSectionsAfterTrade(string s)
        {
            int n = s.Length;

            int totalOnes = 0;
            int zerosBefore = 0;
            int bestGain = 0;

            int i = 0;
            while (i < n)
            {
                int onesInRun = 0;
                while (i < n && s[i] == '1')
                {
                    totalOnes++;
                    onesInRun++;
                    i++;
                }

                int zerosAfter = 0;
                while (i < n && s[i] == '0')
                {
                    zerosAfter++;
                    i++;
                }

                if (zerosBefore > 0 && onesInRun > 0 && zerosAfter > 0)
                {
                    int gain = zerosBefore + zerosAfter;
                    if (gain > bestGain)
                        bestGain = gain;
                }

                zerosBefore = zerosAfter;
            }

            return totalOnes + bestGain;
        }
    }
}