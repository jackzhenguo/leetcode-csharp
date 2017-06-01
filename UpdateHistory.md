# Update History

## Sort
### 324 Wiggle Sort II
*  [Github:#324 Wiggle Sort II](/Sort/WiggleSortSln.cs)
*  [CSDN:#324 Wiggle Sort II](http://blog.csdn.net/daigualu/article/details/72820281)
   > This is a great question for it involves a great idea: virtual index
   ```C#
   /// <summary>
    /// WiggleSort
    /// </summary>
    public class WiggleSortSln
    {
        private static int[] _array;

        public int[] WiggleSort(int[] array)
        {
            _array = array;
            int median = findKThLargest(_array.Length / 2);
            int left = 0, i = 0, right = _array.Length - 1;

            while (i <= right)
            {
                if (_array[newIndex(i)] > median)
                {
                    //put newIndex(i) at odd index(from 1, 3, to 5, ...)
                    swap(newIndex(left++), newIndex(i));
                    i++;
                }
                else if (_array[newIndex(i)] < median)
                {
                    //put newIndex(i) at even index(max even index to little .... ) 
                    swap(newIndex(right--), newIndex(i)); //right--, so i relatively toward right 1 step
                }
                else
                {
                    i++;
                }
            }
            return _array;
        }

        private int newIndex(int index)
        {
            return (1 + 2 * index) % (_array.Length | 1);
        }

        private void swap(int i, int j)
        {
            int tmp = _array[i];
            _array[i] = _array[j];
            _array[j] = tmp;
        }

        //based on quick sort to find the Kth largest in _array
        private int findKThLargest(int k)
        {
            int left = 0;
            int right = _array.Length - 1;
            while (true)
            {
                int pivotIndex = quickSort(left, right);
                if (k == pivotIndex)
                    return _array[pivotIndex];
                else if (k < pivotIndex)
                    right = pivotIndex - 1;
                else
                    left = pivotIndex + 1;
            }
        }

        private int quickSort(int lo, int hi)
        {
            int key = _array[lo];
            while (lo < hi)
            {
                while (lo < hi && _array[hi] >= key)
                    hi--;
                //hi is less than key, hi element moves to lo index
                _array[lo] = _array[hi];
                while (lo < hi && _array[lo] < key)
                    lo++;
                //lo is bigger than key, lo element moves to hi index 
                _array[hi] = _array[lo];
            }
            _array[lo] = key;
            return lo;
        }
    }
   ```
## Bit Mainpulation
### 342 Power of Four
*  [Github:#342 Power of Four](/BitManipulation/PowOfFourSln.cs)
*  [CSDN:#342 Power of Four](http://blog.csdn.net/daigualu/article/details/72821233)
