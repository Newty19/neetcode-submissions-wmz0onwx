public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> noDupNums = new HashSet<int>(nums);

        if(noDupNums.Count != nums.Length){
            return true;
        }else{
            return false;
        }
    }
}