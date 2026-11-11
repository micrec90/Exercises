using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            string answer = "";

            int indexa = a.Length - 1;
            int indexb = b.Length - 1;
            int carry = 0;

            while (indexa >= 0 || indexb >= 0 || carry > 0)
            {
                carry += indexa >= 0 ? a[indexa--] - '0' : 0;
                carry += indexb >= 0 ? b[indexb--] - '0' : 0;

                answer += carry % 2;
                carry /= 2;
            }
            return new string(answer.Reverse().ToArray());
        }
    }
}
