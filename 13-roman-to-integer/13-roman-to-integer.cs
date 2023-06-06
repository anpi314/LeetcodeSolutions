public class Solution {
    public int RomanToInt(string s) {
        
   int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'M')
            {
                if (i > 0 && s[i - 1] == 'C')
                {
                    continue;
                }

                sum += 1000;
                continue;
            }

            if (s[i] == 'D')
            {
                if (i > 0 && s[i - 1] == 'C')
                {
                    continue;
                }

                sum += 500;
                continue;
            }

            if (s[i] == 'C')
            {
                if (i > 0 && s[i - 1] == 'X')
                {
                    continue;
                }

                if (i < s.Length-1 && s[i + 1] == 'D')
                {
                    sum += 400;
                    continue;
                }

                if (i < s.Length-1 && s[i + 1] == 'M')
                {
                    sum += 900;
                    continue;
                }

                sum += 100;
                continue;
            }

            if (s[i] == 'L')
            {
                if (i > 0 && s[i - 1] == 'X')
                {
                    continue;
                }

                sum += 50;
                continue;
            }

            if (s[i] == 'X')
            {
                if (i > 0 && s[i - 1] == 'I')
                {
                    continue;
                }

                if (i < s.Length-1 && s[i + 1] == 'L')
                {
                    sum += 40;
                    continue;
                }

                if (i < s.Length-1 && s[i + 1] == 'C')
                {
                    sum += 90;
                    continue;
                }

                sum += 10;
                continue;
            }

            if (s[i] == 'V')
            {
                if (i > 0 && s[i - 1] == 'I')
                {
                    continue;
                }

                sum += 5;
                continue;
            }

            if (s[i] == 'I')
            {
                if (i < s.Length-1 && s[i + 1] == 'V')
                {
                    sum += 4;
                    continue;
                }

                if (i < s.Length-1 && s[i + 1] == 'X')
                {
                    sum += 9;
                    continue;
                }

                sum += 1;
                continue;
            }
        }

        return sum;
    }
}