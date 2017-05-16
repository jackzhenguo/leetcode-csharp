using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.TreeLib
{
    // // Given preorder and inorder traversal of a tree, construct the binary tree.

// // Note: 
// // You may assume that duplicates do not exist in the tree.
   public class Solution 
{
    private  int[] _preorder; //preorder array
    private  int[] _inorder; //inorder array
    public TreeNode BuildTree(int[] preorder, int[] inorder)
     {
        _preorder = preorder;
        _inorder = inorder;
        //if(_preorder.Length==0 || inorder.Length==0) return null;
        //if(prorder.Length!=inorder.Length) return null;
        return bulidTree(0,0,_inorder.Length-1);
    }
    //preStart: index of root of tree
    //inStart: of inorder tree, inStart ~ root index - 1 -> left tree
    //EndStart:of inorder tree, root index + 1 ~ inEnd -> right tree
    private TreeNode  bulidTree(int preStart, int inStart, int inEnd) 
    {
        if (preStart > _preorder.Length - 1 || inStart > inEnd)
         {
            return null;
        }
        TreeNode root = new TreeNode(_preorder[preStart]); 
        // find the index of current root in inorder. 
        int inIndex = curRootIndex(inStart, inEnd, root); 
        root.left = bulidTree(preStart + 1, inStart, inIndex - 1);
        //right subtree begins position in preorder
        preStart += inIndex - inStart + 1; 
        root.right = bulidTree(preStart, inIndex + 1, inEnd);
        return root;
    }

      private int curRootIndex(int inStart, int inEnd, TreeNode root)
      {
           for (int i = inStart; i <= inEnd; i++) 
           {
               if (_inorder[i] == root.val) 
                {
                   return i;
                }
            }
          return -1;
        }

  }

}
