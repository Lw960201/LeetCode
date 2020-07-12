/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
//做法1：斐波那契数列的公式
public class Solution {
    public int ClimbStairs(int n) {
        double sqrt_5 = Math.Sqrt(5);
        double fib_n = (1/sqrt_5) * (Math.Pow(((1+sqrt_5)/2),n+1) - Math.Pow(((1-sqrt_5)/2),n+1));
        return (int)fib_n;
    }
}

//做法2：动态规划
// public class Solution {
//     public int ClimbStairs(int n) {
//         if (n <= 2)
//         {
//             return n;
//         }

//         int i1 = 1;
//         int i2 = 2;
//         for (int i = 3; i <= n; i++)
//         {
//             int temp = i1 + i2;
//             i1 = i2;
//             i2 = temp;
//         }

//         return i2;
//     }
// }
// @lc code=end

