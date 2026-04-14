public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int,int>();
        dic[target - nums[0]] = 0;
        int find = 0;
        for(int i = 1; i < nums.Length; i++){
            if(dic.ContainsKey(nums[i])){
                return new int[]{dic[nums[i]], i};
            }
            dic[target - nums[i]] = i;

        }
        return new int[0];
    }
}
