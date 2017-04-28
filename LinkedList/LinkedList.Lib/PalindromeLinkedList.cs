/* ==============================================================================
 * 功能描述：PalindromeLinkedList  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:49:30
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList.Lib
{
    /// <summary>
    /// PalindromeLinkedList
    /// </summary>
    public class PalindromeLinkedList
    {
        //Given a singly linked list, determine if it is a palindrome.

        //Follow up:

        //Could you do it in O(n) time and O(1) space?
        #region 公有方法
        public bool IsPalindrome(ListNode head)
        {
            int nodeCnt = nodeCount(head);
            ListNode begNode = head;
            //反转后半部分
            ListNode midNode = head;
            int i = 0;
            int mid = nodeCnt % 2 == 0 ? nodeCnt / 2 : nodeCnt / 2 + 1;
            while (++i <= mid)
                midNode = midNode.next;
            i = 0;
            LinkesListBasic bas = new LinkesListBasic();
            ListNode rmidNode = bas.ReverseList(midNode);

            //后半部分反转后，如果是回文，则前半、后半对应元素相等
            while (i++ < nodeCnt / 2)
            {
                if (begNode.val != rmidNode.val)
                    return false;
                begNode = begNode.next;
                rmidNode = rmidNode.next;
            }
            return true;
        }
        private int nodeCount(ListNode head)
        {
            int cnt = 0;
            while (head != null)
            {
                cnt++;
                head = head.next;
            }
            return cnt;
        }

        #endregion

    }
}
