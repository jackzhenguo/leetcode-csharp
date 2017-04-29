using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the following operations of a queue using stacks.

//push(x) -- Push element x to the back of queue.
//pop() -- Removes the element from in front of queue.
//peek() -- Get the front element.
//empty() -- Return whether the queue is empty.
//Notes:
//You must use only standard operations of a stack -- which means only push to top, peek/pop from top, size, and is empty operations are valid.
//Depending on your language, stack may not be supported natively. You may simulate a stack by using a list or deque (double-ended queue), as long as you use only standard operations of a stack.
//You may assume that all operations are valid (for example, no pop or peek operations will be called on an empty queue).
namespace Stack.Lib
{
    class QueueUsingStackSln
    {
        Stack<int> _s1;//维护新来的元素
            Stack<int> _s2;//维护最先进来的
            /** Initialize your data structure here. */
            public QueueUsingStackSln()
            {
                _s1 = new Stack<int>();
                _s2 = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                _s1.Push(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                int size = _s1.Count;
                if (_s2.Count == 0)
                {
                    while (size-- > 0)
                        _s2.Push(_s1.Pop());
                }
                return _s2.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                int size = _s1.Count;
                if (_s2.Count == 0)
                {
                    while (size-- > 0)
                        _s2.Push(_s1.Pop());
                }
                return _s2.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return _s1.Count == 0 && _s2.Count == 0;
            }
    }
}
