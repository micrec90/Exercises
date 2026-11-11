namespace LeetCode.Problems
{
    public class StringToIntegerSolution
    {
        public int MyAtoi(string s)
        {
            int i = 0;
            int n = s.Length;

            while (i < n && s[i] == ' ')
                i++;

            int sign = 1;
            if (i < n && (s[i] == '-' || s[i] == '+'))
            {
                if (s[i] == '-')
                    sign = -1;
                i++;
            }

            int result = 0;
            while (i < n && char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                if (result > (int.MaxValue - digit) / 10)
                    return sign == 1 ? int.MaxValue : int.MinValue;

                result = result * 10 + digit;
                i++;
            }

            return sign * result;
        }
    }
}
