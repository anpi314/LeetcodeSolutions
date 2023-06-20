class Solution {
    public List<Integer> targetIndices(int[] nums, int target) {
      
        for (int i = 1; i < nums.length; i++) {
            for (int j = i; j > 0 && nums[j - 1] > nums[j]; j--) {
                int temp = nums[j - 1];
                nums[j - 1] = nums[j];
                nums[j] = temp;
            }
        }
        List<Integer> arrayList = new ArrayList<>();
        int l = 0;
        int r = nums.length - 1;
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (nums[mid] == target) {
                for (int i = mid + 1; i < nums.length; i++) {
                    if (nums[i] == target) {
                        arrayList.add(i);

                    } else break;

                }
                for (int i = mid - 1; i >= 0; i--) {
                    if (nums[i] == target) {
                        arrayList.add(i);
                    } else break;
                }
                arrayList.add(mid);
                break;
            }
            if (nums[mid] < target) {
                l = mid + 1;
            } else r = mid - 1;

        }
        
        Collections.sort(arrayList);
        return arrayList;
}
}