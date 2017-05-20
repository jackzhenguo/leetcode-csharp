# About it
Algorithm is tool for exercising our thinking patterns, and we can strengthen the ability to convert mathematical models into code. Whether you are engaged in artificial intelligence, in-depth learning, or advanced software development, no matter what language you use, such as C#,C++,Java,python,etc., and applying the most appropriate algorithm is always the most important point when faced with a specific problem. *Every problem in practice has its own particularity, which makes it not that easier to choose the most appropriate algorithm.* How do we write the algorithm that most efficiently apply to a practical issue? **Yes, LeetCode.** You can write an algorithm until it accepted, and do not rush to do the next question, and learn the solution someone else has submitted, `so you can solve the problem from the ability of solving the problem to that fast and efficient realm`.
# leetcode-csharp
* Welcome to visit my CSDN blog(http://blog.csdn.net/daigualu) 
* CSDN Column(http://blog.csdn.net/column/details/14761.html) where detail solutions are.
## Leetcode-csharp Wiki
[My Wiki for this repository](https://github.com/jackzhenguo/leetcode-csharp/wiki)

## Contributing

1. Fork it!
2. Create your feature branch: git checkout -b my-leetcode-csharp
3. Commit your changes: git commit -am 'Add some questions and better solutions'
4. Push to the branch: git push origin my-leetcode-csharp
5. Submit a pull request and enjoy! :D

## `Today Update`
### Math
####  400 Nth Digit
*  [Github:#400 Nth Digit](/Math/Math.Lib/Nthdigit.cs)
*  [CSDN:#400 Nth Digit](http://blog.csdn.net/daigualu/article/details/72572244)
   * Tips:
     * careful to prevent overflowing for bas*digits, so declaring bas is long.
   ```C#
           //for this issue, there are two different ways to decribe a number
        //1 element. this is our common way
        //2 Nth digit. this is a new way
        public int FindNthDigit(int n)
        {
            long bas = 9;
            int digits = 1, i = 0;
            //first: getting n which digit is in
            while (n > bas * digits) // prevent overflowing. Since bas is long, so result of bas*digits is auto imporved as long
            {
                n -= (int)(bas * (digits++)); //nth
                i += (int)bas; //number of pasted elements
                bas *= 10; //1 digit->9; 2 digits->90; 3 digits->900, ...   
            }
            //second: Nth digit ->element
            //in all numbers containing digits, pasted numbers
            int pasted = (int)((n - 1) / digits);
            int element = pasted + i + 1;
            //third: once getting the element Nth digits stands,
            //(n-1)%digits of element is solution
            int nth = (n - 1) % digits;
            return element.ToString()[nth] - '0';
        }
   ```
#### 69 Sqrt(x)
*  [Github:#69 Sqrt(x)](/Math/Math.Lib/Sqrtx.cs)
*  [CSDN:#69 Sqrt(x)](http://blog.csdn.net/daigualu/article/details/72578272)
   * Tips:
     * careful to prevent overflowing! Again careful to **overflow**!
	 ```C#
	    public int MySqrt(int x)
        {
            int lo = 0, hi = x ;
            while (lo - hi < -1)
            {
            //get [lo,hi] middle point,then compare pow2 to x,
            // lo or hi is setted by mid
            //so accelarate the process
                long mid = lo + (hi - lo) / 2; //prevent overflowing
                long pow2 = mid * mid; //prevent overflowing
                if (pow2 < x) lo = (int)mid;
                else if (pow2 > x) hi = (int)mid;
                else return (int)mid;
            }
            return lo;
        }
	 ```
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

## Details
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

####  242 Valid Anagram
*  [Github:#242 Valid Anagram](/Array/Array.Lib/ValidAnagramSln.cs)
*  [CSDN: #242 Valid Anagram](http://blog.csdn.net/daigualu/article/details/71358552)
#### 561 Array Partition I
*  [Github: #205 Isomorphic Strings](/Array/Array.Lib/IsomorphicStringsSln.cs)
*  [CSDN: #205 Isomorphic Strings](http://blog.csdn.net/daigualu/article/details/71357419)
####  438 Find All Anagrams in a String
*  [Github:#438 Find All Anagrams in a String](/HashTable/HashTable.Lib/FindAllAnagramsSln.cs)
*  [CSDN:#438 Find All Anagrams in a String](http://blog.csdn.net/daigualu/article/details/71339879)
#### 204 Count Primes
*  [Github:#204 Count Primes](/HashTable/HashTable.Lib/PrimesCountSln.cs)
*  [CSDN:#204 Count Primes](http://blog.csdn.net/daigualu/article/details/71366483)
#### 500 Keyboard Row
*  [Github:#500 Keyboard Row](/HashTable/HashTable.Lib/KeyBoradRowSln.cs)
*  [CSDN:#500 Keyboard Row](http://blog.csdn.net/daigualu/article/details/71447614)
#### 389 Find the Difference
*  [Github:#389 Find the Difference](/HashTable/HashTable.Lib/FindDifferenceSln.cs)
*  [CSDN:#389 Find the Difference](http://blog.csdn.net/daigualu/article/details/71450823)
#### 380 Insert Delete GetRandom O(1)
*  [Github:#380 Insert Delete GetRandom O(1)](/HashTable/HashTable.Lib/RandomizedSet.cs)
*  [CSDN:#380 Insert Delete GetRandom O(1)](http://blog.csdn.net/daigualu/article/details/71550547)
#### 451 Sort Characters By Frequency
*  [Github:#451 Sort Characters By Frequency](/HashTable/HashTable.Lib/FrequSortSln.cs)
*  [CSDN:#451 Sort Characters By Frequency](http://blog.csdn.net/daigualu/article/details/71566159)
   * this problem solving is not by sorting order by frequency of chars! please read it.
#### 575 Distribute Candies
*  [Github:#575 Distribute Candies](/HashTable/HashTable.Lib/DistributeCandiessln.cs)
*  [CSDN:#575 Distribute Candies](http://blog.csdn.net/daigualu/article/details/71625170)
####  381 Insert Delete GetRandom O(1) - Duplicates allowed
*  [Github:# 381 Insert Delete GetRandom O(1) - Duplicates allowed](/HashTable/HashTable.Lib/RandomizedCollection.cs)
*  [CSDN:#381 Insert Delete GetRandom O(1) - Duplicates allowed](http://blog.csdn.net/daigualu/article/details/71618673)

## Linked List
* [#141 Linked List Cycle](http://blog.csdn.net/daigualu/article/details/69055927)

* [#237 Delete Node in a Linked List](http://blog.csdn.net/daigualu/article/details/69055991)

* [#83	Remove Duplicates from Sorted List](http://blog.csdn.net/daigualu/article/details/69093677)

* [#160 Intersection of Two Linked Lists](http://blog.csdn.net/daigualu/article/details/69526717)

* [#203	Remove Linked List Elements](http://blog.csdn.net/daigualu/article/details/69389243)

* [#206	Reverse Linked List](http://blog.csdn.net/daigualu/article/details/69372119)

* [#234	Palindrome Linked List](http://blog.csdn.net/daigualu/article/details/69388513)

* [#21	Merge Two Sorted Lists](http://blog.csdn.net/daigualu/article/details/69565969)

## Math    
* [#231 Power of Two](http://blog.csdn.net/daigualu/article/details/69102931)

* [#268 Missing Number](http://blog.csdn.net/daigualu/article/details/69220202)

* [#507	Perfect Number](http://blog.csdn.net/daigualu/article/details/69233798)

####  7 Reverse Integer
*  [Github:#7 Reverse Integer](/Math/Math.Lib/ReverseIntegarSln.cs)
*  [CSDN:#7 Reverse Integer](http://blog.csdn.net/daigualu/article/details/72464418)
*  Tips:
   * an interesting way to check if happens overflow.

#### 202 Happy Number
 *  [Github:#202 Happy Number](/Math/Math.Lib/HappyNumber.cs)
*   [CSDN:#202 Happy Number](http://blog.csdn.net/daigualu/article/details/71433906)
   * Floyd's Tortoise and Hare
   * reference:https://en.wikipedia.org/wiki/Cycle_detection
 ####  453 Minimum Moves to Equal Array Elements
*  [Github:#453 Minimum Moves to Equal Array Elements](/Math/Math.Lib/MinimumMovesSln.cs)
*  [CSDN:#453 Minimum Moves to Equal Array Elements](http://blog.csdn.net/daigualu/article/details/72354061)
*  Tips:
   * using Math equation to solve this issue!
####  415 Add Strings
*  [Github:#415 Add Strings](/Math/Math.Lib/AddStringsSln.cs)
*  [CSDN:#415 Add Strings](http://blog.csdn.net/daigualu/article/details/72356377)
*  Tips:
   * this is an interesting question!

## Two Pointers
* [#345	Reverse Vowels of a String](http://blog.csdn.net/daigualu/article/details/69257693)
	
* [#283 Move Zeroes](http://blog.csdn.net/daigualu/article/details/69329038)
	
* [#88	Merge Sorted Array](http://blog.csdn.net/daigualu/article/details/69367334)	

[#234Palindrome Linked List](http://blog.csdn.net/daigualu/article/details/69388513)

## String      
* [#58 Length of Last Word](http://blog.csdn.net/daigualu/article/details/69568460)

* [#20	 Valid Parentheses](http://blog.csdn.net/daigualu/article/details/69569622)	

* [#520 Detect Capital](http://blog.csdn.net/daigualu/article/details/69663210)

* [#459	Repeated Substring Pattern](http://blog.csdn.net/daigualu/article/details/69663545)

* [#434	Number of Segments in a String](http://blog.csdn.net/daigualu/article/details/69664369)

* [#14	Longest Common Prefix](http://blog.csdn.net/daigualu/article/details/69665015)	

* [#383	Ransom Note](http://blog.csdn.net/daigualu/article/details/69665190)	

## Binary Search
* [#367 Valid Perfect Square](http://blog.csdn.net/daigualu/article/details/69787644)

* [#167 Two Sum II - Input array is sorted](http://blog.csdn.net/daigualu/article/details/69787679)

* [#441 Arranging Coins](http://blog.csdn.net/daigualu/article/details/69788500)

* [#278 First Bad Version](http://blog.csdn.net/daigualu/article/details/69802371)

* [#349 Intersection of Two Arrays 350. Intersection of Two Arrays II](http://blog.csdn.net/daigualu/article/details/69666351)

* [#349 Intersection of Two Arrays](http://blog.csdn.net/daigualu/article/details/69666198)
## Tree
* [CSDN: #107	Binary Tree Level Order Traversal II](http://blog.csdn.net/daigualu/article/details/70254459)

* [CSDN: #257	Binary Tree Paths](http://blog.csdn.net/daigualu/article/details/70340125)
* [CSDN: #501 Find Mode in Binary Search Tree](http://blog.csdn.net/daigualu/article/details/70341143)
* [CSDN: #437	Path Sum III](http://blog.csdn.net/daigualu/article/details/70342773)
* [CSDN: #404 Sum of Left Leaves](http://blog.csdn.net/daigualu/article/details/70482270)
* [CSDN: #112 Path Sum](http://blog.csdn.net/daigualu/article/details/70482285)
* [CSDN: #110. Balanced Binary Tree](http://blog.csdn.net/daigualu/article/details/70482667)
* [CSDN: #108 Convert Sorted Array to Binary Search Tree](http://blog.csdn.net/daigualu/article/details/70485834)
* [CSDN: #543 Diameter of Binary Tree](http://blog.csdn.net/daigualu/article/details/70491447)
* [CSDN: #226 Invert Binary Tree](http://blog.csdn.net/daigualu/article/details/70536685)
* [CSDN: #235 Lowest Common Ancestor of a Binary Search Tree](http://blog.csdn.net/daigualu/article/details/70539096)
* [CSDN: #104 Maximum Depth of Binary Tree](http://blog.csdn.net/daigualu/article/details/70541420)
* [CSDN: #111 Minimum Depth of Binary Tree](http://blog.csdn.net/daigualu/article/details/70543969)
* [CSDN: #101 Symmetric Tree](http://blog.csdn.net/daigualu/article/details/70544774)
* [CSDN: #100 Same Tree](http://blog.csdn.net/daigualu/article/details/70254478)
#### 144 Binary Tree Preorder Traversal Stack version
*  [Github:#144 Binary Tree Preorder Traversal Stack version](/Tree/Tree.TreeLib/PreOrderStack.cs)
*  [CSDN:#144 Binary Tree Preorder Traversal Stack version](http://blog.csdn.net/daigualu/article/details/71749303)
####  94 Binary Tree Inorder Traversal Stack version
*  [Github:#94 Binary Tree Inorder Traversal Stack version](/Tree/Tree.TreeLib/InorderStack.cs)
*  [CSDN:#94 Binary Tree Inorder Traversal Stack version](http://blog.csdn.net/daigualu/article/details/71747542)
#### 572 Subtree of Another Tree
*  [Github:#572 Subtree of Another Tree](/Tree/Tree.TreeLib/IsSameTreeSln.cs)
*  [CSDN:#572 Subtree of Another Tree](http://blog.csdn.net/daigualu/article/details/71908238)
   * Subtree of Another Tree: it's extended from problem of "is same tree".
####  103 Binary Tree Zigzag Level Order Traversal
*  [Github:#103 Binary Tree Zigzag Level Order Traversal](/Tree/Tree.TreeLib/ZigzagLevelOrder.cs)
*  [CSDN:#103 Binary Tree Zigzag Level Order Traversal](http://blog.csdn.net/daigualu/article/details/72039636)
 ####  95 Unique Binary Search Trees II
*  [Github:#95 Unique Binary Search Trees II](/Tree/Tree.TreeLib/UniqueBSTSln.cs)
*  [CSDN:#95 Unique Binary Search Trees II](http://blog.csdn.net/daigualu/article/details/72051612)
   * this is the famous "Catalan number", please reference https://en.wikipedia.org/wiki/Catalan_number
     * apply 1: valid stack oepration: ((ab)c)d     (a(bc))d     (ab)(cd)     a((bc)d)     a(b(cd))
	 * apply 2: ![binary trees](/Tree/Tree.TreeLib/binarytrees.jpg)
	 * apply 3: ![triangles](/Tree/Tree.TreeLib/triangles.jpg)
	 * apply 4: ![stairs](/Tree/Tree.TreeLib/stairs.jpg)
####  105 Construct Binary Tree from Preorder and Inorder Traversal
*  [Github:#105 Construct Binary Tree from Preorder and Inorder Traversal](/Tree/Tree.TreeLib/BuildTreeByPreAndInorder.cs)
*  [CSDN:#105 Construct Binary Tree from Preorder and Inorder Traversal](http://blog.csdn.net/daigualu/article/details/72127022)
*  Tips:
   * the most important function in solving this issue is 
       *  private TreeNode bulidTree(int preStart, int inStart, int inEnd) ;
   * Plus, preStart index in preorder is the root index, which is also the separate point in inorder and it’s left is left subtree and right is right subtree.
