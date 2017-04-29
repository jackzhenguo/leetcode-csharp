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
## Array tag:
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
## Hash Table
* [#136 	Single number](/HashTable/HashTable.Lib/SingleOneSln.cs)

```C#
 public  int SingleNumber(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            foreach(int item in nums)
            {
                if (hash.Contains(item))
                    hash.Remove(item);
                else
                    hash.Add(item);
            }
            return hash.Min();

        }
```
* [#1 Two Sum](/HashTable/HashTable.Lib/TwoSumSln.cs)
```C#
public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0; i<nums.Length;i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                    return new int[] { dict[target - nums[i]] ,i};
                else
                    {
                      if(!dict.ContainsKey(nums[i])) //同一个元素不能用两次
                        dict.Add(nums[i], i);
                    }

            }
            return null;
        }
```

* [#447 Number of Boomerangs](/HashTable/HashTable.Lib/Boomerangs.cs)
```C#
        public static int NumberOfBoomerangs(int[,] points)
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();
            int len = points.GetUpperBound(0);
            int rtnCnt=0;
            for (int i = 0; i <= len; i++)
            {
                //3点变2点
                for (int j = 0; j <= len; j++)
                {
                    if (i == j) continue;
                    double d = distance(points[i, 0], points[j, 0], points[i, 1], points[j, 1]);
                    if (dict.ContainsKey(d))
                        dict[d]++;
                    else dict.Add(d, 1);
                }
                foreach(var item in dict)
                {
                    if (item.Value > 1)
                    {
                        //如果找到了value个，因为有顺序，所以排序
                        rtnCnt += item.Value*(item.Value-1); 
                    }
                }
                dict.Clear();
            }
            return rtnCnt;
        }

        private static double distance(int x1, int x2, int y1, int y2)
        {
            int x = x1 - x2;
            int y = y1 - y2;

            return Math.Sqrt(x * x + y * y);
        }
```




* [#463. Island Perimeter](/HashTable/HashTable.Lib/IslandPerimeter.cs)
```C#
       public int LandPerimeter(int[,] grid)
       {
           int rtn=0;
           for(int i=0; i<=grid.GetUpperBound(0);i++)
           {
               for(int j=0;j<=grid.GetUpperBound(1);j++)
               {
                   if (grid[i, j] == 1)
                       rtn +=4-surroundingIsland(grid,i,j);
               }
           }
           return rtn;
       }

       //获取某个网格周围的网格数（[0,4]）
       //noy: y向网格索引（行）
       //nox：x向网格索引（列）
       private int surroundingIsland(int[,] grid, int noy, int nox)
       {
           int rtnCnt=0;
           if (nox > 0)
           {
               if (grid[noy, nox - 1] == 1)
                   rtnCnt++;
           }
           if (nox < grid.GetUpperBound(1))//nox小于（列）最大索引吗
           {
               if (grid[noy, nox + 1] == 1)
                   rtnCnt++;
           }
           if (noy > 0)
           {
               if (grid[noy - 1, nox] == 1)
                   rtnCnt++;
           }
           if(noy<grid.GetUpperBound(0))//noy小于最大（行）索引吗
           {
               if (grid[noy + 1, nox] == 1)
                   rtnCnt++;
           }
           return rtnCnt;
       }
```



* [#409	Longest Palindrome](/HashTable/HashTable.Lib/LongestPalindrome.cs)

```C#
        public int NumberOfPalindrome(string s)
        {
            HashSet<int> hash = new HashSet<int>();
            int count = 0;
            foreach (var item in s)
            {
                if (hash.Contains(item))
                {
                    hash.Remove(item); //配对成功，
                    count++;           //count加1
                }
                else
                    hash.Add(item);
            }
            return hash.Count > 0 ? count * 2 + 1 : count * 2;
        }
```


