/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start

//栈
public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s.ToCharArray())
        {
            //找出所有左括号，将相应的右括号压栈
            if (c.Equals('('))
                stack.Push(')');
            else if (c.Equals('{'))
                stack.Push('}');
            else if (c.Equals('['))
                stack.Push(']');
            //如果栈为空，或者出栈的不是对应的右括号则false
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }
        //字符串遍历结束，此时栈为空则true
        return stack.Count == 0;
    }
}
// @lc code=end

