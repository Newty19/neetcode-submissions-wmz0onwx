public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashNums = new HashSet<int>(nums);

        if(nums.Length == hashNums.Count){
            return false;
        }else{
            return true;
        }
    }
}