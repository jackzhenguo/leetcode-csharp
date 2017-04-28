/* ==============================================================================
 * 功能描述：Cycle  
 * 创 建 者：gz
 * 创建日期：2017/4/28 18:38:30
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Given a linked list, determine if it has a cycle in it.
namespace LinkedList.Lib
{
    /// <summary>
    /// Cycle
    /// </summary>
    public class CycleSln
    {


        #region 公有方法
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return false;
            if (head.next.next == null) return false;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == null)
                    return false; //快指针如果为null，不存在环
                if (fast.val == slow.val)
                {
                    return true; //找到节点数据域相等点，存在环
                }
            }
            return false;
        }
        #endregion

    }
}
