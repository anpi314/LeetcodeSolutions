class Solution {
    public int largestAltitude(int[] gain) {
        int[] arr = new int[gain.length + 1];
        int netGain = arr[0];
        arr[0] = 0;
        for (int i = 0; i < arr.length - 1; i++) {
            arr[i + 1] = gain[i] + arr[i];
            if(arr[i+1]>netGain){
                netGain = arr[i+1];
            }
        }
        return netGain;

      
    }
}