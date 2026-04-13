public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> dic = new Dictionary<char, int>();
        Dictionary<char, int> dic1 = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            dic[s[i]] = dic.GetValueOrDefault(s[i]) + 1;
            dic1[t[i]] = dic1.GetValueOrDefault(t[i]) + 1;
        }

        return !dic.Except(dic1).Any();
    }
}
