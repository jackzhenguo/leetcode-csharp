/* ==============================================================================
 * 功能描述：LinkesListBasic  
 * 创 建 者：wack
 * 创建日期：2017/4/28 18:42:06
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList.Lib
{
    /// <summary>
    /// LinkesListBasic
    /// </summary>
    public class LinkesListBasic
    {
        #region 构造函数

        public LinkesListBasic()
        {
        }

        #endregion

        #region 属性字段

        #endregion

        #region 私有方法

        #endregion

        #region 公有方法
        //Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
        //Supposed the linked list is 1 -> 2 -> 3 -> 4 and you are given the third node with value 3, 
        //the linked list should become 1 -> 2 -> 4 after calling your function.
        public void DeleteNode(ListNode node)
        {
            if (node == null)
                return;
            node.val = node.next.val;
            node.next = node.next.next;
        }

        //Given a sorted linked list, delete all duplicates such that each element appear only once.
        //For example,
        //Given 1->1->2, return 1->2.
        //Given 1->1->2->3->3, return 1->2->3.
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode diff = head;
            ListNode tmp = head;
            while (tmp != null && tmp.next != null)
            {
                while (tmp.next != null && tmp.next.val == tmp.val)
                {
                    tmp = tmp.next;
                }
                diff.next = tmp.next;//找到一个新值          
                diff = diff.next;//迭代
                tmp = diff;
            }

            return head;
        }

        // Write a program to find the node at which the intersection of two singly linked lists begins.
        //For example, the following two linked lists:
        //A:          a1 → a2
        //                   ↘
        //                     c1 → c2 → c3
        //                   ↗            
        //B:     b1 → b2 → b3
        //begin to intersect at node c1.
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            ListNode a = headA;
            ListNode b = headB;
            while (a != b)
            {
                if (a == null)
                    a = headB;
                else
                {
                    a = a.next;
                }
                if (b == null)
                    b = headA;
                else
                {
                    b = b.next;
                }

            }
            return a;
        }

        //Remove all elements from a linked list of integers that have value val.
        //Example
        //Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
        //Return: 1 --> 2 --> 3 --> 4 --> 5
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;
            //检测头是否等于val
            if (head.val == val)
                head = head.next;
            ListNode tmp = head;
            while (tmp != null && tmp.next != null)
            {
                if (tmp.next.val == val)
                {
                    deleteNode(tmp, tmp.next);
                }
                else
                    tmp = tmp.next;
            }
            //检测头是否等于val
            if (head != null && head.val == val)
                head = head.next;
            return head;
        }

        //删除节点node，pre为node的前驱
        private void deleteNode(ListNode pre, ListNode node)
        {
            ListNode tmp = node.next;
            pre.next = tmp;
        }


        //Reverse a singly linked list.
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode a = head;
            ListNode b = head.next;
            a.next = null;
            while (b != null)
            {
                ListNode tmp = b.next; //保存节点b后的所有节点顺序
                b.next = a; //上步保存后，可以放心的将b的next域指向a，实现反转
                a = b; //上步实现反转后，再赋值给a，这样a始终为反转链表的头节点
                b = tmp;//上步后实现了反转，这步实现迭代，即让b再在原来的链表中保持前行。
            }
            return a;
        }

        //Merge two sorted linked lists and return it as a new list. 
        //The new list should be made by splicing together the nodes of the first two lists.
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode merge;
            //首先确定merge的头节点指向谁
            if (l1.val < l2.val)
            {
                merge = l1;
                l1 = l1.next;
            }
            else
            {
                merge = l2;
                l2 = l2.next;
            }

            ListNode im = merge; //临时指针指向merge
            while (l1 != null)
            {
                if (l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        im.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        im.next = l2;
                        l2 = l2.next;
                    }
                    im = im.next;
                }
                else //b首先等于null
                {
                    im.next = l1;
                    break;
                }
            }

            if (l2 != null) //a首先等于null
                im.next = l2;

            return merge;

        }

        #endregion

    }
}
