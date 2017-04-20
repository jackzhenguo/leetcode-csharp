/* ==============================================================================
 * 功能描述：SameTree  
 * 创 建 者：gz
 * 创建日期：2017/4/20 8:35:40
 * ==============================================================================*/

//Given two binary trees, write a function to check if they are equal or not.
//Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
namespace Tree.TreeLib
{
    /// <summary>
    /// SameTree
    /// </summary>
    public class SameTree
    {

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val &&
                IsSameTree(p.left, q.left) && 
                IsSameTree(p.right, q.right);
        }
    }
}
