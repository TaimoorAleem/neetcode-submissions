public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> uniqueInt = new HashSet<int>();

        foreach (int n in nums) {
            if (uniqueInt.Contains(n)) { return true; } else uniqueInt.Add(n);
        }
        
        return false;
    }
}