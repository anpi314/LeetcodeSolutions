public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
         for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i].CompareTo(target) > 0)
            {
                return letters[i];
            }
        }

        return letters[0];
    }
}