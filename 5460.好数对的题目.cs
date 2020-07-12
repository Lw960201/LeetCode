
/*
 * 
 *
 * [5460] 好数对
 */

//暴力法
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int count = 0;
        for (int i = 0;i < nums.Length;i++)
            for (int j = i+1;j < nums.Length;j++)
                if (nums[i] == nums[j]) count++;
        return count;
    }
}

 //数学法
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int count = 0;
        int[] array = new int[101];
        for (int i = 0;i < nums.Length;i++)//把元素值作为数组下标，来记录出现同一值的次数
            ++array[nums[i]];
        for (int i=0;i < array.Length;i++)
        {
            if (array[i] == 0) continue;//出现次数为0的元素跳过
            else count += (array[i] * ( array[i] - 1 ) / 2);//一个数出现了n次的话，这个数的好数对就是n*(n-1)/2
        }
        return count;
    }
}

//哈希法
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int res = 0;
        Dictionary<int, int> dic = new Dictionary<int,int>();
        foreach(int n in nums)
        {
            if (!dic.ContainsKey(n)) dic.Add(n,1);
            else dic[n]++;
            res += dic[n] - 1;
        }
        return res;
    }
}

//哈希法+数学法
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int result = 0;
        foreach(int num in nums)
        {
            //不在字典则存入，在则次数加1
            if (!dic.ContainsKey(num)) dic.Add(num,1);
            else dic[num]++;
        }
        foreach(int key in dic.Keys)
        {
            int count = dic[key];
            result += count * (count - 1) >> 1;//一个数出现了n次的话，这个数的好数对就是n*(n-1)/2
        }
        return result;
    }
}