/* ==============================================================================
 * 功能描述：TreeNode  
 * 创 建 者：gz
 * 创建日期：2017/4/19 12:20:32
 * ==============================================================================*/

namespace Tree.TreeLib
{
    /// <summary>
    /// TreeNode
    ///  Definition for a binary tree node.
    /// </summary>
    public class TreeTools
    {

        /// <summary>
        /// 构建树
        /// </summary>
        /// <param name="nums">数组，无左右子树，用null表示</param>
        /// <returns>树根</returns>
        public static  TreeNode buildTree(object[] nums)
        {
            return build(nums, 0);
        }

        private static  TreeNode build(object[] nums, int i)
        {
            if (i >= nums.Length || nums[i] == null)
                return null;
            TreeNode root = new TreeNode((int)nums[i]);
            root.left = build(nums, 2*i + 1);
            root.right = build(nums, 2*i + 2);
            return root;
        }
    }


}
