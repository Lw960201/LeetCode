
/*
 * 
 *
 * [5460] 好数对
 */
 
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int index = 0;
        int[] array = new int[101];
        for (int i = 0;i < nums.Length;i++)//把元素值作为数组下标，来记录出现同一值的次数
        {
            ++array[nums[i]];
        }

        int count = 0;
        for (int i=0;i < array.Length;i++)
        {
            if (array[i] == 0)//出现次数为0的元素跳过
            {
                continue;
            }
            else//一个数出现了n次的话，这个数的好数对就是n*(n-1)/2
            {
                count += (array[i] * ( array[i] - 1 ) / 2);
            }
        }
        return count;
    }
}