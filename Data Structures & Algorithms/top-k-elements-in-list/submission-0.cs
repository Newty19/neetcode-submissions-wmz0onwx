public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int[] res = new int[k];
        for(int i = 0; i < nums.Length; i++){
            dic[nums[i]] = dic.GetValueOrDefault(nums[i]) + 1;
        }
        var resdesc = dic.OrderByDescending(x => x.Value).ToList();
        for(int i = 0; i < k; i++){
            res[i] = resdesc[i].Key;
        }
        return res;
    }
}
