public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int left = 0;
        int longest = 0;

        for (int right = 0; right < s.Length; right++) {
            if (dict.ContainsKey(s[right])) {
                left = Math.Max(dict[s[right]] + 1, left);
            }
            dict[s[right]] = right;
            longest = (right - left + 1) > longest ? (right - left + 1) : longest;
        }

        return longest;
    }
}
