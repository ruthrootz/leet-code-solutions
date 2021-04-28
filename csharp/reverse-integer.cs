public class Solution {
    public int Reverse(int x) {
        bool negative = false;
        if (x < 0){
            negative = true;
            x *= -1;
        }
        string stringOfX = x.ToString();
        char[] charArrayOfNumber = stringOfX.ToCharArray();
        Array.Reverse(charArrayOfNumber);
        string reversedString = new string(charArrayOfNumber);
        bool sucess = int.TryParse(reversedString, out int result);
        if (sucess) {
            return negative ? -1 * result : result;
        }
        else {
            return 0;
        }
    }
}
