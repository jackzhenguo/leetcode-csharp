# leetcode-csharp

## `Today Update`
### HashTable
####  242 Valid Anagram
*  [Github:#242 Valid Anagram](/Array/Array.Lib/ValidAnagramSln.cs)
*  [CSDN: #242 Valid Anagram](http://blog.csdn.net/daigualu/article/details/71358552)
#### 561 Array Partition I
*  [Github: #205 Isomorphic Strings](/Array/Array.Lib/IsomorphicStringsSln.cs)
*  [CSDN: #205 Isomorphic Strings](http://blog.csdn.net/daigualu/article/details/71357419)
---
---

## Solution List
solutions using C# for leetcode according to tags of questions
Tags are following:  
* [Array](/Array)
* [Hash Table](/HashTable)
* [Linked List](/LinkedList)
* [Math](/Math)
* [Two Pointers](/TwoPointers)
* [String](/String)
* [Binary Search](/BinarySearch)
* [Dynamic Programming](/DP)
* [Stack](/Stack)
* [Tree](/Tree)

# Details
## Array
* [#35 Search Insert Position](/Array/Array.Console/Array.Lib/SearchInsertPosition.cs)

* [#118 	Pascal’s Triangle](/Array/Array.Console/Array.Lib/PascalsTriangle.cs)

* [#119 	Pascal’s Triangle II](/Array/Array.Console/Array.Lib/PascalsTriangleII.cs)

* [#414 	Third Maximum Number](/Array/Array.Console/Array.Lib/ThirdMaximumNumber.cs)

* [#66 Plus One](http://blog.csdn.net/daigualu/article/details/71056697)

* [#121 Best time to buy and sell stock](http://blog.csdn.net/daigualu/article/details/71038726)

* [#26	Remove Duplicates from Sorted Array](http://blog.csdn.net/daigualu/article/details/71064545)


* [#122 BestTimeToBuyandSellStockII](http://blog.csdn.net/daigualu/article/details/71104584)

* [#27 Remove element](http://blog.csdn.net/daigualu/article/details/71104482)

#### 532 K-diff Pairs in an Array
*  [Github:#532 K-diff Pairs in an Array](/Array/Array.Lib/FindPairsSln.cs)
*  [CSDN:#532 K-diff Pairs in an Array](http://blog.csdn.net/daigualu/article/details/71129806)
#### 217 Contains Duplicate
*  [Github:#217 Contains Duplicate](/Array/Array.Lib/ContainsItemSln.cs)
*  [CSDN:#217 Contains Duplicate](http://blog.csdn.net/daigualu/article/details/71123673)

#### 448 Find All Numbers Disappeared in an Array
*  [Github:#448 Find All Numbers Disappeared in an Array](/Array/Array.Lib/DisappearElementsSln.cs)
*  [CSDN:#448 Find All Numbers Disappeared in an Array](http://blog.csdn.net/daigualu/article/details/71168875)
#### 219 Contains Duplicate II
*  [Github:219 Contains Duplicate II](/Array/Array.Lib/ContainsDuplicateIISln.cs)
*  [CSDN:219 Contains Duplicate II](http://blog.csdn.net/daigualu/article/details/71166985)
#### 189. Rotate Array
*  [Github:189. Rotate Array](/Array/Array.Lib/RotateArraySln.cs)
*  [CSDN:189. Rotate Array](http://blog.csdn.net/daigualu/article/details/71159419)

#### 448 Find All Numbers Disappeared in an Array
*  [Github:#448 Find All Numbers Disappeared in an Array](/Array/Array.Lib/DisappearElementsSln.cs)
*  [CSDN: #448 Find All Numbers Disappeared in an Array](http://blog.csdn.net/daigualu/article/details/71168875)
#### 219 Contains Duplicate II
*  [Github: 485. Max Consecutive Ones](/Array/Array.Lib/MaxConsecutiveOnesSln.cs)
*  [CSDN: 485. Max Consecutive Ones](http://blog.csdn.net/daigualu/article/details/71216338)
#### 566 Reshape the Matrix
*  [Github:#566 Reshape the Matrix](/Array/Array.Lib/ReshapeMatrixSln.cs)
*  [CSDN: #566 Reshape the Matrix](https://leetcode.com/problems/reshape-the-matrix/#/description)
#### 561 Array Partition I
*  [Github: #561 Array Partition I](/Array/Array.Lib/ArrayPartitionISln.cs)
*  [CSDN: #561 Array Partition I](http://blog.csdn.net/daigualu/article/details/71273279)

## Hash Table
* [#136 	Single number](/HashTable/HashTable.Lib/SingleOneSln.cs)

* [#1 Two Sum](/HashTable/HashTable.Lib/TwoSumSln.cs)


* [#447 Number of Boomerangs](/HashTable/HashTable.Lib/Boomerangs.cs)

* [#463. Island Perimeter](/HashTable/HashTable.Lib/IslandPerimeter.cs)

* [#409	Longest Palindrome](/HashTable/HashTable.Lib/LongestPalindrome.cs)

## Linked List
[#141 Linked List Cycle](http://blog.csdn.net/daigualu/article/details/69055927)

[#237 Delete Node in a Linked List](http://blog.csdn.net/daigualu/article/details/69055991)

[#83	Remove Duplicates from Sorted List](http://blog.csdn.net/daigualu/article/details/69093677)

[#160 Intersection of Two Linked Lists](http://blog.csdn.net/daigualu/article/details/69526717)

[#203	Remove Linked List Elements](http://blog.csdn.net/daigualu/article/details/69389243)
```C#
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
                    deleteNode(tmp,tmp.next);
                }
                else
                    tmp = tmp.next;
            }
            //检测头是否等于val
            if (head!=null && head.val == val)
                head = head.next;
            return head;
        }

        //删除节点node，pre为node的前驱
        private void deleteNode(ListNode pre, ListNode node)
        {
            ListNode tmp = node.next;
            pre.next = tmp;
        }
```
[#206	Reverse Linked List](http://blog.csdn.net/daigualu/article/details/69372119)
```C#
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
```
[#234	Palindrome Linked List](http://blog.csdn.net/daigualu/article/details/69388513)
```C#
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
            ListNode rmidNode = ReverseList(midNode);

            //后半部分反转后，如果是回文，则前半、后半对应元素相等
            while (i++ < nodeCnt/2)
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
```
[#21	Merge Two Sorted Lists](http://blog.csdn.net/daigualu/article/details/69565969)
```C#
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
```
## Math    
[#231 Power of Two](http://blog.csdn.net/daigualu/article/details/69102931)

```C#
   public bool IsPowerOfTwo(int n)
        {
            if (n<=0) return false;
            while (n>1)
            {             
                if (n % 2 > 0) return false;
                n /= 2;
            }
            return true;
        }
```

[#268 Missing Number](http://blog.csdn.net/daigualu/article/details/69220202)

```C#
      public int MissingNumber(int[] nums)
        {
            int xor = 0, i = 0;
            for (i = 0; i <nums.Length; i++)
            {
                xor = xor ^ i ^ nums[i];
            }
            //最后再和个数i异或，这样所有的索引与下标都异或了，找到缺失元素。
            return xor^i; 
        }
```

[#507	Perfect Number](http://blog.csdn.net/daigualu/article/details/69233798)

```C#
     public bool CheckPerfectNumber(int num)
        {
            int sum = 1;
            int tmp = num;
            if (num == 0 || num==1)//特别注意边界值 
            return false;
            while (num%2 == 0)
            {
                num /= 2;
                sum += num+tmp/num;          
            }
            return sum==tmp;
        }
```

## Two Pointers
[#345	Reverse Vowels of a String](http://blog.csdn.net/daigualu/article/details/69257693)
	
```C#
 private List<char> vowels = new List<char> {'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
        private char[] chars;

        public string ReverseVowels(string s)
        {        
            chars = s.ToCharArray();
            int lo = 0;
            int hi = s.Length - 1;
            while(lo<hi)
               reverseVowels(ref lo,ref hi);
            return new string(chars);
        }
        public void reverseVowels(ref int lo, ref int hi)
        {
            for (int i = lo; i <= hi; i++,lo++)
            {
                if (vowels.Contains(chars[i]))
                    break;
            }
            for (int i = hi; i >= lo; i--,hi=i)
            {
                if (vowels.Contains(chars[i]))
                    break;
            }

            if (lo < hi )
            {
                if (chars[lo] != chars[hi])//交换字符
                {
                    char tmp = chars[lo];
                    chars[lo] = chars[hi];
                    chars[hi] = tmp;
                }
                ++lo;
                --hi;
            }
        }
```

[#283 Move Zeroes](http://blog.csdn.net/daigualu/article/details/69329038)
	

```C#
        public void MoveZeroes(int[] nums)
        {
            int i, j = 0; //j始终指向非零数
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    while (i < nums.Length && nums[i] == 0)
                        i++;
                    if(i<nums.Length)
                         nums[j++] = nums[i];//找到num[i]不为0
                }
                else
                    nums[j++] = nums[i];
            }
            //[0,j)为非零数，[j,nums.Length)应全清零。
            for (int k = j; k < nums.Length; k++) 
                nums[k] = 0;

        }
```

[#88	Merge Sorted Array](http://blog.csdn.net/daigualu/article/details/69367334)	

```C#
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; //指向nums1
            int j = n - 1; //指向nums2
            int k = m + n - 1; //指向合并位置
            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[i])
                    nums1[k--] = nums1[i--];
                else nums1[k--] = nums2[j--];

            }
        }
```

[#234Palindrome Linked List](http://blog.csdn.net/daigualu/article/details/69388513)

```C#
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
            ListNode rmidNode = ReverseList(midNode);

            //后半部分反转后，如果是回文，则前半、后半对应元素相等
            while (i++ < nodeCnt/2)
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

```

## String      
[#58 Length of Last Word](http://blog.csdn.net/daigualu/article/details/69568460)

```C#
public int LengthOfLastWord1(string s)
        {
            s = s.Trim(); //去掉前，后空格
            if (s == "") return 0;
            string[] splitstring = s.Split(' ');
            string slast = splitstring[splitstring.Length - 1];
            return slast.Length == 0 ? 1 : slast.Length;
        }
```

[#20	 Valid Parentheses](http://blog.csdn.net/daigualu/article/details/69569622)	

```C#
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
                    if ( stack.Peek() != '(')
                        return false;
                    stack.Pop(); //相等的话要出栈
                }
                else if (item == '}')
                {
                    if ( stack.Peek() != '{')
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
            return stack.Count==0;
        }
```

[#520 Detect Capital](http://blog.csdn.net/daigualu/article/details/69663210)

```C#
public bool DetectCapitalUse(string word)
        {
            if (string.IsNullOrEmpty(word)) return true;

            char fst = word[0];
            if(charCapital(fst))
            {
                int afterCapital = 0;
                for(int i=1;i<word.Length;i++)
                {
                    if (charCapital(word[i]))
                        afterCapital++;
                }
                if (afterCapital == 0)
                    return true;//只有首字符大写
               else if (afterCapital == word.Length - 1)
                   return true;//都是大写
                return false;
            }
            else//首字符小写
            {
                int afterCapotal=0;
                for (int i = 1; i < word.Length; i++)
                {
                    if(charCapital(word[i]))
                        afterCapotal++;
                }
                return afterCapotal == 0 ? true : false;
            }

        }
       private bool charCapital(char ch)
        {
            int chint = Convert.ToInt32(ch);
            if (chint >= 65 && chint <= 90)
                return true;
            return false;
        }
```

[#459	Repeated Substring Pattern](http://blog.csdn.net/daigualu/article/details/69663545)

```C#
 public bool RepeatedSubstringPattern(string s)
        {
            for (int i = s.Length/2; i > 0 ; i--)
            {
                if (s.Length % i != 0)
                    continue;
                string prefix = s.Substring(0, i); //可能的重复子串
                string strsub = s.Substring(i); //去掉以上可能的重复子串后
                int index = strsub.IndexOf(prefix);
                if (index != 0)
                    continue;
                else //表明紧接着字符串匹配上
                {
                //用这个子串重复s.Length/i次，若与原串相等，便为true。
                    StringBuilder sb = new StringBuilder(); 
                    for (int j = 0; j < s.Length / i;j++ )
                        sb.Append(prefix);
                    if (sb.ToString() == s)
                        return true;
                }

            }
            return false;
        }
```

[#434	Number of Segments in a String](http://blog.csdn.net/daigualu/article/details/69664369)

```C#
public int CountSegments(string s)
        {
            if (string.IsNullOrEmpty(s)) 
                return 0;
            int i = 0;
            while (i < s.Length && !isValidBegin(s[i])) 
                i++;
            if (i == s.Length) //没有有效字符，如"         "
                return 0;
            if (i == s.Length - 1)  //只有一个有效字符，如 "         a"
                return 1;
            while (i < s.Length - 1 && !isValidEnd(s[i], s[i + 1]))
                i++;
            if (i == s.Length - 1)
                return 1; //只有1个有效字符，如"         a              "

            return 1+ CountSegments(s.Substring(i + 1));
        }
```

[#14	Longest Common Prefix](http://blog.csdn.net/daigualu/article/details/69665015)	

```C#
         public string LongestCommonPrefix(string[] strs)
          {
               if(strs==null || strs.Length==0)
                   return "";
               if (strs.Length == 1)
                   return strs[0];

               string longestPrefix = firstTwoStrs(strs);
               if (longestPrefix.Length == 0)
                  return "";
              int i=2;
              while(i < strs.Length)
              {
                  if (strs[i].IndexOf(longestPrefix) != 0)
                  {
                      longestPrefix = 
                      longestPrefix.Substring(0, longestPrefix.Length - 1);
                      i = 1;
                      if (longestPrefix.Length == 0)
                          return "";
                  }
                  i++;
              }
              return longestPrefix;
          }

        //头两个字符串的公共串
        private string firstTwoStrs(string[] strs)
        {
            if (strs.Length < 2) return "";
            StringBuilder sb = new StringBuilder();
            int len = strs[0].Length < strs[1].Length ? strs[0].Length : strs[1].Length;
            for(int i=0;i<len;i++)
            {
                if (strs[0][i] == strs[1][i])
                    sb.Append(strs[0][i]);
                else
                    break;
            }
            return sb.ToString();
        }
```

[#383	Ransom Note](http://blog.csdn.net/daigualu/article/details/69665190)	

```C#
public bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine == null && ransomNote == null) return true;
            if (magazine == null) return false;

            //magazine字符串整理为字典
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var item in magazine)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else dict.Add(item, 1);
            }

            foreach(var item in ransomNote)
            {
                if(!dict.ContainsKey(item))//未出现直接返回false
                    return false;
                dict[item]--;
                if (dict[item] == 0) //为0后，移除
                    dict.Remove(item);
            }

            return true;
        }
```

## Binary Search
* [#367 Valid Perfect Square](http://blog.csdn.net/daigualu/article/details/69787644)
```C#
public bool IsPerfectSquare(int num)
        {
            int low = 1, high = num;
            while (low <= high)
            {
                long mid = (low + high) >> 1;
                if (mid * mid == num)
                {
                    return true;
                }
                else if (mid * mid < num)
                {
                    low = (int)mid + 1;
                }
                else
                {
                    high = (int)mid - 1;
                }
            }
            return false;
        }
```
* [#167 Two Sum II - Input array is sorted](http://blog.csdn.net/daigualu/article/details/69787679)
```C#
 public int[] TwoSum2(int[] num, int target)
        {
            //因为一定存在解，所以不做边界检查
            int left = 0, right = num.Length - 1;
            while (left < right)
            {
                int v = num[left] + num[right];
                if (v == target)
                    return new int[2] { left + 1, right + 1 };
                else if (v > target)
                    right--;
                else
                    left++;
            }
            return new int[] { };
        }
```
* [#441 Arranging Coins](http://blog.csdn.net/daigualu/article/details/69788500)
```C#
 public int ArrangeCoins(int n) 
 {
            long low = 1, high = n; 
            while (low < high)
            {
            //mid的类型为Long，一定注意！
                long mid = low + (high - low + 1) / 2;
                if ((mid + 1) * mid / 2.0 <= n) 
                    low = mid;
                else high = mid - 1;
            }
            return (int)high;
    }
```

* [#278 First Bad Version](http://blog.csdn.net/daigualu/article/details/69802371)
```C#
     public int FirstBadVersion(int n)
        {
            long lo = 0; //指向好的版本
            long hi = n; //指向坏的版本
            long mid;
            while (hi - lo > 1)
            {
                mid = (lo + hi) >> 1; //写为这样就不怕溢出(lo + (hi-lo)/2)
                if (IsBadVersion(mid))
                    hi = mid;
                else 
                    lo = mid;
            }
            return (int)hi;
        }
```

* [#349 Intersection of Two Arrays 350. Intersection of Two Arrays II](http://blog.csdn.net/daigualu/article/details/69666351)

```C#
 //交集定义，元素可重复
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            nums1 = nums1.OrderBy(r => r).ToArray(); //升序排列
            nums2 = nums2.OrderBy(r => r).ToArray();

            int n = nums1.Length < nums2.Length ? nums1.Length : nums2.Length;
            List<int> rtn = new List<int>();
            if (nums1.Length < nums2.Length)
            {
                rtn = getIntersection(nums1, nums2);
            }
            else
                rtn = getIntersection(nums2, nums1);
            return rtn.ToArray();
        }
	 //二分查找插入位置（相等元素，新插入位置靠后）
        //beginIndex：查询的起始位置
        private int searchInsertIndex(int[] sorted, int lo, int e)
        {
            int hi = sorted.Length;
            while (lo < hi)
            {
                int mi = (lo + hi) >> 1;
                if (e < sorted[mi])
                    hi = mi;
                else
                    lo = mi + 1;
            }
            return lo;
        }
	  //nums1个数小于后者得到交集
        private List<int> getIntersection(int[] nums1, int[] nums2)
        {
            List<int> rtn = new List<int>();
            int index = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                index = searchInsertIndex(nums2,index, nums1[i]);
                if (index <= 0) //nums2中一定不存在这个元素
                    continue;
                if (nums1[i] == nums2[index - 1])
                {
                    rtn.Add(nums1[i]);
                    int precnt = preSame(nums2, index - 1);
                    int succnt = sucSame(nums1, i);
                    int sml = precnt < succnt ? precnt : succnt;
                    while (sml-- > 0)
                        rtn.Add(nums1[i]);
                    if (succnt > 0)
                        i = i + succnt;
                }
            }
            return rtn;
        }
	//有序数组中向<----后搜索相等元素的个数
        private int preSame(int[] nums, int index)
        {
            int sameCnt = 0;
            for(int i = index; i>0; i--)
            {
                if (nums[index] == nums[i - 1])
                    sameCnt++;
            }
            return sameCnt;
        }

        //有序数组中向<----前搜索相等元素的个数
        private int sucSame(int[] nums, int index)
        {
            int sameCnt = 0;
            for (int i = index; i < nums.Length-1; i++)
            {
                if (nums[index] == nums[i + 1])
                    sameCnt++;
            }
            return sameCnt;
        }
```
* [#349 Intersection of Two Arrays](http://blog.csdn.net/daigualu/article/details/69666198)

```C#
 public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            HashSet<int> set1 = new HashSet<int>();
            foreach (var item in nums1)
            {
                if (!set1.Contains(item))
                    set1.Add(item);
            }

            HashSet<int> set2 = new HashSet<int>();
            foreach (var item in nums2)
            {
                if (!set2.Contains(item))
                    set2.Add(item);
            }
            return set1.Intersect(set2).ToArray();
        }
```


