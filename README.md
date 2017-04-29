# leetcode-csharp
solutions using C# for leetcode according to tags of questions
Tags are following:  
* [Array](/Array)
* [Hash Table](/HashTable)
* [Linked List](/LinkedList)
* [Math](/Math)
* [Two Pointers](/TwoPointers)
* String
* Binary Search
* Divide and Conquer
* [Dynamic Programming](/DP)
* Backtracking
* [Stack](/Stack)
* [Tree](/Tree)

Details:
Array tag:
[#35 Search Insert Position](/Array/Array.Console/Array.Lib/SearchInsertPosition.cs)
```C#
 public int SearchInsert(int[] nums, int target) {
        int lo = 0;
        int hi = nums.Length;
        while(lo<hi){
            int mi = (lo+hi)>>1;
            if(target<=nums[mi]) //目标值不大于中间位置的数时，hi变小
               hi=mi;
            else if(target>nums[mi]) //大于中间位置的值，lo加1
               lo=lo+1;
        }
        return lo;
    }
```

