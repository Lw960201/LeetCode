/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 */

// @lc code=start
//数据栈 + 辅助栈
public class MinStack {
    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();
    public MinStack() {
        minStack.Push(int.MaxValue);
    }
    public void Push(int x) {
        stack.Push(x);
        minStack.Push(Math.Min(minStack.Peek(),x));//找出辅助栈中的顶值和x中的最小值压栈
    }
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    public int Top() {
        return stack.Peek();
    }
    public int GetMin() {
        return minStack.Peek();
    }
}

//单栈
public class MinStack {
    int min = int.MaxValue;
    Stack<int> stack = new Stack<int>();
    public void Push(int x) {
        //比较x和min
        //x是最小值则把旧的min压栈，并把新的min也压栈；否则只把当前值x压栈
        if(x <= min){          
            stack.Push(min);
            min=x;
        }
        stack.Push(x);
    }
    public void Pop() {
        //如果当前出栈的是最小值，则再弹出一个x的值；否则只弹出x的值
        if(stack.Pop() == min) min=stack.Pop();
    }
    public int Top() {
        return stack.Peek();
    }
    public int GetMin() {
        return min;
    }
}
// @lc code=end

