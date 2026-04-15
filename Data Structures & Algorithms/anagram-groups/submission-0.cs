public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < strs.Length; i++){
            int[] count = new int[26];
            for(int j = 0; j < strs[i].Length; j++){
                count[strs[i][j] - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(strs[i]);
        }
        return res.Values.ToList<List<string>>();

    }
}
