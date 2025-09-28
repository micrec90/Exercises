using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class JewelsAndStonesSolution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> jewelsSet = new HashSet<char>(jewels);
            int jewelsCount = 0;

            foreach (char stone in stones)
                if(jewelsSet.Contains(stone))
                    jewelsCount++;
            return jewelsCount;
        }
    }
}
