/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// // @lc code=start
//做法1：枚举法(暴力法)
// public class Solution {
//     public int MaxArea(int[] height) {
//         int max = 0;
//         for (int i = 0; i < height.Length - 1; i++)
//         {
//             for (int j = i + 1; j < height.Length; j++)
//             {
//                 int area =  (j - i) * Math.Min(height[i],height[j]);
//                 max = Math.Max(max,area);
//             }
//         }
//         return max;
//     }
// }

//做法2：双指针
public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        for (int i = 0,j = height.Length - 1; i < j;)
        {
            int minHeight = height[i] < height[j] ? height[i++] : height[j--];
            int area = (j - i + 1) * minHeight;
            max = Math.Max(max,area);
        }

        return max;
    }
}
// @lc code=end

