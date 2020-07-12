/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 */

// @lc code=start
public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums == null || nums.Length == 0) return;

        int cur = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[cur++] = nums[i];
            }
        }

        for (; cur < nums.Length; cur++)
        {
            nums[cur] = 0;
        }
    }
}
// @lc code=end

