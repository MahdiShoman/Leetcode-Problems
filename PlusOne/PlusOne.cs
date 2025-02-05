public class Solution {
    public int[] PlusOne(int[] digits) {

        int lastbit=digits[digits.Length -1];
            if(lastbit < 9){
                digits[digits.Length-1]++;
                return digits;
            }else if (digits.Length == 1){
                return new int[]{1,0};
            }
        for  (int i =digits.Length-1 ;i>=0;i--){
            if (digits[i]<9){
                digits[i]++;
                break;
            }else if(i-1<0){
                digits[i]=0;
                int newElement = 1;
                int[] newDigitsArray = new int[digits.Length + 1];

                newDigitsArray[0] = newElement;
                Array.Copy(digits, 0, newDigitsArray, 1, digits.Length);
                return newDigitsArray;
            }else{
                digits[i]=0;
            }
            
        }
        return digits;

        
    }
}