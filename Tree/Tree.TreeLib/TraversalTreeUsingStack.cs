/* ==============================================================================
 * 功能描述：TraversalTreeUsingStack  
 * 创 建 者：gz
 * 创建日期：2017/4/24 10:39:19
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    /// <summary>
    /// TraversalTreeUsingStack
    /// </summary>
    public class TraversalTreeUsingStack
    {
        private Stack<TreeNode> _stack = new Stack<TreeNode>();
        //前序遍历
        public void PreOrder(TreeNode root)
        {
            _stack.Clear();
            if (root == null)
                return;
            TreeNode tmp = root;
            _stack.Push(tmp);//先访问根节点
            while (_stack.Count > 0)
            {
                if (tmp == null)//左子树为空             
                    tmp = _stack.Peek(); //弹出右子树
                visit(_stack.Peek());
                _stack.Pop();
                if (tmp.right != null)
                    _stack.Push(tmp.right);
                if (tmp.left != null)
                    _stack.Push(tmp.left);
                tmp = tmp.left;//迭代等式
            }
        }
        //中序遍历
        //先遍历左孩子，再访问根节点，最后遍历右孩子
        public void MidOrder(TreeNode root)
        {
            _stack.Clear();
            if (root == null) return;
            _stack.Push(root);
            while (_stack.Count > 0)
            {
                TreeNode tmp = _stack.Peek();
                while (tmp != null) //遍历左子树的最孩子，直到为null
                {
                    _stack.Push(tmp.left);
                    tmp = tmp.left;
                }
                //可能1 左孩子为null时退出上层循环，但是此时栈顶为null
                //可能2 栈顶为null，while直接退出
                _stack.Pop(); //一定弹出null       
                if (_stack.Count == 0) return;
                visit(_stack.Peek()); //访问节点    
                var tmp2 = _stack.Pop();
                _stack.Push(tmp2.right);//如果右孩子为null，则null入栈。
            }
        }

        //后序遍历
        public void PostOrder(TreeNode root)
        {
            _stack.Clear();
            if (root == null) return;
            _stack.Push(root);
            TreeNode tmp = root;
            while (_stack.Count > 0)
            {
                if (tmp == null)
                {
                    _stack.Pop();
                    tmp = _stack.Peek();
                    continue;
                }
                if (tmp.right != null)
                    _stack.Push(tmp.right);
                if (tmp.left != null)
                    _stack.Push(tmp.left);
                visit(_stack.Peek());
                tmp = _stack.Pop();
            }
        }


        private void visit(TreeNode node)
        {
            if (node != null)
                Console.WriteLine(node.val);
        }

    }
}
