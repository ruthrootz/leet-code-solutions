public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        string stringOfNum = x.ToString();
        for (int i = 0; i < stringOfNum.Length - 1; i++)
        {
            if (i >= stringOfNum.Length - 1 - i)
            {
                break;
            }
            if (stringOfNum[i] != stringOfNum[stringOfNum.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
