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

# Details:
* Array tag:
* [#35 Search Insert Position](/Array/Array.Console/Array.Lib/SearchInsertPosition.cs)
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
* [#118 	Pascal’s Triangle](/Array/Array.Console/Array.Lib/PascalsTriangle.cs)
```C#
public IList<IList<int>> Generate(int numRows)
     {
        IList<IList<int>> rtn = new List<IList<int>>();
        for(int i=0; i<numRows;i++)
        {
            IList<int> ints = new List<int>();
            ints.Add(1); 
            for(int j=1;j<i;j++)
              {
                  IList<int> intsPreRow = rtn[i-1];
                  ints.Add(intsPreRow[j-1]+intsPreRow[j]);
              }
            if(i>0)
              ints.Add(1);

            rtn.Add(ints);
        }
        return rtn;
    }
```
* [#119 	Pascal’s Triangle II](/Array/Array.Console/Array.Lib/PascalsTriangleII.cs)
```C#
public IList<int> GetRow(int rowIndex) {
    if ( rowIndex<0 )  return new List<int>();  
    IList<int> levelList = new List<int>();
     for(int i=0;i<=rowIndex;i++) 
     {  
        int k=levelList.Count;  
        for(int j=k-1;j>=1;j--)  //这个循环是最重要的一部分，巧妙的运用了Pascal三角的特点
        {
            levelList[j]=levelList[j-1]+levelList[j]; 
        }
        levelList.Add(1);  
     }
    return levelList;  
    }
```
* [#414 	Third Maximum Number](/Array/Array.Console/Array.Lib/ThirdMaximumNumber.cs)
```C#
 public int GetThirdMax(int[] a)
        {
            int first = a.Max();
            int[] a2 = a.Where(r => r != first).ToArray();
            if (a2.Length == 0)
                return first;
            int second = a2.Max();
            int[] a3 = a2.Where(r => r != second).ToArray();
            if (a3.Length == 0)
                return first;
            return a3.Max();
        }
```
