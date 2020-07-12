/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
//解法：双指针
// public class Solution {
//   public IList<IList<int>> ThreeSum(int[] nums){
//         IList<IList<int>> result = new List<IList<int>>();
//         int len = nums.Length;
//         if (len < 3) return result;
//         Array.Sort(nums);
//         for (int i = 0; i < len - 2; i++)//len-2排除双指针
//         {
//             if (nums[i] > 0) break;//前面都大于0，相加肯定大于0，没法相等直接pass
//             // 去重：当前元素是否和上一个一样，一样则跳过
//             if (i > 0 && nums[i] == nums[i - 1]) continue; 
//             int left = i + 1;
//             int right = len - 1;
//             while (left < right)
//             {
//                 int sum = nums[i] + nums[left] + nums[right];
//                 if (sum == 0)
//                 {
//                     result.Add(new List<int>() { nums[i], nums[left], nums[right] });
//                     while (left < right && nums[left] == nums[left + 1]) left++; // 去重
//                     while (left < right && nums[right] == nums[right - 1]) right--; // 去重
//                     left++;
//                     right--;
//                 }
//                 else if (sum < 0) left++;
//                 else if (sum > 0) right--;
//             }
//         }
//         return result;
//     }
// }

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums){
        IList<IList<int>> result = new List<IList<int>>();
        if (nums == null || nums.Length < 3) return result;//特判
        Array.Sort(nums);//排序
        //第一个数
        for (int i = 0; i < nums.Length -2; i++)
        {
            //如果上来的元素比0大，后面的2个指针也不用比较了
            if (nums[i] > 0) break;
            if (i>0 && nums[i] == nums[i - 1]) continue;
            //定义双指针
            int L = i + 1;
            int R = nums.Length - 1;
            while (L < R)
            {
                int sum = nums[L] + nums[R] + nums[i];
                if (sum == 0)//判断和是否为0
                {
                    //存
                    result.Add(new List<int>(){ nums[i], nums[L], nums[R] });
                    //去重
                    while ( L < R && nums[L] == nums[L + 1]) L++; 
                    while ( L < R && nums[R] == nums[R - 1]) R--;
                    L++;
                    R--; 
                }
                else if (sum < 0) L++;
                else if (sum > 0) R--;
            }
        }
        return result;
    }
}
// @lc code=end

