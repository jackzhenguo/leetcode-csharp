using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Lib
{
    //    Given a string containing just the characters ‘(‘, ‘)’, ‘{‘, ‘}’, ‘[’ and ‘]’, determine if the input string is valid.

    //The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
    public class ValidParenthesesSln
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0) //栈为空，Peek报错，所以要加这个判断
                    return false;
                if (item == ')')
                {
                    if (stack.Peek() != '(')
                        return false;
                    stack.Pop(); //相等的话要出栈
                }
                else if (item == '}')
                {
                    if (stack.Peek() != '{')
                        return false;
                    stack.Pop();
                }
                else if (item == ']')
                {
                    if (stack.Peek() != '[')
                        return false;
                    stack.Pop();
                }

            }
            return stack.Count == 0;
        }
    }
}
