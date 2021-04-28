public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        char[] charArray = s.ToCharArray();
        int[] intArrayOfNumerals = new int[charArray.Length];
        for (int i = 0; i < charArray.Length; i++)
        {
            switch(charArray[i])
            {
                case 'I':
                    intArrayOfNumerals[i] = 1;
                    break;
                case 'V':
                    intArrayOfNumerals[i] = 5;
                    break;
                case 'X':
                    intArrayOfNumerals[i] = 10;
                    break;
                case 'L':
                    intArrayOfNumerals[i] = 50;
                    break;
                case 'C':
                    intArrayOfNumerals[i] = 100;
                    break;
                case 'D':
                    intArrayOfNumerals[i] = 500;
                    break;
                case 'M':
                    intArrayOfNumerals[i] = 1000;
                    break;
            }
        }
        for (int i = 0; i < intArrayOfNumerals.Length; i++) {
            if (i + 1 < intArrayOfNumerals.Length && intArrayOfNumerals[i] < intArrayOfNumerals[i + 1]) {
                intArrayOfNumerals[i] *= -1;
            }
            result += intArrayOfNumerals[i];
        }
        return result;
    }
}
