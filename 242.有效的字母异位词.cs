/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        char[] str1 = s.ToCharArray(); 
        char[] str2 = t.ToCharArray(); 
        Array.Sort(str1);
        Array.Sort(str2);

        return Enumerable.SequenceEqual(str1,str2);
    }
}
// @lc code=end

